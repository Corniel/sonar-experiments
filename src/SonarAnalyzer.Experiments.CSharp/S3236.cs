using System;
using System.Runtime.CompilerServices;

namespace S3236;

public class MyModel
{
    public MyModel(int? total = null)
    {
		NotNegative(total ?? 0, nameof(total)); // FP: without nameof() "total ?? 0" is provided as paramName.
		Total = total;
    }

	public int? Total { get; init; }

	private static int NotNegative(int parameter, [CallerArgumentExpression(nameof(parameter))] string? paramName = null)
	=> parameter < 0
		? throw new ArgumentOutOfRangeException(paramName, "Value should not be negative.")
		: parameter;
}
