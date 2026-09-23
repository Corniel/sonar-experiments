using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Diagnostics;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics.Contracts;
using System.Threading;
using System.Threading.Tasks;

public static class S8949
{
	/// <summary>Gets the diagnostics for the specified analyzers.</summary>
	[Pure]
	public static async Task<IReadOnlyCollection<Diagnostic>> GetDiagnosticsAsync(
		Compilation compilation,
		ImmutableArray<DiagnosticAnalyzer> analyzers,
		IEnumerable<AdditionalText> texts,
		CancellationToken cancellationToken = default)
	{
		var options = compilation.Options.WithSpecificDiagnosticOptions([]);
		var analyzerOptions = new AnalyzerOptions([.. texts]);

		var diagnostics = await compilation // FP, cancelation token is passed.
			.WithOptions(options) 
			.WithAnalyzers(analyzers, analyzerOptions)
			.GetAllDiagnosticsAsync(cancellationToken);

		return diagnostics;
	}
}
