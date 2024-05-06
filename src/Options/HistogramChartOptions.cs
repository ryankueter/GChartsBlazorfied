/**
 * Author: Ryan A. Kueter
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 */
using GChartsBlazorfied.Settings;
using GChartsBlazorfied.Models;
namespace GChartsBlazorfied.Options;
public class HistogramChartOptions : IHistogramChartOptions
{
    private HistogramChartSettings _settings = new();
    internal HistogramChartSettings ReturnSettings() => _settings;
    public string? title
    {
        set
        {
            _settings.title = value;
        }
    }
    // Used with the material theme
    public void Chart(Action<gcChart> chart)
    {
        var options = new gcChart();
        if (chart is not null)
            chart(options);
        _settings.chart = options;
    }
    public void Legend(Action<gcLegendOptions> legend)
    {
        var options = new gcLegendOptions();
        if (legend is not null)
            legend(options);
        _settings.legend = options.ReturnSettings();
    }
    public void colors(params string[] colors)
    {
        _settings.colors = colors;
    }
    public void Histogram(Action<gcHistogram> histogram)
    {
        var options = new gcHistogram();
        if (histogram is not null)
            histogram(options);
        _settings.histogram = options;
    }
    public void VAxis(Action<gcAxisOptions> axis)
    {
        var options = new gcAxisOptions();
        if (axis is not null)
            axis(options);
        _settings.vAxis = options.ReturnSettings();
    }
    public bool? interpolateNulls
    {
        set
        {
            _settings.interpolateNulls = value;
        }
    }
    public void Animation(Action<gcAnimation> animation)
    {
        var options = new gcAnimation();
        if (animation is not null)
            animation(options);
        _settings.animation = options;
    }
    public string? axisTitlesPosition
    {
        set
        {
            _settings.axisTitlesPosition = value ?? gcAxisTitlesPositionType.Out;
        }
    }
    public void BackgroundColor(Action<gcBackgroundColor> color)
    {
        var options = new gcBackgroundColor();
        if (color is not null)
            color(options);
        _settings.backgroundColor = options;
    }
    // bar: { groupWidth: '90%' } rotates the tooltip
    public void Bar(Action<gcBar> bar)
    {
        var options = new gcBar();
        if (bar is not null)
            bar(options);
        _settings.bar = options;
    }
    public void ChartArea(Action<gcChartAreaOptions> area)
    {
        var options = new gcChartAreaOptions();
        if (area is not null)
            area(options);
        _settings.chartArea = options.ReturnSettings();
    }
    public double? dataOpacity
    {
        set
        {
            _settings.dataOpacity = value ?? 1;
        }
    }
    public bool? enableInteractivity
    {
        set
        {
            _settings.enableInteractivity = value ?? true;
        }
    }
    // FocusTarget = "category" or "datum" turns on the tooltip for the domain axis
    public string? focusTarget
    {
        set
        {
            _settings.focusTarget = value;
        }
    }
    public double? fontSize
    {
        set
        {
            _settings.fontSize = value;
        }
    }
    public string? fontName
    {
        set
        {
            _settings.fontName = value;
        }
    }
    public bool? forceIFrame
    {
        set
        {
            _settings.forceIFrame = value;
        }
    }
    public void HAxis(Action<gcAxisOptions> axis)
    {
        var options = new gcAxisOptions();
        if (axis is not null)
            axis(options);
        _settings.hAxis = options.ReturnSettings();
    }
    public double? height
    {
        set
        {
            _settings.height = value;
        }
    }
    public string? isStacked
    {
        set
        {
            _settings.isStacked = value;
        }
    }
    public string? orientation
    {
        set
        {
            _settings.orientation = value;
        }
    }
    public bool? reverseCategories
    {
        set
        {
            _settings.reverseCategories = value;
        }
    }
    public void Series(Action<gcFormatters> series)
    {
        var options = new gcFormatters();
        if (series is not null)
            series(options);
        _settings.series = options.GetFormatters();
    }
    public string? theme
    {
        set
        {
            _settings.theme = value;
        }
    }
    public string? titlePosition
    {
        set
        {
            _settings.titlePosition = value ?? gcTitlePositionType.Out;
        }
    }
    public void TitleTextStyle(Action<gcTextStyle> textStyle)
    {
        var options = new gcTextStyle();
        if (textStyle is not null)
            textStyle(options);
        _settings.titleTextStyle = options;
    }
    public void Tooltip(Action<gcTooltipOptions> tooltip)
    {
        var options = new gcTooltipOptions();
        if (tooltip is not null)
            tooltip(options);
        _settings.tooltip = options.ReturnSettings();
    }
    public double? width
    {
        set
        {
            _settings.width = value;
        }
    }
}
