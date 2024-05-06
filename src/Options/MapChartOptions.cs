using GChartsBlazorfied.Settings;
using GChartsBlazorfied.Models;

namespace GChartsBlazorfied.Options;

public class MapChartOptions : IMapChartOptions
{
    private MapSettings _settings = new();
    internal MapSettings ReturnSettings() => _settings;
    public bool showTooltip
    {
        set
        {
            _settings.showTooltip = value;
        }
    }
    public bool showInfoWindow
    {
        set
        {
            _settings.showInfoWindow = value;
        }
    }
    public string? mapType
    {
        set
        {
            _settings.mapType = value ?? gcMapType.hybrid;
        }
    }
    public int? zoomLevel
    {
        set
        {
            _settings.zoomLevel = value;
        }
    }
    public bool UseMapTypeControl
    {
        set
        {
            _settings.useMapTypeControl = value;
        }
    }
    public bool enableScrollWheel
    {
        set
        {
            _settings.enableScrollWheel = value;
        }
    }
    public string? lineColor
    {
        set
        {
            _settings.lineColor = value;
        }
    }
    public int? lineWidth
    {
        set
        {
            _settings.lineWidth = value ?? 10;
        }
    }
    public void mapTypeIds(params string[] ids)
    {
        _settings.mapTypeIds = ids;
    }
    public bool showLine
    {
        set
        {
            _settings.showLine = value;
        }
    }
    public bool useMapTypeControl
    {
        set
        {
            _settings.useMapTypeControl = value;
        }
    }
    public void Icons(Action<gcIcons> icons)
    {
        var options = new gcIcons();
        if (icons is not null)
            icons(options);
        _settings.icons = options.GetFormatters();
    }
    public void Maps(Action<gcMaps> map)
    {
        var options = new gcMaps();
        if (map is not null)
            map(options);
        _settings.maps = options.GetMaps();
    }
}
