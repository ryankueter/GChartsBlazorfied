/**
 * Author: Ryan A. Kueter
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 */
namespace GChartsBlazorfied;
public class ColumnChartOptions
{
    public gcChart? chart { get; set; } // Used with the material theme
    public int height { get; set; }
    public int width { get; set; }
    public gcBar? bar { get; set; }
    public gcLegend? legend { get; set; }
    public gcAxis? vAxis { get; set; }
    public gcAxis? hAxis { get; set; }
    public gcAnimation? animation { get; set; }
    public gcBackgroundColor? backgroundColor { get; set; }
    public gcChartArea? chartArea { get; set; }
    public bool? enableInteractivity { get; set; }
    public gcAnnotations? annotations { get; set; }
    public string? axisTitlesPosition { get; set; }
    public gcTooltip? tooltip { get; set; }
    public string[]? colors { get; set; }
    public string? isStacked { get; set; }
    public double? dataOpacity { get; set; } = 1;
    public gcExplorer? explorer { get; set; }
    public string? focusTarget { get; set; }
    public double? fontSize { get; set; }
    public string? fontName { get; set; }
    public bool? forceIFrame { get; set; }
    public string? orientation { get; set; }
    public bool? reverseCategories { get; set; }
    public object? series { get; set; }
    public object? trendlines { get; set; }
    public string? theme { get; set; }
    public string? title { get; set; }
    public string? titlePosition { get; set; } = gcAxisTitlesPositionType.Out;
    public gcTextStyle? titleTextStyle { get; set; }
}
