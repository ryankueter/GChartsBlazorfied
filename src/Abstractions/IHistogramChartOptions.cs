/**
 * Author: Ryan A. Kueter
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 */
using GChartsBlazorfied.Options;
using GChartsBlazorfied.Models;
namespace GChartsBlazorfied
{
    public interface IHistogramChartOptions
    {
        string? axisTitlesPosition { set; }
        double? dataOpacity { set; }
        bool? enableInteractivity { set; }
        string? focusTarget { set; }
        string? fontName { set; }
        double? fontSize { set; }
        bool? forceIFrame { set; }
        double? height { set; }
        bool? interpolateNulls { set; }
        string? isStacked { set; }
        string? orientation { set; }
        bool? reverseCategories { set; }
        string? theme { set; }
        string? title { set; }
        string? titlePosition { set; }
        double? width { set; }

        void Animation(Action<gcAnimation> animation);
        void BackgroundColor(Action<gcBackgroundColor> color);
        void Bar(Action<gcBar> bar);
        void Chart(Action<gcChart> chart);
        void ChartArea(Action<gcChartAreaOptions> area);
        void colors(params string[] colors);
        void HAxis(Action<gcAxisOptions> axis);
        void Histogram(Action<gcHistogram> histogram);
        void Legend(Action<gcLegendOptions> legend);
        void Series(Action<gcFormatters> series);
        void TitleTextStyle(Action<gcTextStyle> textStyle);
        void Tooltip(Action<gcTooltipOptions> tooltip);
        void VAxis(Action<gcAxisOptions> axis);
    }
}