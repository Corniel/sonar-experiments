using System;
using System.Collections.Generic;

public static class S4158
{
	public static HashSet<string> Repro(string[] args)
	{
		var set = new HashSet<string>();

		foreach (var arg in args)
		{
			var target = set;

			if (target.Contains(arg)) // S4158
			{
				throw new ArgumentException("duplicate");
			}

			target.Add(arg);
		}

		return set;
	}
}