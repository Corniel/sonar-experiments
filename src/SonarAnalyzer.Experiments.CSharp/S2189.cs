using System.Collections.Generic;

namespace SonarAnalyzer.Experiments.CSharp
{
    internal static class S2189
    {
        public static void For()
        {
            for (; ; )
            {  // Noncompliant; end condition omitted
               // ...
            }
        }

        public static void While()
        {
            int j = 0;
            while (true)
            { // Noncompliant; end condition omitted
                j++;
            }
        }

        public static void Other()
        { 
            int k = 0;
            bool b = true;
            while (b)
            { // Noncompliant; b never written to in loop
                k++;
            }
        }

        public static IEnumerable<string> Yield()
        {
            while (true)
            {
                yield return "test";
            }
        }
    }
}
