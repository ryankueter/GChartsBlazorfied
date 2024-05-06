using GChartsBlazorfied.Models;
namespace GChartsBlazorfied.Settings;

public class MapChartSettings
{
    public string? mapType { get; set; } = gcMapType.hybrid;
    public double? zoomLevel { get; set; }
    public bool? showTooltip { get; set; }
    public bool? showInfoWindow { get; set; }
    public bool? enableScrollWheel { get; set; }
    public string? lineColor { get; set; }
    public double? lineWidth { get; set; } = 10;
    public string[]? mapTypeIds { get; set; }
    public bool? showLine { get; set; }
    public bool? useMapTypeControl { get; set; }
    public gcIcon[]? icons { get; set; }
    public Dictionary<string, gcMap>? maps { get; set; }
}