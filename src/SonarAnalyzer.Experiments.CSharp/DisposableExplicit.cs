using System;

namespace SonarAnalyzer.Experiments.CSharp
{
    public class DisposableExplicit : IDisposable // Should not raise S3881
    {
        void IDisposable.Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>Disposes the API test context.</summary>
        protected virtual void Dispose(bool disposing) // Should not raise S2953
        {
            if (!isDisposed && disposing)
            {
                // dispose something.
            }
            isDisposed = true;
        }
        private bool isDisposed;
    }
}
