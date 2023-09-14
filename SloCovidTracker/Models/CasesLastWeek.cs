namespace SloCovidTracker.Models;

public class CasesLastWeek
{
    public string Region { get; }
    public int NrCases { get; }

    public CasesLastWeek(string region, int nrCases)
    {
        Region = region;
        NrCases = nrCases;
    }
}