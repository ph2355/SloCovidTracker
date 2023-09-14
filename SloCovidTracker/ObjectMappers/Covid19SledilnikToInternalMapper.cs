using SloCovidTracker.Models;
using SloCovidTracker.Models.Covid19Sledilnik;

namespace SloCovidTracker.ObjectMappers;

public static class Covid19SledilnikToInternalMapper
{
    public static IEnumerable<DailyCasesByRegion> DailyCasesToDailyCasesByRegion(DailyCases dailyCases)
    {
        List<DailyCasesByRegion> dailyCasesByRegionsList = new List<DailyCasesByRegion>();

        dailyCasesByRegionsList.Add(new DailyCasesByRegion(dailyCases.Date, Regions.LJ, dailyCases.CasesActiveLJ,
            dailyCases.Vaccinated1stToDateLJ, dailyCases.Vaccinated2ndToDateLJ, dailyCases.DeceasedToDateLJ));
        
        dailyCasesByRegionsList.Add(new DailyCasesByRegion(dailyCases.Date, Regions.CE, dailyCases.CasesActiveCE,
            dailyCases.Vaccinated1stToDateCE, dailyCases.Vaccinated2ndToDateCE, dailyCases.DeceasedToDateCE));
        
        dailyCasesByRegionsList.Add(new DailyCasesByRegion(dailyCases.Date, Regions.KR, dailyCases.CasesActiveKR,
            dailyCases.Vaccinated1stToDateKR, dailyCases.Vaccinated2ndToDateKR, dailyCases.DeceasedToDateKR));
        
        dailyCasesByRegionsList.Add(new DailyCasesByRegion(dailyCases.Date, Regions.NM, dailyCases.CasesActiveNM,
            dailyCases.Vaccinated1stToDateNM, dailyCases.Vaccinated2ndToDateNM, dailyCases.DeceasedToDateNM));
        
        dailyCasesByRegionsList.Add(new DailyCasesByRegion(dailyCases.Date, Regions.KK, dailyCases.CasesActiveKK,
            dailyCases.Vaccinated1stToDateKK, dailyCases.Vaccinated2ndToDateKK, dailyCases.DeceasedToDateKK));
        
        dailyCasesByRegionsList.Add(new DailyCasesByRegion(dailyCases.Date, Regions.KP, dailyCases.CasesActiveKP,
            dailyCases.Vaccinated1stToDateKP, dailyCases.Vaccinated2ndToDateKP, dailyCases.DeceasedToDateKP));
        
        dailyCasesByRegionsList.Add(new DailyCasesByRegion(dailyCases.Date, Regions.MB, dailyCases.CasesActiveMB,
            dailyCases.Vaccinated1stToDateMB, dailyCases.Vaccinated2ndToDateMB, dailyCases.DeceasedToDateMB));
        
        dailyCasesByRegionsList.Add(new DailyCasesByRegion(dailyCases.Date, Regions.MS, dailyCases.CasesActiveMS,
            dailyCases.Vaccinated1stToDateMS, dailyCases.Vaccinated2ndToDateMS, dailyCases.DeceasedToDateMS));
        
        dailyCasesByRegionsList.Add(new DailyCasesByRegion(dailyCases.Date, Regions.NG, dailyCases.CasesActiveNG,
            dailyCases.Vaccinated1stToDateNG, dailyCases.Vaccinated2ndToDateNG, dailyCases.DeceasedToDateNG));
        
        dailyCasesByRegionsList.Add(new DailyCasesByRegion(dailyCases.Date, Regions.PO, dailyCases.CasesActivePO,
            dailyCases.Vaccinated1stToDatePO, dailyCases.Vaccinated2ndToDatePO, dailyCases.DeceasedToDatePO));
        
        dailyCasesByRegionsList.Add(new DailyCasesByRegion(dailyCases.Date, Regions.SG, dailyCases.CasesActiveSG,
            dailyCases.Vaccinated1stToDateSG, dailyCases.Vaccinated2ndToDateSG, dailyCases.DeceasedToDateSG));
        
        dailyCasesByRegionsList.Add(new DailyCasesByRegion(dailyCases.Date, Regions.ZA, dailyCases.CasesActiveZA,
            dailyCases.Vaccinated1stToDateZA, dailyCases.Vaccinated2ndToDateZA, dailyCases.DeceasedToDateZA));

        return dailyCasesByRegionsList;
    }
}