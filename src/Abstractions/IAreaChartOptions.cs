using GChartsBlazorfied.Options;
using GChartsBlazorfied.Models;
namespace GChartsBlazorfied
{
    public interface IAreaChartOptions
    {
        string? aggregationTarget { set; }
        double? areaOpacity { set; }
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
        double? lineWidth { set; }
        string? orientation { set; }
        string? pointShape { set; }
        double? pointSize { set; }
        bool? pointsVisible { set; }
        bool? reverseCategories { set; }
        string? selectionMode { set; }
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
        void Crosshair(Action<gcCrosshairOptions> crosshair);
        void Explorer(Action<gcExplorerOptions> explorer);
        void HAxis(Action<gcAxisOptions> axis);
        void Legend(Action<gcLegendOptions> legend);
        void lineDashStyle(params double[] styles);
        void Series(Action<gcFormatters> series);
        void TextStyle(Action<gcTextStyle> style);
        void TitleTextStyle(Action<gcTextStyle> textStyle);
        void Tooltip(Action<gcTooltipOptions> tooltip);
        void VAxis(Action<gcAxisOptions> axis);
    }
}