namespace SonarAnalyzer.Experiments.CSharp
{
    public static class S3240
    {
        public static int NoConditionalOperator(int value)
        {
            if (value % 2 == 0) // none-compliant. Will lead to nested conditionals.
            {
                return value == 2 ? 1 : 0;
            }
            else
            {
                return 17;
            }
        }
    }
}
