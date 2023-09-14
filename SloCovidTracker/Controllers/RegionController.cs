using Microsoft.AspNetCore.Mvc;
using SloCovidTracker.Models;

namespace SloCovidTracker.Controllers;

[ApiController]
[Route("api/[controller]")]
public class RegionController : ControllerBase
{
    private readonly ILogger<RegionController> _logger;

    public RegionController(ILogger<RegionController> logger)
    {
        _logger = logger;
    }

    /// <summary>
    /// Get a list of daily cases, number of vaccinated 1st and 2nd to date, deaths to date. 
    /// </summary>
    /// <param name="regions"></param>
    /// <param name="from"></param>
    /// <param name="to"></param>
    /// <returns></returns>
    [HttpGet("Cases")]
    public IEnumerable<DailyCasesByRegion> GetCases(List<string> regions, string from, string to)
    {
        return Enumerable.Empty<DailyCasesByRegion>();
    }
    
    /// <summary>
    /// Get average number of cases for each region in the last 7 days.
    /// </summary>
    /// <returns></returns>
    [HttpGet("LastWeek")]
    public IEnumerable<CasesLastWeek> GetLastWeek()
    {
        return Enumerable.Empty<CasesLastWeek>();
    }
}