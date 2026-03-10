using System;

namespace DefineNotNullConstraints;

public class All<T> where T : class
{
	public bool Check(T? value)
	{
		if (value is { })
		{
			value = Class.Chain(value);
		}
		return value is not null;
	}
}

public static class  Class 
{
	public static T Chain<T>(T cls) where T : notnull 
		=> cls ?? throw new ArgumentNullException(nameof(cls));
}

class NonCompliant
{
	public void ThrowArgumentNull<TModel>(TModel obj) // Noncompliant {{TModel can be constrained to 'notnull'}}
	//                            ^^^^^^
	{
		obj = obj ?? throw new ArgumentNullException(nameof(obj));
	}

	public void ThrowIfNull<T>(T obj) // Noncompliant
	{
		ArgumentNullException.ThrowIfNull(obj);
	}

	public void GuardClass<T>(T obj) // Noncompliant
	{
		DefineNotNullConstraints.Guard.NotNull(obj);
	}

	public void GuardMethod<T>(T obj) // Noncompliant
	{
		Guard(obj);
	}	

	private T Guard<T>(T? obj) => obj ?? throw new ArgumentNullException();
}

class Compliant
{
	public void Nullable<T>(T? obj) // Compliant
	{
		obj = obj ?? throw new ArgumentNullException(nameof(obj));
	}

	public void Class<T>(T obj) where T : class // Compliant
	{
		obj = obj ?? throw new ArgumentNullException(nameof(obj));
	}

	public void NotNull<T>(T obj) where T : notnull // Compliant
	{
		obj = obj ?? throw new ArgumentNullException(nameof(obj));
	}

	public void Multiple<T>(T required, T? opti0nal) // Complaint
	{
		required = required ?? throw new ArgumentNullException(nameof(required));
	}
}

static class Guard
{
	public static T NotNull<T>(T? obj) => obj ?? throw new ArgumentNullException();
}
