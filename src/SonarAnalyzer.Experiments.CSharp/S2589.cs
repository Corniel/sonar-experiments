using System.Collections.Generic;

namespace SonarAnalyzer.Experiments.CSharp
{
    public class S2589
    {
        public bool ListContainsAtLeastOnePositiveAndNoNegatives(List<int> list)
        {
            bool containspositive = false;
            bool containsnegative = false;

            foreach (int value in list)
            {
                if (value > 0)
                {
                    containspositive = true;
                }
                else if (value < 0)
                {
                    containsnegative = true;
                }
            }

            return containspositive && !containsnegative;
        }
    }
}
