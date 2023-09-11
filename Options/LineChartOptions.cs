/**
 * Author: Ryan A. Kueter
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 */
namespace GChartsBlazorfied;

public class LineChartOptions
{
    public string? title { get; set; }
    public string? curveType { get; set; }
    public gcLegend? legend { get; set; }
    public gcAxis? hAxis { get; set; }
    public gcAxis? vAxis { get; set; }
    public int? pointSize { get; set; }
    public int? lineWidth { get; set; }
    public gcAnnotations? annotations { get; set; }
    public gcCrosshair? crosshair { get; set; }
    public object? trendlines { get; set; } // Formatters
    public object? series { get; set; } // Formatters
    public gcBackgroundColor? backgroundColor { get; set; }
    public gcChartArea? chartArea { get; set; }
    public string? isStacked { get; set; }
    public gcTooltip? tooltip { get; set; }
    public string? focusTarget { get; set; }
    public gcExplorer? explorer { get; set; }
    public int? width { get; set; }
    public int? height { get; set; }
    public string? aggregationTarget { get; set; } = gcAggregationTargetType.Auto;
    public gcAnimation? animation { get; set; }
    public string? axisTitlesPosition { get; set; }
    public string[]? colors { get; set; }
    public gcChart? chart { get; set; } // Used with the material theme
    public double? dataOpacity { get; set; } = 1;
    public bool? enableInteractivity { get; set; } = true;
    public double? fontSize { get; set; }
    public string? fontName { get; set; }
    public bool? forceIFrame { get; set; }
    public bool? interpolateNulls { get; set; }
    public int[]? lineDashStyle { get; set; }
    public string? orientation { get; set; }
    public string? pointShape { get; set; }
    public bool? pointsVisible { get; set; }
    public bool? reverseCategories { get; set; }
    public string? selectionMode { get; set; }
    public string? theme { get; set; }
    public string? titlePosition { get; set; } = gcTitlePositionType.Out;
    public gcTextStyle? titleTextStyle { get; set; }
}
