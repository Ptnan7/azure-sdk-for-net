// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;

namespace Azure.AI.OpenAI
{
    internal static partial class PipelineRequestHeadersExtensions
    {
        public static void SetDelimited<T>(this PipelineRequestHeaders headers, string name, IEnumerable<T> value, string delimiter)
        {
            IEnumerable<string> stringValues = value.Select(v => TypeFormatters.ConvertToString(v));
            headers.Set(name, string.Join(delimiter, stringValues));
        }

        public static void SetDelimited<T>(this PipelineRequestHeaders headers, string name, IEnumerable<T> value, string delimiter, string format)
        {
            IEnumerable<string> stringValues = value.Select(v => TypeFormatters.ConvertToString(v, format));
            headers.Set(name, string.Join(delimiter, stringValues));
        }
    }
}
