namespace Without.Systems.OpenGraph.Test;

public class Tests
{
    private static readonly IOpenGraph _actions = new OpenGraph();

    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Echo_Returns_Successful()
    {

        var result = _actions.ParseOpenGraphUrl("https://www.tbs.tech", "LopemIpsum/jdhskjds");
        
    }
}