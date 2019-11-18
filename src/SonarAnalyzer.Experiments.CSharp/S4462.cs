using System;
using System.Threading;
using System.Threading.Tasks;

namespace SonarAnalyzer.Experiments.CSharp
{
    public class S4462
    {
        public Task<S4462> Run(Func<Task<S4462>> continuation, CancellationToken token)
        {
            return continuation().ContinueWith((action) =>
            {
                return action.Result; // Compliant, ContinueWith() enforces to do so.
        });
        }

        public override string ToString()
        {
            return nameof(Task<object>.Result); // Compliant, nameof() does not execute asyn code.
        }
    }
}
