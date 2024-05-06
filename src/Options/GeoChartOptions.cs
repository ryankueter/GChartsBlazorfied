using GChartsBlazorfied.Settings;
using GChartsBlazorfied.Models;

namespace GChartsBlazorfied.Options;

public class GeoChartOptions : IGeoChartOptions
{
    private GeoChartSettings _settings = new();
    internal GeoChartSettings ReturnSettings() => _settings;

    public double? width
    {
        set
        {
            _settings.width = value;
        }
    }
    public double? height
    {
        set
        {
            _settings.height = value;
        }
    }
    // region: '002', // Africa
    public string? region
    {
        set
        {
            _settings.region = value ?? "world";
        }
    }
    public string? domain
    {
        set
        {
            _settings.domain = value;
        }
    }
    public bool? enableRegionInteractivity
    {
        set
        {
            _settings.enableRegionInteractivity = value ?? true;
        }
    }
    public bool? forceIFrame
    {
        set
        {
            _settings.forceIFrame = value;
        }
    }
    public string? displayMode
    {
        set
        {
            _settings.displayMode = value;
        }
    }
    public string? datalessRegionColor
    {
        set
        {
            _settings.datalessRegionColor = value;
        }
    }
    public string? defaultColor
    {
        set
        {
            _settings.defaultColor = value;
        }
    }
    public string? resolution
    {
        set
        {
            _settings.resolution = value ?? "countries";
        }
    }
    public double? regioncoderVersion
    {
        set
        {
            _settings.regioncoderVersion = value ?? 0;
        }
    }
    public double? markerOpacity
    {
        set
        {
            _settings.markerOpacity = value ?? 1.0;
        }
    }
    public bool? keepAspectRatio
    {
        set
        {
            _settings.keepAspectRatio = value ?? true;
        }
    }
    public double? geochartVersion
    {
        set
        {
            _settings.geochartVersion = value ?? 10;
        }
    }
    public void BackgroundColor(Action<gcBackgroundColor> color)
    {
        var options = new gcBackgroundColor();
        if (color is not null)
            color(options);
        _settings.backgroundColor = options;
    }
    public void Tooltip(Action<gcTooltipOptions> tooltip)
    {
        var options = new gcTooltipOptions();
        if (tooltip is not null)
            tooltip(options);
        _settings.tooltip = options.ReturnSettings();
    }
    public void Legend(Action<gcLegendOptions> legend)
    {
        var options = new gcLegendOptions();
        if (legend is not null)
            legend(options);
        _settings.legend = options.ReturnSettings();
    }
    public void MagnifyingGlass(Action<gcMagnifyingGlass> magnifyingGlass)
    {
        var options = new gcMagnifyingGlass();
        if (magnifyingGlass is not null)
            magnifyingGlass(options);
        _settings.magnifyingGlass = options;
    }
    public void ColorAxis(Action<gcColorAxisOptions> colorAxis)
    {
        var options = new gcColorAxisOptions();
        if (colorAxis is not null)
            colorAxis(options);
        _settings.colorAxis = options.ReturnSettings();
    }
    public void SizAxis(Action<gcSizAxis> sizeAxis)
    {
        var options = new gcSizAxis();
        if (sizeAxis is not null)
            sizeAxis(options);
        _settings.sizeAxis = options;
    }
}
