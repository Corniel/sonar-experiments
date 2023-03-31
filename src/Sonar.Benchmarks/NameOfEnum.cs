using BenchmarkDotNet.Attributes;

namespace Sonar.Benchmarks;

public class NameOfEnum
{
    enum Enumeration { SomeValue };

    [Benchmark(Description = "ToString()")]
    public string WithToString() => $"Prefix:{Enumeration.SomeValue}";

    [Benchmark(Description = "nameof()")]
    public string WithNameOf() => $"Prefix:{nameof(Enumeration.SomeValue)}";
}
