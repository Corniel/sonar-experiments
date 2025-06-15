using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace SonarAnalyzer.Experiments.CSharp;

public static class S2190
{
	public static List<int> Query(this IEnumerable items, bool checkOnhold = true) // FP: calls other method.
	{
		return items.AsQueryable().Query();
	}

	public static List<int> Query(this IQueryable<int> items, bool checkOnhold = true)
	{
		return new List<int>();
	}
}