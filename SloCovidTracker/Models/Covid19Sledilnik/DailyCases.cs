namespace SloCovidTracker.Models.Covid19Sledilnik;
using CsvHelper.Configuration.Attributes;

public class DailyCases
{
    [Name("date")]
    public string Date { get; }

    [Name("region.ce.cases.active")]
    public int CasesActiveCE { get; }

    [Name("region.ce.cases.confirmed.todate")]
    public int CasesConfirmedToDateCE { get; }

    [Name("region.ce.deceased.todate")]
    public int DeceasedToDateCE { get; }

    [Name("region.ce.vaccinated.1st.todate")]
    public int Vaccinated1stToDateCE { get; }

    [Name("region.ce.vaccinated.2nd.todate")]
    public int Vaccinated2ndToDateCE { get; }

    [Name("region.ce.vaccinated.3rd.todate")]
    public int Vaccinated3rdToDateCE { get; }

    [Name("region.foreign.cases.active")]
    public int CasesActiveForeign { get; }

    [Name("region.foreign.cases.confirmed.todate")]
    public int CasesConfirmedToDateForeign { get; }

    [Name("region.foreign.deceased.todate")]
    public int DeceasedToDateForeign { get; }

    [Name("region.kk.cases.active")]
    public int CasesActiveKK { get; }

    [Name("region.kk.cases.confirmed.todate")]
    public int CasesConfirmedToDateKK { get; }

    [Name("region.kk.deceased.todate")]
    public int DeceasedToDateKK { get; }

    [Name("region.kk.vaccinated.1st.todate")]
    public int Vaccinated1stToDateKK { get; }

    [Name("region.kk.vaccinated.2nd.todate")]
    public int Vaccinated2ndToDateKK { get; }

    [Name("region.kk.vaccinated.3rd.todate")]
    public int Vaccinated3rdToDateKK { get; }

    [Name("region.kp.cases.active")]
    public int CasesActiveKP { get; }

    [Name("region.kp.cases.confirmed.todate")]
    public int CasesConfirmedToDateKP { get; }

    [Name("region.kp.deceased.todate")]
    public int DeceasedToDateKP { get; }

    [Name("region.kp.vaccinated.1st.todate")]
    public int Vaccinated1stToDateKP { get; }

    [Name("region.kp.vaccinated.2nd.todate")]
    public int Vaccinated2ndToDateKP { get; }

    [Name("region.kp.vaccinated.3rd.todate")]
    public int Vaccinated3rdToDateKP { get; }

    [Name("region.kr.cases.active")]
    public int CasesActiveKR { get; }

    [Name("region.kr.cases.confirmed.todate")]
    public int CasesConfirmedToDateKR { get; }

    [Name("region.kr.deceased.todate")]
    public int DeceasedToDateKR { get; }

    [Name("region.kr.vaccinated.1st.todate")]
    public int Vaccinated1stToDateKR { get; }

    [Name("region.kr.vaccinated.2nd.todate")]
    public int Vaccinated2ndToDateKR { get; }

    [Name("region.kr.vaccinated.3rd.todate")]
    public int Vaccinated3rdToDateKR { get; }

    [Name("region.lj.cases.active")]
    public int CasesActiveLJ { get; }

    [Name("region.lj.cases.confirmed.todate")]
    public int CasesConfirmedToDateLJ { get; }

    [Name("region.lj.deceased.todate")]
    public int DeceasedToDateLJ { get; }

    [Name("region.lj.vaccinated.1st.todate")]
    public int Vaccinated1stToDateLJ { get; }

    [Name("region.lj.vaccinated.2nd.todate")]
    public int Vaccinated2ndToDateLJ { get; }

    [Name("region.lj.vaccinated.3rd.todate")]
    public int Vaccinated3rdToDateLJ { get; }

    [Name("region.mb.cases.active")]
    public int CasesActiveMB { get; }

    [Name("region.mb.cases.confirmed.todate")]
    public int CasesConfirmedToDateMB { get; }

    [Name("region.mb.deceased.todate")]
    public int DeceasedToDateMB { get; }

    [Name("region.mb.vaccinated.1st.todate")]
    public int Vaccinated1stToDateMB { get; }

    [Name("region.mb.vaccinated.2nd.todate")]
    public int Vaccinated2ndToDateMB { get; }

    [Name("region.mb.vaccinated.3rd.todate")]
    public int Vaccinated3rdToDateMB { get; }

    [Name("region.ms.cases.active")]
    public int CasesActiveMS { get; }

    [Name("region.ms.cases.confirmed.todate")]
    public int CasesConfirmedToDateMS { get; }

    [Name("region.ms.deceased.todate")]
    public int DeceasedToDateMS { get; }

    [Name("region.ms.vaccinated.1st.todate")]
    public int Vaccinated1stToDateMS { get; }

    [Name("region.ms.vaccinated.2nd.todate")]
    public int Vaccinated2ndToDateMS { get; }

    [Name("region.ms.vaccinated.3rd.todate")]
    public int Vaccinated3rdToDateMS { get; }

    [Name("region.ng.cases.active")]
    public int CasesActiveNG { get; }

    [Name("region.ng.cases.confirmed.todate")]
    public int CasesConfirmedToDateNG { get; }

    [Name("region.ng.deceased.todate")]
    public int DeceasedToDateNG { get; }

    [Name("region.ng.vaccinated.1st.todate")]
    public int Vaccinated1stToDateNG { get; }

    [Name("region.ng.vaccinated.2nd.todate")]
    public int Vaccinated2ndToDateNG { get; }

    [Name("region.ng.vaccinated.3rd.todate")]
    public int Vaccinated3rdToDateNG { get; }

    [Name("region.nm.cases.active")]
    public int CasesActiveNM { get; }

    [Name("region.nm.cases.confirmed.todate")]
    public int CasesConfirmedToDateNM { get; }

    [Name("region.nm.deceased.todate")]
    public int DeceasedToDateNM { get; }

    [Name("region.nm.vaccinated.1st.todate")]
    public int Vaccinated1stToDateNM { get; }

    [Name("region.nm.vaccinated.2nd.todate")]
    public int Vaccinated2ndToDateNM { get; }

    [Name("region.nm.vaccinated.3rd.todate")]
    public int Vaccinated3rdToDateNM { get; }

    [Name("region.po.cases.active")]
    public int CasesActivePO { get; }

    [Name("region.po.cases.confirmed.todate")]
    public int CasesConfirmedToDatePO { get; }

    [Name("region.po.deceased.todate")]
    public int DeceasedToDatePO { get; }

    [Name("region.po.vaccinated.1st.todate")]
    public int Vaccinated1stToDatePO { get; }

    [Name("region.po.vaccinated.2nd.todate")]
    public int Vaccinated2ndToDatePO { get; }

    [Name("region.po.vaccinated.3rd.todate")]
    public int Vaccinated3rdToDatePO { get; }

    [Name("region.sg.cases.active")]
    public int CasesActiveSG { get; }

    [Name("region.sg.cases.confirmed.todate")]
    public int CasesConfirmedToDateSG { get; }

    [Name("region.sg.deceased.todate")]
    public int DeceasedToDateSG { get; }

    [Name("region.sg.vaccinated.1st.todate")]
    public int Vaccinated1stToDateSG { get; }

    [Name("region.sg.vaccinated.2nd.todate")]
    public int Vaccinated2ndToDateSG { get; }

    [Name("region.sg.vaccinated.3rd.todate")]
    public int Vaccinated3rdToDateSG { get; }

    [Name("region.unknown.cases.active")]
    public int CasesActiveUnknown { get; }

    [Name("region.unknown.cases.confirmed.todate")]
    public int CasesConfirmedToDateUnknown { get; }

    [Name("region.unknown.deceased.todate")]
    public int DeceasedToDateUnknown { get; }

    [Name("region.za.cases.active")]
    public int CasesActiveZA { get; }

    [Name("region.za.cases.confirmed.todate")]
    public int CasesConfirmedToDateZA { get; }

    [Name("region.za.deceased.todate")]
    public int DeceasedToDateZA { get; }

    [Name("region.za.vaccinated.1st.todate")]
    public int Vaccinated1stToDateZA { get; }

    [Name("region.za.vaccinated.2nd.todate")]
    public int Vaccinated2ndToDateZA { get; }

    [Name("region.za.vaccinated.3rd.todate")]
    public int Vaccinated3rdToDateZA { get; }
}