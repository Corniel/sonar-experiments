using System;
using System.Collections.Generic;
using System.Linq;

namespace S1172;

public class Compliant
{
	public static IEnumerable<(int, int)> Pairs()
	{
		return Enumerable.Range(0, 1).Select(i => PrivatePair(i, i * i));
	}

	private static (int, int) PrivatePair(int l, int r) => (l, r); // compliant FP
	
	public static (int, int) PublicPair(int l, int r) => (l, r); // compliant

	private static long InlineUsage(int value) // FP, value is used by the inline function.
	{
		return Inline();

		int Inline()
		{
			return Random.Shared.Next() > 10 ? value : 42;
		}
	}
}
