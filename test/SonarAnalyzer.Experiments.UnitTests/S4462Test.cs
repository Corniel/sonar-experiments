using NUnit.Framework;
using SonarAnalyzer.Experiments.CSharp;

namespace SonarAnalyzer.Experiments.UnitTests
{
    public class S4462Test
    {
        [Test]
        public void ToString_S4462()
        {
            var obj = new S4462();
            Assert.AreEqual("Result", obj.ToString());
        }
    }
}
