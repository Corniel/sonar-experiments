using System.Collections.Immutable;

namespace ImmutableArrays;

public class NonCompliant
{
	public ImmutableArray<int> Init { get; init; } // Noncompliant

	public ImmutableArray<int> Default { get; set; } = default; // Noncompliant

	public ImmutableArray<int> Default_T { get; set; } = default(ImmutableArray<int>); // Noncompliant
}

public class Compliant
{
	public Compliant(ImmutableArray<int> ctor)
	{
		Ctor = ctor;
	}

	public ImmutableArray<int> Ctor { get; }

	public ImmutableArray<int> Initialized { get; init; } = [];

	public ImmutableArray<int> Empty { get; init; } = ImmutableArray<int>.Empty;

	public required ImmutableArray<int> Required { get; init; }
}

public class CompliantWitDefaultConstructor(ImmutableArray<int> defaultCtor)
{
	public ImmutableArray<int> DefaultCtor { get; } = defaultCtor;

	public ImmutableArray<int> Initialized { get; init; } = [];

	public ImmutableArray<int> Empty { get; init; } = ImmutableArray<int>.Empty;

	public required ImmutableArray<int> Required { get; init; }
}