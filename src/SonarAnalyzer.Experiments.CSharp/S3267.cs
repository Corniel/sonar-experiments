using System;
using System.Collections;
using System.Collections.Generic;

namespace SonarAnalyzer.Experiments.CSharp
{
    static class S3267
    {
        public static void IterateNonGeneric(NonGeneric items)
        {
            foreach (Item item in items)
            {
                if (item.Value > 66) Console.WriteLine(item.Value);
            }
        }
        public static void IterateGeneric(IEnumerable<Item> items)
        {
            foreach (Item item in items)
            {
                if (item.Value > 66) Console.WriteLine(item.Value);
            }
        }
    }
    public class Item
    {
        public int Value { get; set; }
    }

    public class NonGeneric : IEnumerable
    {
        public IEnumerator GetEnumerator() => Array.Empty<object>().GetEnumerator();
    }
}
