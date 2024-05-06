namespace GChartsBlazorfied.Options;
using GChartsBlazorfied.Models;

public class gcMapOptions
{
    private gcMap _settings = new();
    internal gcMap ReturnSettings() => _settings;
    public string? name
    {
        set
        {
            _settings.name = value;
        }
    }
    public void Styles(Action<gcMapStyles> styles)
    {
        var options = new gcMapStyles();
        if (styles is not null)
            styles(options);
        _settings.styles = options.GetStyles();
    }
}
