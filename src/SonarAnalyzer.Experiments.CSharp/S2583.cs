using Microsoft.VisualBasic;

namespace SonarAnalyzer.Experiments.CSharp;

public class S2583
{
    public int FalsePositiveOnStringEmpty(string input)
    {
        if(input == null)
        {
            return -1;
        }
        if (string.IsNullOrEmpty(input)) // compliant. String.Empty is different than (string)null.
        {
            return -2;
        }
        return 0;
    }

    public int PlusPlusTakenIntoAccount2(string str)
    {
        for (var index = 0; index < str.Length; index++)
        {
            if (index % 4 == 0) // Compliant.
            {
                return 42;
            }
        }
        return 0;
    }

    public int plusPlusNotTakenIntoAccount2(string str)
    {
        var index = 0;
        while (index++ < str.Length)
        {
            if (index % 4 == 0) // Compliant.
            {
                return 42;
            }
        }
        return 0;
    }

    public int plusPlusNotTakenIntoAccount(string str)
    {
        var index = 0;
        while (index < str.Length)
        {
            index++;
            if (index % 4 == 0) // Compliant.
            {
                return 42;
            }
        }
        return 0;
    }

    public int plusPlusNotTakenIntoAccount()
    {
        var str = "Hello, World";
        var index = 0;
        while (index < str.Length)
        {
            index++;
            if (index % 4 == 0) // Compliant
            {
                return 42;
            }
        }
        return 0;
    }

    public int plusPlusNotTakenIntoAccountConst()
    {
        var str = "42";
        var index = 0;
        while (index < str.Length)
        {
            index++;
            if (index % 4 == 0) // Noncompliant, index will be between 1 and 3.
            {
                return 42;
            }
        }
        return 0;
    }
}
