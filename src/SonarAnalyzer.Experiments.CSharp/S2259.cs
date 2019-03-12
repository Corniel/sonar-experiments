using System;

namespace SonarAnalyzer.Experiments.CSharp
{
    public class S2259
    {
        public ConsoleColor Color { get; set; }

        public void Method1(S2259 obj)
        {
            switch (obj?.Color)
            {
                case null:
                    Console.ForegroundColor = obj.Color; //not compliant
                    break;
                case ConsoleColor.Red:
                    Console.ForegroundColor = obj.Color; //compliant
                    break;
                default:
                    Console.WriteLine($"Color {obj.Color} is not supported."); //compliant
                    break;
            }
        }

        public void Method2(S2259 obj)
        {
            switch (obj?.Color)
            {
                case ConsoleColor.Red:
                    Console.ForegroundColor = obj.Color; //compliant
                    break;
                default:
                    Console.WriteLine($"Color {obj.Color} is not supported."); //not compliant
                    break;
            }
        }
    }
}
