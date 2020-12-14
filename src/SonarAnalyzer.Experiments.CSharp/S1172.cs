using System.Collections.Generic;
using System.Linq;

namespace SonarAnalyzer.Experiments.CSharp
{
    public static class S1172
    {
        public static IEnumerable<(int, int)> Pairs()
        {
            return Enumerable.Range(0, 1).Select(i => PrivatePair(i, i * i));
        }

        private static (int, int) PrivatePair(int l, int r) => (l, r); // compliant FP
        public static (int, int) PublicPair(int l, int r) => (l, r); // compliant
    }
}
