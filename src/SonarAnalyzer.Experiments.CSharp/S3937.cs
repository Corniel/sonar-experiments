namespace SonarAnalyzer.Experiments.CSharp
{
public static class S3937
{
    public static readonly long Hexa2 = 0xFF_FF_FF_FF; // compliant
    public static readonly long Hexa3 = 0x121_1F3_456; // non-compliant, hexadecimals should have groups of 2 or 4 
    public static readonly long Hexa4 = 0xF_FFFF_FFFF; // compliant

    public static readonly long Bin2 = 0b1_10_11_10_11; // compliant
    public static readonly long Bin3 = 0b0_111_111_111; // non-compliant, binaries should have groups of 2 or 4 
    public static readonly long Bin4 = 0b111_1101_1011; // compliant
}
}
