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
}
