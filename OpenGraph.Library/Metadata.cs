using OutSystems.ExternalLibraries.SDK;

namespace Without.Systems.OpenGraph;

[OSStructure(Description = "Open Graph Metadata")]
public struct Metadata
{
    [OSStructureField(Description = "The title of the object",
        DataType = OSDataType.Text)]
    public string? Title;
    
    [OSStructureField(Description = "The type of the object",
        DataType = OSDataType.Text)]
    public string? Type;
    
    [OSStructureField(Description = "The URL of the object",
        DataType = OSDataType.Text)]
    public string? Url;
    
    [OSStructureField(Description = "The image url of the object",
        DataType = OSDataType.Text)]
    public string? Image;
    
    [OSStructureField(Description = "The description of the object",
        DataType = OSDataType.Text)]
    public string? Description;
    
}