using System;
using System.Collections.Generic;
using System.Text;

namespace SonarAnalyzer.Experiments.CSharp
{
public class S3717
{
    public void NotImplemented() => throw new NotImplementedException(); // not-compliant

    public void NotImplementedInline()
    {
        throw new NotImplementedException(); // not
    }
}
}
