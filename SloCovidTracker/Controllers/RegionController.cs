using Microsoft.AspNetCore.Mvc;
using SloCovidTracker.Models;
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
    public async Task<IEnumerable<DailyCasesByRegion>> GetCases(List<string> regions, string from, string to)
    {
        var dailyCases = await _covid19SledilnikService.GetData();
        
        
        
        return Enumerable.Empty<DailyCasesByRegion>();
    }
    
    /// <summary>
    /// Get average number of cases for each region in the last 7 days.
    /// </summary>
    /// <returns></returns>
    [HttpGet("LastWeek")]
    public async Task<IEnumerable<CasesLastWeek>> GetLastWeek()
    {
        var dailyCases = await _covid19SledilnikService.GetData();
        
        // var averageByCategory = dailyCases.GroupBy(cases => cases.)
        
        return Enumerable.Empty<CasesLastWeek>();
    }
}