namespace SonarAnalyzer.Experiments.CSharp
{
    public class S4039 : S4039Double, I4039Int
    {
        public S4039(int value) : base(value) { }

        int I4039Int.Value => (int)Value; // compliant

        bool I4039Int.Add(int val) // compliant
        {
            Add(val);
            return true;
        }
    }

    public class S4039Double
    {
        public S4039Double(double val) => Value = val;

        public double Value { get; private set; }
        public void Add(int val) => Value += val;
    }
    public interface I4039Int
    {
        int Value { get; }
        bool Add(int val);
    }
}
