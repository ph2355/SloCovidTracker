namespace SloCovidTracker.Models.Covid19Sledilnik;
using CsvHelper.Configuration.Attributes;

public class DailyCases
{
    
    [Name("date")]
    public string? Date { get; set; }

    [Name("region.ce.cases.active")]
    public int? CasesActiveCE { get; set; }

    [Name("region.ce.cases.confirmed.todate")]
    public int? CasesConfirmedToDateCE { get; set; }

    [Name("region.ce.deceased.todate")]
    public int? DeceasedToDateCE { get; set; }

    [Name("region.ce.vaccinated.1st.todate")]
    public int? Vaccinated1stToDateCE { get; set; }

    [Name("region.ce.vaccinated.2nd.todate")]
    public int? Vaccinated2ndToDateCE { get; set; }

    [Name("region.ce.vaccinated.3rd.todate")]
    public int? Vaccinated3rdToDateCE { get; set; }

    [Name("region.foreign.cases.active")]
    public int? CasesActiveForeign { get; set; }

    [Name("region.foreign.cases.confirmed.todate")]
    public int? CasesConfirmedToDateForeign { get; set; }

    [Name("region.foreign.deceased.todate")]
    public int? DeceasedToDateForeign { get; set; }

    [Name("region.kk.cases.active")]
    public int? CasesActiveKK { get; set; }

    [Name("region.kk.cases.confirmed.todate")]
    public int? CasesConfirmedToDateKK { get; set; }

    [Name("region.kk.deceased.todate")]
    public int? DeceasedToDateKK { get; set; }

    [Name("region.kk.vaccinated.1st.todate")]
    public int? Vaccinated1stToDateKK { get; set; }

    [Name("region.kk.vaccinated.2nd.todate")]
    public int? Vaccinated2ndToDateKK { get; set; }

    [Name("region.kk.vaccinated.3rd.todate")]
    public int? Vaccinated3rdToDateKK { get; set; }

    [Name("region.kp.cases.active")]
    public int? CasesActiveKP { get; set; }

    [Name("region.kp.cases.confirmed.todate")]
    public int? CasesConfirmedToDateKP { get; set; }

    [Name("region.kp.deceased.todate")]
    public int? DeceasedToDateKP { get; set; }

    [Name("region.kp.vaccinated.1st.todate")]
    public int? Vaccinated1stToDateKP { get; set; }

    [Name("region.kp.vaccinated.2nd.todate")]
    public int? Vaccinated2ndToDateKP { get; set; }

    [Name("region.kp.vaccinated.3rd.todate")]
    public int? Vaccinated3rdToDateKP { get; set; }

    [Name("region.kr.cases.active")]
    public int? CasesActiveKR { get; set; }

    [Name("region.kr.cases.confirmed.todate")]
    public int? CasesConfirmedToDateKR { get; set; }

    [Name("region.kr.deceased.todate")]
    public int? DeceasedToDateKR { get; set; }

    [Name("region.kr.vaccinated.1st.todate")]
    public int? Vaccinated1stToDateKR { get; set; }

    [Name("region.kr.vaccinated.2nd.todate")]
    public int? Vaccinated2ndToDateKR { get; set; }

    [Name("region.kr.vaccinated.3rd.todate")]
    public int? Vaccinated3rdToDateKR { get; set; }

    [Name("region.lj.cases.active")]
    public int? CasesActiveLJ { get; set; }

    [Name("region.lj.cases.confirmed.todate")]
    public int? CasesConfirmedToDateLJ { get; set; }

    [Name("region.lj.deceased.todate")]
    public int? DeceasedToDateLJ { get; set; }

    [Name("region.lj.vaccinated.1st.todate")]
    public int? Vaccinated1stToDateLJ { get; set; }

    [Name("region.lj.vaccinated.2nd.todate")]
    public int? Vaccinated2ndToDateLJ { get; set; }

    [Name("region.lj.vaccinated.3rd.todate")]
    public int? Vaccinated3rdToDateLJ { get; set; }

    [Name("region.mb.cases.active")]
    public int? CasesActiveMB { get; set; }

    [Name("region.mb.cases.confirmed.todate")]
    public int? CasesConfirmedToDateMB { get; set; }

    [Name("region.mb.deceased.todate")]
    public int? DeceasedToDateMB { get; set; }

    [Name("region.mb.vaccinated.1st.todate")]
    public int? Vaccinated1stToDateMB { get; set; }

    [Name("region.mb.vaccinated.2nd.todate")]
    public int? Vaccinated2ndToDateMB { get; set; }

    [Name("region.mb.vaccinated.3rd.todate")]
    public int? Vaccinated3rdToDateMB { get; set; }

    [Name("region.ms.cases.active")]
    public int? CasesActiveMS { get; set; }

    [Name("region.ms.cases.confirmed.todate")]
    public int? CasesConfirmedToDateMS { get; set; }

    [Name("region.ms.deceased.todate")]
    public int? DeceasedToDateMS { get; set; }

    [Name("region.ms.vaccinated.1st.todate")]
    public int? Vaccinated1stToDateMS { get; set; }

    [Name("region.ms.vaccinated.2nd.todate")]
    public int? Vaccinated2ndToDateMS { get; set; }

    [Name("region.ms.vaccinated.3rd.todate")]
    public int? Vaccinated3rdToDateMS { get; set; }

    [Name("region.ng.cases.active")]
    public int? CasesActiveNG { get; set; }

    [Name("region.ng.cases.confirmed.todate")]
    public int? CasesConfirmedToDateNG { get; set; }

    [Name("region.ng.deceased.todate")]
    public int? DeceasedToDateNG { get; set; }

    [Name("region.ng.vaccinated.1st.todate")]
    public int? Vaccinated1stToDateNG { get; set; }

    [Name("region.ng.vaccinated.2nd.todate")]
    public int? Vaccinated2ndToDateNG { get; set; }

    [Name("region.ng.vaccinated.3rd.todate")]
    public int? Vaccinated3rdToDateNG { get; set; }

    [Name("region.nm.cases.active")]
    public int? CasesActiveNM { get; set; }

    [Name("region.nm.cases.confirmed.todate")]
    public int? CasesConfirmedToDateNM { get; set; }

    [Name("region.nm.deceased.todate")]
    public int? DeceasedToDateNM { get; set; }

    [Name("region.nm.vaccinated.1st.todate")]
    public int? Vaccinated1stToDateNM { get; set; }

    [Name("region.nm.vaccinated.2nd.todate")]
    public int? Vaccinated2ndToDateNM { get; set; }

    [Name("region.nm.vaccinated.3rd.todate")]
    public int? Vaccinated3rdToDateNM { get; set; }

    [Name("region.po.cases.active")]
    public int? CasesActivePO { get; set; }

    [Name("region.po.cases.confirmed.todate")]
    public int? CasesConfirmedToDatePO { get; set; }

    [Name("region.po.deceased.todate")]
    public int? DeceasedToDatePO { get; set; }

    [Name("region.po.vaccinated.1st.todate")]
    public int? Vaccinated1stToDatePO { get; set; }

    [Name("region.po.vaccinated.2nd.todate")]
    public int? Vaccinated2ndToDatePO { get; set; }

    [Name("region.po.vaccinated.3rd.todate")]
    public int? Vaccinated3rdToDatePO { get; set; }

    [Name("region.sg.cases.active")]
    public int? CasesActiveSG { get; set; }

    [Name("region.sg.cases.confirmed.todate")]
    public int? CasesConfirmedToDateSG { get; set; }

    [Name("region.sg.deceased.todate")]
    public int? DeceasedToDateSG { get; set; }

    [Name("region.sg.vaccinated.1st.todate")]
    public int? Vaccinated1stToDateSG { get; set; }

    [Name("region.sg.vaccinated.2nd.todate")]
    public int? Vaccinated2ndToDateSG { get; set; }

    [Name("region.sg.vaccinated.3rd.todate")]
    public int? Vaccinated3rdToDateSG { get; set; }

    [Name("region.unknown.cases.active")]
    public int? CasesActiveUnknown { get; set; }

    [Name("region.unknown.cases.confirmed.todate")]
    public int? CasesConfirmedToDateUnknown { get; set; }

    [Name("region.unknown.deceased.todate")]
    public int? DeceasedToDateUnknown { get; set; }

    [Name("region.za.cases.active")]
    public int? CasesActiveZA { get; set; }

    [Name("region.za.cases.confirmed.todate")]
    public int? CasesConfirmedToDateZA { get; set; }

    [Name("region.za.deceased.todate")]
    public int? DeceasedToDateZA { get; set; }

    [Name("region.za.vaccinated.1st.todate")]
    public int? Vaccinated1stToDateZA { get; set; }

    [Name("region.za.vaccinated.2nd.todate")]
    public int? Vaccinated2ndToDateZA { get; set; }

    [Name("region.za.vaccinated.3rd.todate")]
    public int? Vaccinated3rdToDateZA { get; set; }
}