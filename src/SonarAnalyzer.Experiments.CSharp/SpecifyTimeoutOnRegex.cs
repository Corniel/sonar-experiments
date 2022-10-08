using System.ComponentModel.DataAnnotations;

namespace SonarAnalyzer.Experiments.CSharp;

internal class SpecifyTimeoutOnRegex
{

    [RegularExpression("[a-h][1-8]")]
    public string Property { get; set; }
}
