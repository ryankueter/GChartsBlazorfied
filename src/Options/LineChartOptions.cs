/**
 * Author: Ryan A. Kueter
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 */
using GChartsBlazorfied.Settings;
using GChartsBlazorfied.Models;
namespace GChartsBlazorfied.Options;

public class LineChartOptions : ILineChartOptions
{
    private LineChartSettings _settings = new();
    internal LineChartSettings ReturnSettings() => _settings;
    public string? title
    {
        set
        {
            _settings.title = value;
        }
    }
    public string? curveType
    {
        set
        {
            _settings.curveType = value;
        }
    }
    public void Legend(Action<gcLegendOptions> legend)
    {
        var options = new gcLegendOptions();
        if (legend is not null)
            legend(options);
        _settings.legend = options.ReturnSettings();
    }
    public void HAxis(Action<gcAxisOptions> axis)
    {
        var options = new gcAxisOptions();
        if (axis is not null)
            axis(options);
        _settings.hAxis = options.ReturnSettings();
    }

    public void VAxis(Action<gcAxisOptions> axis)
    {
        var options = new gcAxisOptions();
        if (axis is not null)
            axis(options);
        _settings.vAxis = options.ReturnSettings();
    }
    public int? pointSize
    {
        set
        {
            _settings.pointSize = value;
        }
    }
    public int? lineWidth
    {
        set
        {
            _settings.lineWidth = value;
        }
    }
    public void Annotations(Action<gcAnnotationsOptions> annotations)
    {
        var options = new gcAnnotationsOptions();
        if (annotations is not null)
            annotations(options);
        _settings.annotations = options.ReturnSettings();
    }
    public void Crosshair(Action<gcCrosshairOptions> crosshair)
    {
        var options = new gcCrosshairOptions();
        if (crosshair is not null)
            crosshair(options);
        _settings.crosshair = options.ReturnSettings();
    }
    public void Trendlines(Action<gcFormatters> trendlines)
    {
        var options = new gcFormatters();
        if (trendlines is not null)
            trendlines(options);
        _settings.trendlines = options.GetFormatters();
    }
    public void Series(Action<gcFormatters> series)
    {
        var options = new gcFormatters();
        if (series is not null)
            series(options);
        _settings.series = options.GetFormatters();
    }
    public void BackgroundColor(Action<gcBackgroundColor> color)
    {
        var options = new gcBackgroundColor();
        if (color is not null)
            color(options);
        _settings.backgroundColor = options;
    }
    public void ChartArea(Action<gcChartAreaOptions> area)
    {
        var options = new gcChartAreaOptions();
        if (area is not null)
            area(options);
        _settings.chartArea = options.ReturnSettings();
    }
    public string? isStacked
    {
        set
        {
            _settings.isStacked = value;
        }
    }
    public void Tooltip(Action<gcTooltipOptions> tooltip)
    {
        var options = new gcTooltipOptions();
        if (tooltip is not null)
            tooltip(options);
        _settings.tooltip = options.ReturnSettings();
    }
    // FocusTarget = "category" or "datum" turns on the tooltip for the domain axis
    public string? focusTarget
    {
        set
        {
            _settings.focusTarget = value;
        }
    }
    public void Explorer(Action<gcExplorerOptions> explorer)
    {
        var options = new gcExplorerOptions();
        if (explorer is not null)
            explorer(options);
        _settings.explorer = options.ReturnSettings();
    }
    public int? width
    {
        set
        {
            _settings.width = value;
        }
    }
    public int? height
    {
        set
        {
            _settings.height = value;
        }
    }
    public string? aggregationTarget
    {
        set
        {
            _settings.aggregationTarget = value ?? gcAggregationTargetType.Auto;
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
    public void colors(params string[] colors)
    {
        _settings.colors = colors;
    }
    // Used with the material theme
    public void Chart(Action<gcChart> chart)
    {
        var options = new gcChart();
        if (chart is not null)
            chart(options);
        _settings.chart = options;
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
    public bool? interpolateNulls
    {
        set
        {
            _settings.interpolateNulls = value;
        }
    }
    public void lineDashStyle(params double[] styles)
    {
        _settings.lineDashStyle = styles;
    }
    public string? orientation
    {
        set
        {
            _settings.orientation = value;
        }
    }
    public string? pointShape
    {
        set
        {
            _settings.pointShape = value;
        }
    }
    public bool? pointsVisible
    {
        set
        {
            _settings.pointsVisible = value ?? true;
        }
    }
    public bool? reverseCategories
    {
        set
        {
            _settings.reverseCategories = value;
        }
    }
    public string? selectionMode
    {
        set
        {
            _settings.selectionMode = value;
        }
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
}
