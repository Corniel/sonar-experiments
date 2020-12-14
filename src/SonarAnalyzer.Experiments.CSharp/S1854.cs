using System.Collections.Generic;

namespace SonarAnalyzer.Experiments.CSharp
{
    public static class S1854
    {
        public static IEnumerable<string> Substrings(string str)
        {
            var start = 1; // compliant - FP
            var end = 134; // compliant - FP
            yield return str[start..];
            yield return str[..end];
        }
    }
}
