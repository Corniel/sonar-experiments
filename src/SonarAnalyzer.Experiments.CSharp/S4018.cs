using System;

namespace SonarAnalyzer.Experiments.CSharp
{
    public static class S4018
    {
        public static T MyCast<T>(object obj) // compliant
        {
            return (T)obj;
        }

        public static T ObjectIs<T>(object obj) // compliant
        {
            if (obj is T casted)
            {
                return casted;
            }
            throw new InvalidOperationException();
        }

        public static T MyDefault<T>() // compliant
        {
            return default;
        }
    }
}
