using System;
using System.Collections.Generic;
using System.Text;

namespace SonarAnalyzer.Experiments.CSharp
{
    public class S3874 : I3874
    {
        public void Set(ref S3874 obj) // compliant
        {
            obj = new S3874();
        }
    }

    public interface I3874
    {
        void Set(ref S3874 obj); // non-compliant
    }
}
