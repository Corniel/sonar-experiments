using System.Collections.Generic;

namespace SonarAnalyzer.Experiments.CSharp
{
    public class S4143
    {
        public List<string> Concatenated()
        {
            var list = new List<string>();
            list.Add("SomeText");
            list.Add("\n");
            list.Add("SomeText");
            list.Add("\n");

            return list;
        }
    }
}
