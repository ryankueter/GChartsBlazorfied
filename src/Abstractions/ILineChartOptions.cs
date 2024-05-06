/**
 * Author: Ryan A. Kueter
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 */
using GChartsBlazorfied.Options;
using GChartsBlazorfied.Models;
namespace GChartsBlazorfied
{
    public interface ILineChartOptions
    {
        string? aggregationTarget { set; }
        string? axisTitlesPosition { set; }
        string? curveType { set; }
        double? dataOpacity { set; }
        bool? enableInteractivity { set; }
        string? focusTarget { set; }
        string? fontName { set; }
        double? fontSize { set; }
        bool? forceIFrame { set; }
        int? height { set; }
        bool? interpolateNulls { set; }
        string? isStacked { set; }
        int? lineWidth { set; }
        string? orientation { set; }
        string? pointShape { set; }
        int? pointSize { set; }
        bool? pointsVisible { set; }
        bool? reverseCategories { set; }
        string? selectionMode { set; }
        string? theme { set; }
        string? title { set; }
        string? titlePosition { set; }
        int? width { set; }

        void Animation(Action<gcAnimation> animation);
        void Annotations(Action<gcAnnotationsOptions> annotations);
        void BackgroundColor(Action<gcBackgroundColor> color);
        void Chart(Action<gcChart> chart);
        void ChartArea(Action<gcChartAreaOptions> area);
        void colors(params string[] colors);
        void Crosshair(Action<gcCrosshairOptions> crosshair);
        void Explorer(Action<gcExplorerOptions> explorer);
        void HAxis(Action<gcAxisOptions> axis);
        void Legend(Action<gcLegendOptions> legend);
        void lineDashStyle(params double[] styles);
        void Series(Action<gcFormatters> series);
        void TitleTextStyle(Action<gcTextStyle> textStyle);
        void Tooltip(Action<gcTooltipOptions> tooltip);
        void Trendlines(Action<gcFormatters> trendlines);
        void VAxis(Action<gcAxisOptions> axis);
    }
}