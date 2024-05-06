using GChartsBlazorfied.Options;
using GChartsBlazorfied.Models;
namespace GChartsBlazorfied
{
    public interface IBarChartOptions
    {
        string? axisTitlesPosition { set; }
        string? bars { set; }
        double? dataOpacity { set; }
        bool? enableInteractivity { set; }
        string? focusTarget { set; }
        string? fontName { set; }
        double? fontSize { set; }
        bool? forceIFrame { set; }
        double? height { set; }
        string? isStacked { set; }
        string? orientation { set; }
        bool? reverseCategories { set; }
        string? theme { set; }
        string? title { set; }
        string? titlePosition { set; }
        double? width { set; }

        void Animation(Action<gcAnimation> animation);
        void Annotations(Action<gcAnnotationsOptions> annotations);
        void BackgroundColor(Action<gcBackgroundColor> color);
        void Bar(Action<gcBar> bar);
        void Chart(Action<gcChart> chart);
        void ChartArea(Action<gcChartAreaOptions> area);
        void colors(params string[] colors);
        void Explorer(Action<gcExplorerOptions> explorer);
        void HAxis(Action<gcAxisOptions> axis);
        void Legend(Action<gcLegendOptions> legend);
        void Series(Action<gcFormatters> series);
        void TitleTextStyle(Action<gcTextStyle> textStyle);
        void Tooltip(Action<gcTooltipOptions> tooltip);
        void Trendlines(Action<gcFormatters> trendlines);
        void VAxis(Action<gcAxisOptions> axis);
    }
}