using NUnit.Framework;
using SonarAnalyzer.Experiments.CSharp;
using System.Linq;

namespace SonarAnalyzer.Experiments.UnitTests
{
    public class S3263Test
    {
        [Test]
        public void Init()
        {
            var all = S3263.All.ToArray();

            Assert.AreEqual("0, 42", string.Join(", ", all.Select(s => s.Value)));

        }
    }
}
