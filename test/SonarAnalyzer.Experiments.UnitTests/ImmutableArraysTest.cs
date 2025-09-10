using NUnit.Framework;
using ImmutableArrays;
using System;
using AwesomeAssertions;
using System.Linq;

namespace SonarAnalyzer.Experiments.UnitTests;

public class ImmutableArraysTest
{
	[Test]
	public void Gaaf()
	{
		var sut = new NonCompliant();

		sut.Invoking(s => s.Default.ToArray()).Should().Throw<NullReferenceException>();

		sut.Invoking(s => s.Default_T.ToArray()).Should().Throw<NullReferenceException>();

		sut.Invoking(s => s.Init.ToArray()).Should().Throw<NullReferenceException>();
	}
}
