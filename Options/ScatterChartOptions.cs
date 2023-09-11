/**
 * Author: Ryan A. Kueter
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 */
namespace GChartsBlazorfied;

public class ScatterChartOptions
{
    public string? title { get; set; }
    public gcChart? chart { get; set; } // Used with the material theme
    public gcTextStyle? textStyle { get; set; }
    public gcAxis? hAxis { get; set; }
    public gcAxis? vAxis { get; set; }
    public gcChartArea? chartArea { get; set; }
    public double? pointSize { get; set; }
    public string[]? colors { get; set; }
    public gcLegend? legend { get; set; }
    public object? trendlines { get; set; }
    public gcBackgroundColor? backgroundColor { get; set; }
    public string? aggregationTarget { get; set; } = gcAggregationTargetType.Auto;
    public gcAnimation? animation { get; set; }
    public gcAnnotations? annotations { get; set; }
    public string? axisTitlesPosition { get; set; }
    public gcCrosshair? crosshair { get; set; }
    public string? curveType { get; set; }
    public double? dataOpacity { get; set; } = 1;
    public bool? enableInteractivity { get; set; }
    public gcExplorer? explorer { get; set; }
    public double? fontSize { get; set; }
    public string? fontName { get; set; }
    public bool? forceIFrame { get; set; }
    public double? height { get; set; }
    public double? lineWidth { get; set; }
    public string? orientation { get; set; }
    public string? pointShape { get; set; } = gcPointShapeType.Circle;
    public bool? pointsVisible { get; set; }
    public string? selectionMode { get; set; }
    public object? series { get; set; }
    public string? theme { get; set; }
    public string? titlePosition { get; set; } = gcTitlePositionType.Out;
    public gcTextStyle? titleTextStyle { get; set; }
    public gcTooltip? tooltip { get; set; }
    public double? width { get; set; }
}
