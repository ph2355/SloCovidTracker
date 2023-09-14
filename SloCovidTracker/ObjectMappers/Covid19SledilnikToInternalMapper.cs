using SloCovidTracker.Models;
using SloCovidTracker.Models.Covid19Sledilnik;

namespace SloCovidTracker.ObjectMappers;

public static class Covid19SledilnikToInternalMapper
{
    public static IEnumerable<DailyCasesByRegion> DailyCasesToDailyCasesByRegion(DailyCases dailyCases)
    {
        if (dailyCases.Date == null)
        {
            return Enumerable.Empty<DailyCasesByRegion>();
        }
        
        List<DailyCasesByRegion> dailyCasesByRegionsList = new List<DailyCasesByRegion>
        {
            new DailyCasesByRegion(DateTime.ParseExact(dailyCases.Date, "yyyy-MM-dd", null), Regions.LJ, dailyCases.CasesActiveLJ,
                dailyCases.Vaccinated1stToDateLJ, dailyCases.Vaccinated2ndToDateLJ, dailyCases.DeceasedToDateLJ),
            new DailyCasesByRegion(DateTime.ParseExact(dailyCases.Date, "yyyy-MM-dd", null), Regions.CE, dailyCases.CasesActiveCE,
                dailyCases.Vaccinated1stToDateCE, dailyCases.Vaccinated2ndToDateCE, dailyCases.DeceasedToDateCE),
            new DailyCasesByRegion(DateTime.ParseExact(dailyCases.Date, "yyyy-MM-dd", null), Regions.KR, dailyCases.CasesActiveKR,
                dailyCases.Vaccinated1stToDateKR, dailyCases.Vaccinated2ndToDateKR, dailyCases.DeceasedToDateKR),
            new DailyCasesByRegion(DateTime.ParseExact(dailyCases.Date, "yyyy-MM-dd", null), Regions.NM, dailyCases.CasesActiveNM,
                dailyCases.Vaccinated1stToDateNM, dailyCases.Vaccinated2ndToDateNM, dailyCases.DeceasedToDateNM),
            new DailyCasesByRegion(DateTime.ParseExact(dailyCases.Date, "yyyy-MM-dd", null), Regions.KK, dailyCases.CasesActiveKK,
                dailyCases.Vaccinated1stToDateKK, dailyCases.Vaccinated2ndToDateKK, dailyCases.DeceasedToDateKK),
            new DailyCasesByRegion(DateTime.ParseExact(dailyCases.Date, "yyyy-MM-dd", null), Regions.KP, dailyCases.CasesActiveKP,
                dailyCases.Vaccinated1stToDateKP, dailyCases.Vaccinated2ndToDateKP, dailyCases.DeceasedToDateKP),
            new DailyCasesByRegion(DateTime.ParseExact(dailyCases.Date, "yyyy-MM-dd", null), Regions.MB, dailyCases.CasesActiveMB,
                dailyCases.Vaccinated1stToDateMB, dailyCases.Vaccinated2ndToDateMB, dailyCases.DeceasedToDateMB),
            new DailyCasesByRegion(DateTime.ParseExact(dailyCases.Date, "yyyy-MM-dd", null), Regions.MS, dailyCases.CasesActiveMS,
                dailyCases.Vaccinated1stToDateMS, dailyCases.Vaccinated2ndToDateMS, dailyCases.DeceasedToDateMS),
            new DailyCasesByRegion(DateTime.ParseExact(dailyCases.Date, "yyyy-MM-dd", null), Regions.NG, dailyCases.CasesActiveNG,
                dailyCases.Vaccinated1stToDateNG, dailyCases.Vaccinated2ndToDateNG, dailyCases.DeceasedToDateNG),
            new DailyCasesByRegion(DateTime.ParseExact(dailyCases.Date, "yyyy-MM-dd", null), Regions.PO, dailyCases.CasesActivePO,
                dailyCases.Vaccinated1stToDatePO, dailyCases.Vaccinated2ndToDatePO, dailyCases.DeceasedToDatePO),
            new DailyCasesByRegion(DateTime.ParseExact(dailyCases.Date, "yyyy-MM-dd", null), Regions.SG, dailyCases.CasesActiveSG,
                dailyCases.Vaccinated1stToDateSG, dailyCases.Vaccinated2ndToDateSG, dailyCases.DeceasedToDateSG),
            new DailyCasesByRegion(DateTime.ParseExact(dailyCases.Date, "yyyy-MM-dd", null), Regions.ZA, dailyCases.CasesActiveZA,
                dailyCases.Vaccinated1stToDateZA, dailyCases.Vaccinated2ndToDateZA, dailyCases.DeceasedToDateZA)
        };

        return dailyCasesByRegionsList;
    }
    
    public static IEnumerable<DailyCasesByRegion> DailyCasesListToDailyCasesByRegionList(IEnumerable<DailyCases> dailyCasesList)
    {
        return dailyCasesList.SelectMany(dailyCases => DailyCasesToDailyCasesByRegion(dailyCases));
    }
    
}