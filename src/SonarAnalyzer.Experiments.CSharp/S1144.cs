using System.Diagnostics;
using System.Text.RegularExpressions;

public class Applicable
{
	public int Value(int value) => new Durs(value)[3];

	[DebuggerDisplay("{this[0]}, {this[1]}, {this[2]}, {this[3]}, {this[4]}")]
	readonly record struct Durs(int Value)
	{
		public int this[int pos] => (Value >> (pos << 2)) & 7; // FP: Called by both Value as DebuggerDisplay.
	}
}

namespace SonarAnalyzer.Experiments.CSharp
{
    public class S1144
    {
        public void M()
        {
            OtherClass oc = new OtherClass();
            (oc.Name, oc.Type) = ("A", "B");
        }

        class OtherClass
        {
            public string Name { get; set; } // Compliant, usage via a TupleExpression should be recognized.
            public string Type { get; set; } // Compliant, usage via a TupleExpression should be recognized.
        }
    }

	internal class LogConverter
	{
		private LogConverter(string regex, string alertType)
		{
			_regex = new Regex(regex);
			AlertType = alertType;
		}

		public string AlertType { get; }
		private readonly Regex _regex;

		public bool IsMatch(string message)
		{
			return _regex.IsMatch(message);
		}

		public static readonly LogConverter[] Converters =
		[
			new("^AGV route completed", "0xAAFF0001"),
			new("^AGV route failed during execution", "0xAAFF0002"),
		];
	}
}
