using System.Collections.Generic;
using System.Linq;

namespace SonarAnalyzer.Experiments.CSharp
{
    public class S4049_IEnumerable
    {
        public bool IsTrue(IEnumerable<int> numbers)
        {
            return numbers.Count() > 0;
        }

        public IEnumerable<char> GetChars() => "some characters"; // not compliant, defacto a string.

        public IEnumerable<char> GetCharsAsEnumerable() => "some characters".Where(ch => char.IsLetter(ch)); // compliant?!

        public IEnumerable<int> GetNumbers() => new[] { 1, 2 }.Where(n => (n % 2) == 1); // compliant.

        public List<string> GetStrings() => new List<string> { "hello", "world" }; // compliant.

        public List<int> GetNumberList() => GetNumbers().ToList(); // compliant.
    }
}
