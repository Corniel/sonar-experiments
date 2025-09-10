using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace S1168;

class Compliant
{
	static Bits StructCollection(byte b)
	{
		return b == 0
			? default // Compliant - Bits is a value type
			: new Bits(b);
	}
}


public readonly struct Bits(byte bits) : IReadOnlyCollection<int>
{
	private readonly byte B = bits;

	public int Count => BitOperations.PopCount(B);

	public IEnumerator<int> GetEnumerator()
	{
		var b = B;
		return Enumerable
			.Range(0, 8).Where(i => (b & (1 << i)) == 1)
			.Select(i => 1 << i)
			.GetEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}