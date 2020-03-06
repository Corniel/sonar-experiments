using System.Collections.Generic;

namespace SonarAnalyzer.Experiments.CSharp
{
public struct S3263
{
    public static readonly S3263 Zero;
    public static readonly S3263 V42 = new S3263(42);

    public static readonly IReadOnlyCollection<S3263> All = new[] { Zero, V42, }; // compliant, both values have been initialized.

    public static readonly IReadOnlyCollection<S3263> Extra = new[] { Zero, V007, V42, }; // noncompliant, V007 has not been initalized.

    public static readonly S3263 V007 = new S3263(7);

    public S3263(int i) => Value = i;

    public int Value { get; }
}
}
