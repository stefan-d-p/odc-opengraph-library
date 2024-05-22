using Without.Systems.OpenGraph.Util;

namespace Without.Systems.OpenGraph;

public class OpenGraph : IOpenGraph
{
    public string Echo(string message)
    {
        return message;
    }

    /// <summary>
    /// Parses Open Graph Metadata from a given Url
    /// </summary>
    /// <param name="url">The url to parse</param>
    /// <param name="userAgent">Optional User Agent string to send</param>
    /// <returns>Basic OpenGraph Metadata</returns>
    /// <exception cref="ArgumentException"></exception>
    public Metadata ParseOpenGraphUrl(string url, string userAgent = "")
    {
        if (!Uri.IsWellFormedUriString(url, UriKind.Absolute)) throw new ArgumentException($"Invalid url of {url}");
        
        OpenGraphNet.OpenGraph openGraph = AsyncUtil.RunSync(() => OpenGraphNet.OpenGraph.ParseUrlAsync(url,userAgent));
        return new Metadata
        {
            Title = openGraph.Title,
            Description = openGraph.Metadata["og:description"].FirstOrDefault()?.Value,
            Image = openGraph.Metadata["og:image"].FirstOrDefault()?.Value,
            Url = openGraph.Url?.AbsoluteUri,
            Type = openGraph.Type
        };

    }
}