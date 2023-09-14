namespace SloCovidTracker.Models.Covid19Sledilnik;
using CsvHelper.Configuration.Attributes;

public class DailyCases
{
    public DailyCases(string date, int casesActiveCe, int casesConfirmedToDateCe, int deceasedToDateCe, int vaccinated1StToDateCe, int vaccinated2NdToDateCe, int vaccinated3RdToDateCe, int casesActiveForeign, int casesConfirmedToDateForeign, int deceasedToDateForeign, int casesActiveKk, int casesConfirmedToDateKk, int deceasedToDateKk, int vaccinated1StToDateKk, int vaccinated2NdToDateKk, int vaccinated3RdToDateKk, int casesActiveKp, int casesConfirmedToDateKp, int deceasedToDateKp, int vaccinated1StToDateKp, int vaccinated2NdToDateKp, int vaccinated3RdToDateKp, int casesActiveKr, int casesConfirmedToDateKr, int deceasedToDateKr, int vaccinated1StToDateKr, int vaccinated2NdToDateKr, int vaccinated3RdToDateKr, int casesActiveLj, int casesConfirmedToDateLj, int deceasedToDateLj, int vaccinated1StToDateLj, int vaccinated2NdToDateLj, int vaccinated3RdToDateLj, int casesActiveMb, int casesConfirmedToDateMb, int deceasedToDateMb, int vaccinated1StToDateMb, int vaccinated2NdToDateMb, int vaccinated3RdToDateMb, int casesActiveMs, int casesConfirmedToDateMs, int deceasedToDateMs, int vaccinated1StToDateMs, int vaccinated2NdToDateMs, int vaccinated3RdToDateMs, int casesActiveNg, int casesConfirmedToDateNg, int deceasedToDateNg, int vaccinated1StToDateNg, int vaccinated2NdToDateNg, int vaccinated3RdToDateNg, int casesActiveNm, int casesConfirmedToDateNm, int deceasedToDateNm, int vaccinated1StToDateNm, int vaccinated2NdToDateNm, int vaccinated3RdToDateNm, int casesActivePo, int casesConfirmedToDatePo, int deceasedToDatePo, int vaccinated1StToDatePo, int vaccinated2NdToDatePo, int vaccinated3RdToDatePo, int casesActiveSg, int casesConfirmedToDateSg, int deceasedToDateSg, int vaccinated1StToDateSg, int vaccinated2NdToDateSg, int vaccinated3RdToDateSg, int casesActiveUnknown, int casesConfirmedToDateUnknown, int deceasedToDateUnknown, int casesActiveZa, int casesConfirmedToDateZa, int deceasedToDateZa, int vaccinated1StToDateZa, int vaccinated2NdToDateZa, int vaccinated3RdToDateZa)
    {
        Date = date;
        CasesActiveCE = casesActiveCe;
        CasesConfirmedToDateCE = casesConfirmedToDateCe;
        DeceasedToDateCE = deceasedToDateCe;
        Vaccinated1stToDateCE = vaccinated1StToDateCe;
        Vaccinated2ndToDateCE = vaccinated2NdToDateCe;
        Vaccinated3rdToDateCE = vaccinated3RdToDateCe;
        CasesActiveForeign = casesActiveForeign;
        CasesConfirmedToDateForeign = casesConfirmedToDateForeign;
        DeceasedToDateForeign = deceasedToDateForeign;
        CasesActiveKK = casesActiveKk;
        CasesConfirmedToDateKK = casesConfirmedToDateKk;
        DeceasedToDateKK = deceasedToDateKk;
        Vaccinated1stToDateKK = vaccinated1StToDateKk;
        Vaccinated2ndToDateKK = vaccinated2NdToDateKk;
        Vaccinated3rdToDateKK = vaccinated3RdToDateKk;
        CasesActiveKP = casesActiveKp;
        CasesConfirmedToDateKP = casesConfirmedToDateKp;
        DeceasedToDateKP = deceasedToDateKp;
        Vaccinated1stToDateKP = vaccinated1StToDateKp;
        Vaccinated2ndToDateKP = vaccinated2NdToDateKp;
        Vaccinated3rdToDateKP = vaccinated3RdToDateKp;
        CasesActiveKR = casesActiveKr;
        CasesConfirmedToDateKR = casesConfirmedToDateKr;
        DeceasedToDateKR = deceasedToDateKr;
        Vaccinated1stToDateKR = vaccinated1StToDateKr;
        Vaccinated2ndToDateKR = vaccinated2NdToDateKr;
        Vaccinated3rdToDateKR = vaccinated3RdToDateKr;
        CasesActiveLJ = casesActiveLj;
        CasesConfirmedToDateLJ = casesConfirmedToDateLj;
        DeceasedToDateLJ = deceasedToDateLj;
        Vaccinated1stToDateLJ = vaccinated1StToDateLj;
        Vaccinated2ndToDateLJ = vaccinated2NdToDateLj;
        Vaccinated3rdToDateLJ = vaccinated3RdToDateLj;
        CasesActiveMB = casesActiveMb;
        CasesConfirmedToDateMB = casesConfirmedToDateMb;
        DeceasedToDateMB = deceasedToDateMb;
        Vaccinated1stToDateMB = vaccinated1StToDateMb;
        Vaccinated2ndToDateMB = vaccinated2NdToDateMb;
        Vaccinated3rdToDateMB = vaccinated3RdToDateMb;
        CasesActiveMS = casesActiveMs;
        CasesConfirmedToDateMS = casesConfirmedToDateMs;
        DeceasedToDateMS = deceasedToDateMs;
        Vaccinated1stToDateMS = vaccinated1StToDateMs;
        Vaccinated2ndToDateMS = vaccinated2NdToDateMs;
        Vaccinated3rdToDateMS = vaccinated3RdToDateMs;
        CasesActiveNG = casesActiveNg;
        CasesConfirmedToDateNG = casesConfirmedToDateNg;
        DeceasedToDateNG = deceasedToDateNg;
        Vaccinated1stToDateNG = vaccinated1StToDateNg;
        Vaccinated2ndToDateNG = vaccinated2NdToDateNg;
        Vaccinated3rdToDateNG = vaccinated3RdToDateNg;
        CasesActiveNM = casesActiveNm;
        CasesConfirmedToDateNM = casesConfirmedToDateNm;
        DeceasedToDateNM = deceasedToDateNm;
        Vaccinated1stToDateNM = vaccinated1StToDateNm;
        Vaccinated2ndToDateNM = vaccinated2NdToDateNm;
        Vaccinated3rdToDateNM = vaccinated3RdToDateNm;
        CasesActivePO = casesActivePo;
        CasesConfirmedToDatePO = casesConfirmedToDatePo;
        DeceasedToDatePO = deceasedToDatePo;
        Vaccinated1stToDatePO = vaccinated1StToDatePo;
        Vaccinated2ndToDatePO = vaccinated2NdToDatePo;
        Vaccinated3rdToDatePO = vaccinated3RdToDatePo;
        CasesActiveSG = casesActiveSg;
        CasesConfirmedToDateSG = casesConfirmedToDateSg;
        DeceasedToDateSG = deceasedToDateSg;
        Vaccinated1stToDateSG = vaccinated1StToDateSg;
        Vaccinated2ndToDateSG = vaccinated2NdToDateSg;
        Vaccinated3rdToDateSG = vaccinated3RdToDateSg;
        CasesActiveUnknown = casesActiveUnknown;
        CasesConfirmedToDateUnknown = casesConfirmedToDateUnknown;
        DeceasedToDateUnknown = deceasedToDateUnknown;
        CasesActiveZA = casesActiveZa;
        CasesConfirmedToDateZA = casesConfirmedToDateZa;
        DeceasedToDateZA = deceasedToDateZa;
        Vaccinated1stToDateZA = vaccinated1StToDateZa;
        Vaccinated2ndToDateZA = vaccinated2NdToDateZa;
        Vaccinated3rdToDateZA = vaccinated3RdToDateZa;
    }

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