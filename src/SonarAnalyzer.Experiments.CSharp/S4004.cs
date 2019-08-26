using System.Collections.Generic;

namespace SonarAnalyzer.Experiments.CSharp
{
    public class S4004Interface : IS4004
    {
        public IDictionary<object, object> Items { get; set; }// Compliant, enforced by interface
    }
    public interface IS4004
    {
        IDictionary<object, object> Items { get; set; } // non-compliant
    }

    public class S4004Abstract : S4004Base
    {
        public override IDictionary<object, object> Items { get; set; } // Compliant, enforced by base
    }
    public abstract class S4004Base
    {
        public abstract IDictionary<object, object> Items { get; set; } // non-compliant
    }
}
