using OutSystems.ExternalLibraries.SDK;

namespace Without.Systems.OpenGraph
{
    [OSInterface(
        Name = "OpenGraph",
        Description = "OpenGraph .NET SDK wrapper for parsing Open Graph metadata of URLs",
        IconResourceName = "Without.Systems.OpenGraph.Resources.OpenGraph.png")]
    public interface IOpenGraph
    {
        [OSAction(
            Description = "Parse Open Graph Metadata from Url",
            ReturnName = "result",
            ReturnType = OSDataType.InferredFromDotNetType,
            IconResourceName = "Without.Systems.OpenGraph.Resources.OpenGraph.png")]
        Metadata ParseOpenGraphUrl(
            [OSParameter(Description = "Url including schema to parse",
                DataType = OSDataType.Text)]
            string url,
            [OSParameter(Description = "Optional User Agent string to send",
                DataType = OSDataType.Text)]
            string userAgent);
    }
}