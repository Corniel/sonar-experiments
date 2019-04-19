using System;

namespace SonarAnalyzer.Experiments.CSharp
{
[Flags]
public enum CharBasedEnumsShouldNotBeDecoratedWithFlags // noncompliant
{
    A = 'A',
    B = 'B',
    C = 'C',
    ABC = A | B | C,
}
}
