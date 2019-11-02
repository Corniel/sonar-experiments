using System;
using System.Collections.Generic;

namespace SonarAnalyzer.Experiments.CSharp
{
    [Serializable]
    public class S4004Serializable
    {
        public List<int> Values { get; set; } // Compliant, [Serializable] requires a public setter.
    }
}
