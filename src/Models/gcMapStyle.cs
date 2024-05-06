namespace GChartsBlazorfied.Models;

public class gcMapStyle
{
    public string? featureType { get; set; }
    public string? elementType { get; set; }
    public List<Dictionary<string, object>>? stylers { get; set; } = new();
}
