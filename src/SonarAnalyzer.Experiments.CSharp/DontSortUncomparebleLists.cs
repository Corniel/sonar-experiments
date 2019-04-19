using System;
using System.Collections.Generic;

namespace SonarAnalyzer.Experiments.CSharp
{
    public class DontSortUncomparebleLists
    {
        public DontSortUncomparebleLists()
        {
            var objects = new List<object>();
            objects.Sort(); // noncompliant. object does not implement IComparable<T>
            objects.Sort(Comparer<object>.Default); // compliant. The comparer should no what to do.

            var ints = new List<int>();
            ints.Sort(); // compliant. int implements IComparable<int>
        }

        public static void Sort<T>(List<T> list)
        {
            list.Sort(); // noncompliant. object might not implement IComarable<T>
        }

        public static void Sort2<T>(List<T> list)
            where T : IComparable<T>
        {
            list.Sort(); // compliant. T implements IComparable<T>
        }
    }
}
