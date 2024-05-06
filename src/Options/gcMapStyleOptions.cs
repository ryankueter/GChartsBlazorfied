using GChartsBlazorfied.Models;

namespace GChartsBlazorfied.Options;

public class gcMapStyleOptions
{
    private gcMapStyle _settings = new();
    internal gcMapStyle ReturnSettings() => _settings;
    public string? featureType
    {
        set
        {
            _settings.featureType = value;
        }
    }
    public string? elementType
    {
        set
        {
            _settings.elementType = value;
        }
    }
    public void AddStyler(string gcStyler, object style)
    {
        _settings.stylers!.Add(new Dictionary<string, object>
        {
            { gcStyler, style }
        });
    }
}
