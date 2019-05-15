namespace SonarAnalyzer.Experiments.CSharp
{
public class S2219
{
    public S2219(object arg)
    {
        if(arg == null) // Not-compliant
        {
        }
        if(arg != null) // Not-compliant
        {
        }
        if (arg is null) // Compliant
        {
        }
        if (arg is object) // Compliant
        {
        }
    }
}
}
