using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SonarAnalyzer.Experiments.CSharp
{
    public class ConditionEvaluatesToConstantThrows
    {
        public ConditionEvaluatesToConstantThrows(object header, object body)
        {
            Header = header;
            Body = body;
        }

        public object Header { get; }

        public object Body { get; }


        public static async Task<ConditionEvaluatesToConstantThrows> LoadAsync(Stream stream, Type headerType, Type bodyType)
        {
            var root = await XElement.LoadAsync(stream, LoadOptions.None, default);

            var header = root.Element(root.Name.Namespace + nameof(Header))?
                .Elements()
                .FirstOrDefault()
                .Deserialize(headerType);

            var body = root.Element(root.Name.Namespace + nameof(Body))?
                .Elements()
                .FirstOrDefault()
                .Deserialize(bodyType);

            return new ConditionEvaluatesToConstantThrows(header, body);
        }
    }

    public static class SoapMessageExtensions
    {
        public static object Deserialize(this XNode node, Type type)
        {
            return new object();
        }
    }
}
