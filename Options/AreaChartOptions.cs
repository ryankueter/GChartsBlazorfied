/**
 * Author: Ryan A. Kueter
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 */
namespace GChartsBlazorfied;

public class AreaChartOptions
{
    public string? title { get; set; }
    public gcChart? chart { get; set; } // Used with the material theme
    public gcTextStyle? textStyle { get; set; }
    public gcAxis? hAxis { get; set; }
    public gcAxis? vAxis { get; set; }
    public gcChartArea? chartArea { get; set; }
    public string? isStacked { get; set; }
    public double? pointSize { get; set; }
    public object? series { get; set; }
    public gcLegend? legend { get; set; }
    public gcBackgroundColor? backgroundColor { get; set; } // String or object
    public double? areaOpacity { get; set; } = 0.3;
    public double? lineWidth { get; set; }
    public gcAnimation? animation { get; set; }
    public string? focusTarget { get; set; } // FocusTarget = "category" or "datum" turns on the tooltip for the domain axis
    public gcBar? bar { get; set; } // bar: { groupWidth: '90%' } rotates the tooltip
    public gcTooltip? tooltip { get; set; }
    public string? aggregationTarget { get; set; }
    public gcAnnotations? annotations { get; set; }
    public string? axisTitlesPosition { get; set; }
    public string[]? colors { get; set; }
    public gcCrosshair? crosshair { get; set; }
    public double? dataOpacity { get; set; } = 1;
    public double? enableInteractivity { get; set; }
    public gcExplorer? explorer { get; set; }
    public double? fontSize { get; set; }
    public string? fontName { get; set; }
    public bool? forceIFrame { get; set; }
    public double? height { get; set; }
    public bool? interpolateNulls { get; set; }
    public int[]? lineDashStyle { get; set; }
    public string? orientation { get; set; }
    public string? pointShape { get; set; }
    public bool? pointsVisible { get; set; } = true;
    public bool? reverseCategories { get; set; }
    public string? selectionMode { get; set; }
    public string? theme { get; set; }
    public string? titlePosition { get; set; }
    public gcTextStyle? titleTextStyle { get; set; }
    public double? width { get; set; }
}
