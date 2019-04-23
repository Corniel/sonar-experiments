namespace SonarAnalyzer.Experiments.CSharp
{
    public class S2583
    {
        public int FalsePositiveOnStringEmpty(string input)
        {
            if(input == null)
            {
                return -1;
            }
            if (string.IsNullOrEmpty(input)) // compliant. String.Empty is different than (string)null.
            {
                return -2;
            }
            return 0;
        }
    }
}
