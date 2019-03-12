using System;

namespace SonarAnalyzer.Experiments.CSharp
{
    public class S3881 : IDisposable
    {
        public S3881(IDisposable prop) => Property = prop;

        public IDisposable Property { get; }

        public void Dispose() => Dispose(true);

        protected virtual void Dispose(bool disposing)
        {
            if (!isDisposed)
            {
                if (disposing)
                {
                    Property.Dispose();
                }
                isDisposed = true;
            }
        }
        private bool isDisposed;
    }
}
