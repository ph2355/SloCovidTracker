namespace SloCovidTracker.Models;

public static class Regions
{
    public static readonly string LJ = "LJ";
    public static readonly string CE = "CE";
    public static readonly string KR = "KR";
    public static readonly string NM = "NM";
    public static readonly string KK = "KK";
    public static readonly string KP = "KP";
    public static readonly string MB = "MB";
    public static readonly string MS = "MS";
    public static readonly string NG = "NG";
    public static readonly string PO = "PO";
    public static readonly string SG = "SG";
    public static readonly string ZA = "ZA";

    public static bool IsValid(string region)
    {
        return region.Equals(LJ)
               || region.Equals(CE)
               || region.Equals(KR)
               || region.Equals(NM)
               || region.Equals(KK)
               || region.Equals(KP)
               || region.Equals(MB)
               || region.Equals(MS)
               || region.Equals(NG)
               || region.Equals(PO)
               || region.Equals(SG)
               || region.Equals(ZA);
    }
}