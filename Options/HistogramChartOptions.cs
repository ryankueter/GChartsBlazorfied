/**
 * Author: Ryan A. Kueter
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 */
namespace GChartsBlazorfied;
public class HistogramChartOptions
{
    public string? title { get; set; }
    public gcChart? chart { get; set; } // Used with the material theme
    public gcLegend? legend { get; set; }
    public string[]? colors { get; set; }
    public gcHistogram? histogram { get; set; }
    public gcAxis? vAxis { get; set; }
    public bool? interpolateNulls { get; set; }
    public gcAnimation? animation { get; set; }
    public string? axisTitlesPosition { get; set; } = gcAxisTitlesPositionType.Out;
    public gcBackgroundColor? backgroundColor { get; set; }
    public gcBar? bar { get; set; }
    public gcChartArea? chartArea { get; set; }
    public double? dataOpacity { get; set; } = 1;
    public bool? enableInteractivity { get; set; } = true;
    public string? focusTarget { get; set; }
    public double? fontSize { get; set; }
    public string? fontName { get; set; }
    public bool? forceIFrame { get; set; }
    public gcAxis? hAxis { get; set; }
    public double? height { get; set; }
    public string? isStacked { get; set; }
    public string? orientation { get; set; }
    public bool? reverseCategories { get; set; }
    public object? series { get; set; }
    public string? theme { get; set; }
    public string? titlePosition { get; set; } = gcTitlePositionType.Out;
    public gcTextStyle? titleTextStyle { get; set; }
    public gcTooltip? tooltip { get; set; }
    public double? width { get; set; }
}
