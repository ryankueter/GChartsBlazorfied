/**
 * Author: Ryan A. Kueter
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 */
using GChartsBlazorfied.Settings;
using GChartsBlazorfied.Models;
namespace GChartsBlazorfied.Options;

public class PieChartOptions : IPieChartOptions
{
    private PieChartSettings _settings = new();
    internal PieChartSettings ReturnSettings() => _settings;
    public string? title
    {
        set
        {
            _settings.title = value;
        }
    }
    public void Chart(Action<gcChart> chart)
    {
        var options = new gcChart();
        if (chart is not null)
            chart(options);
        _settings.chart = options;
    }
    public double? pieHole
    {
        set
        {
            _settings.pieHole = value;
        }
    }
    public void Slices(Action<gcFormatters> series)
    {
        var options = new gcFormatters();
        if (series is not null)
            series(options);
        _settings.slices = options.GetFormatters();
    }
    public void Legend(Action<gcLegendOptions> legend)
    {
        var options = new gcLegendOptions();
        if (legend is not null)
            legend(options);
        _settings.legend = options.ReturnSettings();
    }
    public void Tooltip(Action<gcTooltipOptions> tooltip)
    {
        var options = new gcTooltipOptions();
        if (tooltip is not null)
            tooltip(options);
        _settings.tooltip = options.ReturnSettings();
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
    public void Animation(Action<gcAnimation> animation)
    {
        var options = new gcAnimation();
        if (animation is not null)
            animation(options);
        _settings.animation = options;
    }
    public bool? reverseCategories
    {
        set
        {
            _settings.reverseCategories = value;
        }
    }
    public double? sliceVisibilityThreshold
    {
        set
        {
            _settings.sliceVisibilityThreshold = value;
        }
    }
    public string? pieSliceText
    {
        set
        {
            _settings.pieSliceText = value;
        }
    }
    public string? pieSliceBorderColor
    {
        set
        {
            _settings.pieSliceBorderColor = value;
        }
    }
    public void PieSliceTextStyle(Action<gcPieSliceTextStyle> pieSliceTextStyle)
    {
        var options = new gcPieSliceTextStyle();
        if (pieSliceTextStyle is not null)
            pieSliceTextStyle(options);
        _settings.pieSliceTextStyle = options;
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
    public bool? is3D
    {
        set
        {
            _settings.is3D = value;
        }
    }
    public int? pieStartAngle
    {
        set
        {
            _settings.pieStartAngle = value;
        }
    }
    public string? pieResidueSliceLabel
    {
        set
        {
            _settings.pieResidueSliceLabel = value;
        }
    }
    public void Annotations(Action<gcAnnotationsOptions> annotations)
    {
        var options = new gcAnnotationsOptions();
        if (annotations is not null)
            annotations(options);
        _settings.annotations = options.ReturnSettings();
    }
    public string? axisTitlesPosition
    {
        set
        {
            _settings.axisTitlesPosition = value ?? gcAxisTitlesPositionType.Out;
        }
    }
    public int? fontSize
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
    public void colors(params string[] colors)
    {
        _settings.colors = colors;
    }
    public bool? forceIFrame
    {
        set
        {
            _settings.forceIFrame = value;
        }
    }
    public double? height
    {
        set
        {
            _settings.height = value;
        }
    }
    public double? width
    {
        set
        {
            _settings.width = value;
        }
    }
    public string? pieResidueSliceColor
    {
        set
        {
            _settings.pieResidueSliceColor = value;
        }
    }
}
