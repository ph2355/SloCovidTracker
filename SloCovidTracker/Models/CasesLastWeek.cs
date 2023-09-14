namespace SloCovidTracker.Models;

public class CasesLastWeek
{
    public string Region { get; }
    public double? NrCases { get; }

    public CasesLastWeek(string region, double? nrCases)
    {
        Region = region;
        NrCases = nrCases;
    }
}