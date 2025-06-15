using NUnit.Framework;
using AwesomeAssertions;

namespace SonarAnalyzer.Experiments.UnitTests;

public class S4158Test
{
	[Test]
	public void Not_empty()
	{
		var x = S4158.Repro(["a", "b", "c"]);
		x.Should().HaveCount(3);
	}
}
