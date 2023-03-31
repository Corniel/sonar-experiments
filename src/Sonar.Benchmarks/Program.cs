using BenchmarkDotNet.Running;

namespace Sonar.Benchmarks;

internal static class Program
{
    static void Main(string[] args)
    {
        _ = BenchmarkRunner.Run<NameOfEnum>();
    }
}