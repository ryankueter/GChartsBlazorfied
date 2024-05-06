using GChartsBlazorfied.Models;

namespace GChartsBlazorfied.Settings;

public class GeoChartSettings
{
    public gcTooltip? tooltip {get;set;}
    public double? width { get; set; }
    public double? height { get; set; }
    // region: '002', // Africa
    public string? region { get; set; } = "world";
    public string? domain { get; set; }
    public bool? enableRegionInteractivity { get; set; }
    public bool? forceIFrame { get; set; }
    public string? displayMode { get; set; }
    public gcBackgroundColor? backgroundColor { get; set; }
    public string? datalessRegionColor { get; set; }
    public string? defaultColor { get; set; }
    public string? resolution { get; set; } = "countries";
    public double? regioncoderVersion { get; set; } = 0;
    public double? markerOpacity { get; set; } = 1.0;
    public bool? keepAspectRatio { get; set; } = true;
    public double? geochartVersion { get; set; } = 10;
    public gcLegend? legend { get; set; }
    public gcMagnifyingGlass? magnifyingGlass { get; set; }
    public gcColorAxis? colorAxis { get; set; }
    public gcSizAxis? sizeAxis { get; set; }
}