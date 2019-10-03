using System;
using System.Collections.Generic;
using System.Linq;

namespace SonarAnalyzer.Experiments.CSharp
{
public static class S3900
{
    public static void Extension(List<string> list)
    {
        if (list.IsNotNullOrEmpty())
        {
            foreach (string item in list) // Compliant
            {
                // Do something
            }
        }
    }

    public static void Method(List<string> list)
    {
        if (HasAny(list))
        {
            foreach (string item in list) // Compliant
            {
                // Do something
            }
        }
    }

    private static bool HasAny<T>([ValidatedNotNull]IEnumerable<T> src)
    {
        if (src is null)
        {
            return false;
        }
        return src.Any();
    }
}
public static class S3900Exentsions
{
    public static bool IsNotNullOrEmpty<T>([ValidatedNotNull]this IEnumerable<T> src)
    {
        if (src is null)
        {
            return false;
        }
        return src.Any();
    }
}

[AttributeUsage(AttributeTargets.Parameter)]
public sealed class ValidatedNotNullAttribute : Attribute { }
}
