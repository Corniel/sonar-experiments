 namespace S0927;

public interface IFace
{
	void Foo(string fooString);
	void Foo(System.Text.RegularExpressions.Regex fooRegex);
}

public class MyImpl : IFace
{
	public void Foo(string barString) // NONCOMPLIANT with S927
	{
		// [...]
	}

	public void Foo(System.Text.RegularExpressions.Regex barRegex) // NONCOMPLIANT with S927
	{
		// [...]
	}
}