using System;

namespace SonarAnalyzer.Experiments.CSharp
{
    public class S4049
    {
        private static readonly Random rnd = new Random();

        [NoProperty]
        public int GetRandom() => rnd.Next(); // compliant, the attribute is not allowed on properties.

        [AttributeUsage(AttributeTargets.All ^ AttributeTargets.Property)]
        private class NoPropertyAttribute : Attribute { }
    }
}
