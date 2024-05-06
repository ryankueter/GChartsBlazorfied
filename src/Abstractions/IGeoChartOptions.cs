using GChartsBlazorfied.Options;
using GChartsBlazorfied.Models;
namespace GChartsBlazorfied
{
    public interface IGeoChartOptions
    {
        string? datalessRegionColor { set; }
        string? defaultColor { set; }
        string? displayMode { set; }
        string? domain { set; }
        bool? enableRegionInteractivity { set; }
        bool? forceIFrame { set; }
        double? geochartVersion { set; }
        double? height { set; }
        bool? keepAspectRatio { set; }
        double? markerOpacity { set; }
        string? region { set; }
        double? regioncoderVersion { set; }
        string? resolution { set; }
        double? width { set; }

        void BackgroundColor(Action<gcBackgroundColor> color);
        void ColorAxis(Action<gcColorAxisOptions> colorAxis);
        void Legend(Action<gcLegendOptions> legend);
        void MagnifyingGlass(Action<gcMagnifyingGlass> magnifyingGlass);
        void SizAxis(Action<gcSizAxis> sizeAxis);
        void Tooltip(Action<gcTooltipOptions> tooltip);
    }
}