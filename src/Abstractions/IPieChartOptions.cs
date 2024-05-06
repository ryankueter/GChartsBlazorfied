/**
 * Author: Ryan A. Kueter
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 */
using GChartsBlazorfied.Options;
using GChartsBlazorfied.Models;
namespace GChartsBlazorfied
{
    public interface IPieChartOptions
    {
        string? axisTitlesPosition { set; }
        bool? enableInteractivity { set; }
        string? focusTarget { set; }
        string? fontName { set; }
        int? fontSize { set; }
        bool? forceIFrame { set; }
        double? height { set; }
        bool? is3D { set; }
        double? pieHole { set; }
        string? pieResidueSliceColor { set; }
        string? pieResidueSliceLabel { set; }
        string? pieSliceBorderColor { set; }
        string? pieSliceText { set; }
        int? pieStartAngle { set; }
        bool? reverseCategories { set; }
        double? sliceVisibilityThreshold { set; }
        string? title { set; }
        double? width { set; }

        void Animation(Action<gcAnimation> animation);
        void Annotations(Action<gcAnnotationsOptions> annotations);
        void BackgroundColor(Action<gcBackgroundColor> color);
        void Chart(Action<gcChart> chart);
        void ChartArea(Action<gcChartAreaOptions> area);
        void colors(params string[] colors);
        void Legend(Action<gcLegendOptions> legend);
        void PieSliceTextStyle(Action<gcPieSliceTextStyle> pieSliceTextStyle);
        void Slices(Action<gcFormatters> series);
        void Tooltip(Action<gcTooltipOptions> tooltip);
    }
}