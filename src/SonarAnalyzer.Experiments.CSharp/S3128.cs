using System;

namespace S3125;

public class Container
{
	public static readonly object Do = new();

	public static readonly object Other = new();

	private sealed class PrivateImplementation : Base, IContract
	{
		public void Do() { } // Compliant, enforced by the interface

		public override void Other() { } // Compliant, enforced by the interface
	}
}

public interface IContract
{
	void Do();
}

public abstract class Base
{
	public abstract void Other();
}