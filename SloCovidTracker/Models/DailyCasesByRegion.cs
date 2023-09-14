namespace SloCovidTracker.Models;

public class DailyCasesByRegion
{
    public string Date { get; }
    public string Region { get; }
    public int NrActiveCases { get; }
    public int NrVaccinated1St { get; }
    public int NrVaccinated2Nd { get; }
    public int NrDeceasedToDate { get; }

    public DailyCasesByRegion(string date, string region, int nrActiveCases, int nrVaccinated1St, int nrVaccinated2Nd, int nrDeceasedToDate)
    {
        Date = date;
        Region = region;
        NrActiveCases = nrActiveCases;
        NrVaccinated1St = nrVaccinated1St;
        NrVaccinated2Nd = nrVaccinated2Nd;
        NrDeceasedToDate = nrDeceasedToDate;
    }
}