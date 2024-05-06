/**
 * Author: Ryan A. Kueter
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 */
using GChartsBlazorfied.Options;
using GChartsBlazorfied.Models;
namespace GChartsBlazorfied
{
    public interface IScatterChartOptions
    {
        string? aggregationTarget { set; }
        string? axisTitlesPosition { set; }
        string? curveType { set; }
        double? dataOpacity { set; }
        bool? enableInteractivity { set; }
        string? fontName { set; }
        double? fontSize { set; }
        bool? forceIFrame { set; }
        double? height { set; }
        double? lineWidth { set; }
        string? orientation { set; }
        string? pointShape { set; }
        double? pointSize { set; }
        bool? pointsVisible { set; }
        string? selectionMode { set; }
        string? theme { set; }
        string? title { set; }
        string? titlePosition { set; }
        double? width { set; }

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
        void Series(Action<gcFormatters> series);
        void TextStyle(Action<gcTextStyle> style);
        void TitleTextStyle(Action<gcTextStyle> textStyle);
        void Tooltip(Action<gcTooltipOptions> tooltip);
        void Trendlines(Action<gcFormatters> trendlines);
        void VAxis(Action<gcAxisOptions> axis);
    }
}