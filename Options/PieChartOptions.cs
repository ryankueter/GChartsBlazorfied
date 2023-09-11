/**
 * Author: Ryan A. Kueter
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 */
namespace GChartsBlazorfied;

public class PieChartOptions
{
    public string? title { get; set; }
    public gcChart? chart { get; set; } // Used with the material theme
    public double? pieHole { get; set; }
    public object? slices { get; set; }
    public gcLegend? legend { get; set; }
    public gcTooltip? tooltip { get; set; }
    public gcBackgroundColor? backgroundColor { get; set; }
    public gcChartArea? chartArea { get; set; }
    public gcAnimation? animation { get; set; }
    public bool? reverseCategories { get; set; }
    public double? sliceVisibilityThreshold { get; set; }
    public string? pieSliceText { get; set; }
    public string? pieSliceBorderColor { get; set; }
    public gcPieSliceTextStyle? pieSliceTextStyle { get; set; }
    public bool? enableInteractivity { get; set; } = true;
    public string? focusTarget { get; set; }
    public bool? is3D { get; set; }
    public int? pieStartAngle { get; set; }
    public string? pieResidueSliceLabel { get; set; }
    public gcAnnotations? annotations { get; set; }
    public string? axisTitlesPosition { get; set; }
    public int? fontSize { get; set; }
    public string? fontName { get; set; }
    public string[]? colors { get; set; }
    public bool? forceIFrame { get; set; }
    public double? height { get; set; }
    public double? width { get; set; }
    public string? pieResidueSliceColor { get; set; }
}
