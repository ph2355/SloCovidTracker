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

    [HttpGet("Cases")]
    public IEnumerable<DailyCasesByRegion> GetCases(List<string> regions, string from, string to)
    {
        return Enumerable.Empty<DailyCasesByRegion>();
    }
    
    [HttpGet("LastWeek")]
    public IEnumerable<CasesLastWeek> GetLastWeek()
    {
        return Enumerable.Empty<CasesLastWeek>();
    }
}