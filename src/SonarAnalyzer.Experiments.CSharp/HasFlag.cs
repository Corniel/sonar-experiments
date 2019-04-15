using System;

namespace SonarAnalyzer.Experiments.CSharp
{
public class HasFlag
{
    [Flags]
    public enum Flagged
    {
        None = 0,
        UnionJack = 1,
        StarSpangledBanner = 2,
    }

    public void Test(Flagged flags, LoaderOptimization optimization)
    {
        var noFlag = optimization.HasFlag(LoaderOptimization.MultiDomain); // none-compliant. LoaderOptimization is not a flags enum.
        var hasNone = flags.HasFlag(Flagged.None); //none-compliant, None is not a flag value.
        var hasOther = flags.HasFlag(LoaderOptimization.SingleDomain); // not-compliant, enum types don't match
        var hasUS = flags.HasFlag(Flagged.StarSpangledBanner); // compliant
    }
}
}
