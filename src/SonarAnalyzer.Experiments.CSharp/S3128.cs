using System;

namespace S3125;

public class Implementation
{
	public static readonly object Do = new();

	private sealed class Nil : IContract
	{
		public void Do() => throw new NotSupportedException();
	}
}

public interface IContract
{
	void Do();
}