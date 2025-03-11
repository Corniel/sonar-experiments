namespace SonarAnalyzer.Experiments.CSharp.S1905;

class Noncompliant
{
	public void UseSuffixForLiterals()
	{
		var d0 = (decimal)12.0; // Noncompliant, use 12.0m
		var d1 = (decimal)12; // Noncompliant, use 12m
		var d2 = (double)12; // Noncompliant, use 12d
		var f0 = (float)12.0; // Noncompliant, use 12.0f
		var n0 = (uint)12; // Noncompliant, use 12u
		var n1 = (long)12; // Noncompliant, use 12l
		var n2 = (ulong)12; // Noncompliant, use 12ul
	}
}
