using GChartsBlazorfied.Models;
namespace GChartsBlazorfied
{
    public interface IMapChartOptions
    {
        bool enableScrollWheel { set; }
        string? lineColor { set; }
        int? lineWidth { set; }
        string? mapType { set; }
        bool showInfoWindow { set; }
        bool showLine { set; }
        bool showTooltip { set; }
        bool useMapTypeControl { set; }
        bool UseMapTypeControl { set; }
        int? zoomLevel { set; }

        void Icons(Action<gcIcons> icons);
        void Maps(Action<gcMaps> map);
        void mapTypeIds(params string[] ids);
    }
}