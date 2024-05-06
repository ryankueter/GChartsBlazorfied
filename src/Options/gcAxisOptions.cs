/**
 * Author: Ryan A. Kueter
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 */
using System.ComponentModel.DataAnnotations;

using GChartsBlazorfied.Models;

namespace GChartsBlazorfied.Options;

public class gcAxisOptions
{
    private gcAxis _settings = new();
    public string? title
    {
        set
        {
            _settings.title = value;
        }
    }
    public void TitleTextStyle(Action<gcTextStyle> style)
    {
        var options = new gcTextStyle();
        if (style is not null)
            style(options);
        _settings.titleTextStyle = options;
    }
    public void TextStyle(Action<gcTextStyle> style)
    {
        var options = new gcTextStyle();
        if (style is not null)
            style(options);
        _settings.textStyle = options;
    }
    public int minValue
    {
        set
        {
            _settings.minValue = value;
        }
    }
    public int maxValue
    {
        set
        {
            _settings.maxValue = value;
        }
    }

    public string? format
    {
        set
        {
            _settings.format = value;
        }
    }
    public int direction
    {
        set
        {
            _settings.direction = value;
        }
    }
    public bool slantedText
    {
        set
        {
            _settings.slantedText = value;
        }
    }
    [Range(-90, 90)]
    public int slantedTextAngle
    {
        set
        {
            _settings.slantedTextAngle = value;
        }
    }

    public double? baseline
    {
        set
        {
            _settings.baseline = value;
        }
    }
    public string? baselineColor
    {
        set
        {
            _settings.baselineColor = value;
        }
    }    
    public void ViewWindow(Action<gcViewWindow> window)
    {
        var options = new gcViewWindow();
        if (window is not null)
            window(options);
        this._settings.viewWindow = options;
    }
    public void Gridlines(Action<gcGridlinesOptions> lines)
    {
        var options = new gcGridlinesOptions();
        if (lines is not null)
            lines(options);
        this._settings.gridlines = options.ReturnSettings();
    }
    public void MinorGridlines(Action<gcMinorGridlinesOptions> lines)
    {
        var options = new gcMinorGridlinesOptions();
        if (lines is not null)
            lines(options);
        this._settings.minorGridlines = options.ReturnSettings();
    }
    public bool logScale
    {
        set
        {
            _settings.logScale = value;
        }
    }
    public string? scaleType
    {
        set
        {
            _settings.scaleType = value;
        }
    }
    public string? textPosition
    {
        set
        {
            _settings.textPosition = value;
        }
    }
    public List<object>? ticks
    {
        set
        {
            _settings.ticks = value;
        }
    }
    public bool allowContainerBoundaryTextCutoff
    {
        set
        {
            _settings.allowContainerBoundaryTextCutoff = value;
        }
    }
    public double? maxAlternation
    {
        set
        {
            _settings.maxAlternation = value;
        }
    }
    public double? maxTextLines
    {
        set
        {
            _settings.maxTextLines = value;
        }
    }
    public double? minTextSpacing
    {
        set
        {
            _settings.minTextSpacing = value;
        }
    }
    public double? showTextEvery
    {
        set
        {
            _settings.showTextEvery = value;
        }
    }
    public string? viewWindowMode
    {
        set
        {
            _settings.viewWindowMode = value;
        }
    }

    internal gcAxis ReturnSettings() => _settings;
}
