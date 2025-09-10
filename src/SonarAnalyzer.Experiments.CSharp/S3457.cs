//using System;
//using System.Diagnostics;
//using System.Linq;
//using System.Reflection;

//namespace SonarAnalyzer.Experiments.CSharp;

//internal class S3457
//{
//	public const string TRACE_FORMAT = "{1:yyyy-MM-dd HH:mm:ss.fff}Z - {2} ({3}) : {4} ({5}) - {6} - {7}";

//	private static string __TraceFormat = TRACE_FORMAT;

//	public static string TraceFormat
//	{
//		get => __TraceFormat;
//		set
//		{
//			if (string.IsNullOrWhiteSpace(value))
//			{
//				value = TRACE_FORMAT;
//			}

//			__TraceFormat = value;
//		}
//	}

//	private void WriteLine(int depth,
//						   TraceEventType traceEventType,
//						   string message,
//						   int id)
//	{
//		try
//		{
//			MethodBase methodBase = null;
//			string fullName = null;

//			traceEventType.TestEnumValueThrowArgumentOutOfRangeException(nameof(traceEventType));

//			message = message ?? "NULL";

//			methodBase = new StackTrace().GetFrame(depth)
//										 .GetMethod();

//			fullName = $"{methodBase.ReflectedType.FullName.Replace("+", ".")}.{methodBase.Name}";

//			_ = this.GetTraceSources(fullName)
//					.Where(ts => ts.Switch
//								   .Level
//								   .HasFlag((SourceLevels)traceEventType))
//					.ForEach(ts => ts.Listeners
//									 .Cast<TraceListener>()
//									 .ToList()
//									 .ForEach(tl => tl.WriteLine(string.Format(__TraceFormat,
//																			   DateTime.Now,
//																			   DateTime.UtcNow,
//																			   ProcessName,
//																			   ProcessId,
//																			   traceEventType,
//																			   id,
//																			   fullName,
//																			   message,
//																			   tl.Name,
//																			   ts.Name))));
//		}
//		catch (Exception exception)
//		{
//			this.WriteException(exception);
//		}
//	}
//}
