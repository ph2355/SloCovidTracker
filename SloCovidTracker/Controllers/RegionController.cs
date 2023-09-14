using System.Globalization;
using Microsoft.AspNetCore.Mvc;
using SloCovidTracker.Models;
using SloCovidTracker.ObjectMappers;
using SloCovidTracker.Services;

namespace SloCovidTracker.Controllers;


[ApiController]
[Route("api/[controller]")]
public class RegionController : ControllerBase
{
    private readonly ILogger<RegionController> _logger;
    private readonly Covid19SledilnikService _covid19SledilnikService;

    public RegionController(ILogger<RegionController> logger, Covid19SledilnikService covid19SledilnikService)
    {
        _logger = logger;
        _covid19SledilnikService = covid19SledilnikService;
    }

    /// <summary>
    /// Get a list of daily cases, number of vaccinated 1st and 2nd to date, deaths to date. 
    /// </summary>
    /// <param name="regions"></param>
    /// <param name="from"></param>
    /// <param name="to"></param>
    /// <returns></returns>
    [HttpGet("Cases")]
    public async Task<IEnumerable<DailyCasesByRegion>> GetCases([FromQuery] List<string>? regions, string? from, string? to)
    {
        var dailyCases = await _covid19SledilnikService.GetData();
        var dailyCasesByRegion = Covid19SledilnikToInternalMapper.DailyCasesListToDailyCasesByRegionList(dailyCases);

        // check if regions are valid
        var regionsValid = regions?.All(region => Regions.IsValid(region));
        if (regionsValid.HasValue && !regionsValid.Value)
        {
            // TODO should return error
            return Enumerable.Empty<DailyCasesByRegion>();
        }

        DateTime? fromDateTime = null;
        DateTime? toDateTime = null;
        
        // check if from date valid
        if (from != null)
        {
            if (!DateTime.TryParseExact(from, "yyyy-MM-dd", null, DateTimeStyles.None, out DateTime parsedDate))
            {
                // TODO should return error
                return Enumerable.Empty<DailyCasesByRegion>();
            }
            fromDateTime = parsedDate;
        }

        // check if to date valid
        if (to != null)
        {
            if (!DateTime.TryParseExact(to, "yyyy-MM-dd", null, DateTimeStyles.None, out DateTime parsedDate))
            {
                // TODO should return error
                return Enumerable.Empty<DailyCasesByRegion>();
            }
            toDateTime = parsedDate;
        }

        return dailyCasesByRegion
            .Where(cases => regions == null || regions.Contains(cases.Region))
            .Where(cases => fromDateTime == null || cases.Date.CompareTo(fromDateTime) >= 0)
            .Where(cases => toDateTime == null || cases.Date.CompareTo(toDateTime) <= 0);
    }
    
    /// <summary>
    /// Get average number of cases for each region in the last 7 days.
    /// </summary>
    /// <returns></returns>
    [HttpGet("LastWeek")]
    public async Task<IEnumerable<CasesLastWeek>> GetLastWeek()
    {
        var dailyCases = await _covid19SledilnikService.GetData();
        var dailyCasesByRegion = Covid19SledilnikToInternalMapper.DailyCasesListToDailyCasesByRegionList(dailyCases);

        var currentDate = DateTime.ParseExact("2023-04-02", "yyyy-MM-dd", null);
        var sevenDaysAgo = currentDate.AddDays(-7);
        
        var averageByCategory = dailyCasesByRegion
            .Where(cases => cases.Date.CompareTo(currentDate) == -1 && cases.Date.CompareTo(sevenDaysAgo) == 1)
            .GroupBy(cases => cases.Region)
            .Select(group => new CasesLastWeek(group.Key, group.Average(cases => cases.NrActiveCases)))
            .OrderByDescending(cases => cases.NrCases);

        return averageByCategory;
    }
}