using GChartsBlazorfied.Models;

namespace GChartsBlazorfied.Options;

public class gcColorAxisOptions
{
    private gcColorAxis _settings = new();
    internal gcColorAxis ReturnSettings() => _settings;
    public double? minValue
    {
        set
        {
            _settings.minValue = value;
        }
    }
    public double? maxValue
    {
        set
        {
            _settings.maxValue = value;
        }
    }
    public void colors(params string[] colors)
    {
        _settings.colors = colors;
    }
    public void values(params double[] values)
    {
        _settings.values = values;
    }
}
