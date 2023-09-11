/**
 * Author: Ryan A. Kueter
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 */
using GChartsDataTableBlazorfied;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace GChartsBlazorfied;

public partial class AreaChart
{
    /// <summary>
    /// Element Id
    /// </summary>
    private string id = Guid.NewGuid().ToString();

    [Inject]
    private IJSRuntime JSRuntime { get; set; } = null!;

    [Parameter]
    public string? Title { get; set; }

    [Parameter]
    public gcChart? Chart { get; set; } // Used with the material theme

    [Parameter]
    public string? Style { get; set; }

    [Parameter]
    public gcTextStyle? TextStyle { get; set; }

    [Parameter]
    public gcAxis? HAxis { get; set; }

    [Parameter]
    public gcAxis? VAxis { get; set; }

    [Parameter]
    public gcChartArea? ChartArea { get; set; }

    [Parameter]
    public string? IsStacked { get; set; }

    [Parameter]
    public double? PointSize { get; set; }

    [Parameter]
    public gcLegend? Legend { get; set; }

    [Parameter]
    public gcBackgroundColor? BackgroundColor { get; set; }

    [Parameter]
    public double? AreaOpacity { get; set; }

    [Parameter]
    public double? LineWidth { get; set; }

    [Parameter]
    public gcAnimation? Animation { get; set; }

    [Parameter]
    public gcTooltip? Tooltip { get; set; }

    [Parameter]
    public gcFormatters? Series { get; set; }

    [Parameter]
    public string? AggregationTarget { get; set; }
    [Parameter]
    public gcAnnotations? Annotations { get; set; }
    [Parameter]
    public string? AxisTitlesPosition { get; set; }
    [Parameter]
    public gcColors? Colors { get; set; }
    [Parameter]
    public gcCrosshair? Crosshair { get; set; }
    [Parameter]
    public double? DataOpacity { get; set; }
    [Parameter]
    public double? EnableInteractivity { get; set; }
    [Parameter]
    public gcExplorer? Explorer { get; set; }
    [Parameter]
    public double? FontSize { get; set; }
    [Parameter]
    public string? FontName { get; set; }
    [Parameter]
    public bool? ForceIFrame { get; set; }
    [Parameter]
    public double? Height { get; set; }
    [Parameter]
    public bool? InterpolateNulls { get; set; }
    [Parameter]
    public int[]? LineDashStyle { get; set; }
    [Parameter]
    public string? Orientation { get; set; }
    [Parameter]
    public string? PointShape { get; set; }
    [Parameter]
    public bool? PointsVisible { get; set; }
    [Parameter]
    public bool? ReverseCategories { get; set; }
    [Parameter]
    public string? SelectionMode { get; set; }
    [Parameter]
    public string? Theme { get; set; }
    [Parameter]
    public string? TitlePosition { get; set; }
    [Parameter]
    public gcTextStyle? TitleTextStyle { get; set; }
    [Parameter]
    public double? Width { get; set; }

    [Parameter]
    public IEnumerable<object>? ObjectArray { get; set; }

    [Parameter]
    public gcDataTableBuilder? DataTable { get; set; }

    [Parameter]
    public AreaChartOptions? Options { get; set; }

    private AreaChartOptions? _options { get; set; }

    #region Click Event
    private DotNetObjectReference<AreaChart>? objectReference;

    [Parameter]
    public EventCallback<gcClickEventArgs> OnClick { get; set; }   

    [JSInvokable]
    public void ClickEvent(int rowIndex, int colIndex) => OnClick.InvokeAsync(new gcClickEventArgs { row = rowIndex, column = colIndex });
    #endregion

    protected override void OnInitialized()
    {
        objectReference = DotNetObjectReference.Create(this);

        if (Options is not null)
            _options = Options;
        else
            _options = new AreaChartOptions();

        if (Title is not null)
            _options.title = Title;

        if (Chart is not null)
            _options.chart = Chart;

        if (TextStyle is not null)
            _options.textStyle = TextStyle;

        if (Series is not null)
            _options.series = Series.GetFormatters();

        if (HAxis is not null)
            _options.hAxis = HAxis;

        if (VAxis is not null)
            _options.vAxis = VAxis;

        if (ChartArea is not null)
            _options.chartArea = ChartArea;

        if (IsStacked is not null)
            _options.isStacked = IsStacked;

        if (PointSize is not null)
            _options.pointSize = PointSize;

        if (Legend is not null)
            _options.legend = Legend;

        if (BackgroundColor is not null)
            _options.backgroundColor = BackgroundColor;

        if (AreaOpacity is not null)
            _options.areaOpacity = AreaOpacity;

        if (LineWidth is not null)
            _options.lineWidth = LineWidth;

        if (Animation is not null)
            _options.animation = Animation;

        if (Tooltip is not null)
            _options.tooltip = Tooltip;

        if (AggregationTarget is not null)
            _options.aggregationTarget = AggregationTarget;

        if (Annotations is not null)
            _options.annotations = Annotations;

        if (AxisTitlesPosition is not null)
            _options.axisTitlesPosition = AxisTitlesPosition;

        if (Colors is not null)
            _options.colors = Colors.GetColors();

        if (Crosshair is not null)
            _options.crosshair = Crosshair;

        if (DataOpacity is not null)
            _options.dataOpacity = DataOpacity;

        if (EnableInteractivity is not null)
            _options.enableInteractivity = EnableInteractivity;

        if (Explorer is not null)
            _options.explorer = Explorer;

        if (FontSize is not null)
            _options.fontSize = FontSize;

        if (FontName is not null)
            _options.fontName = FontName;

        if (ForceIFrame is not null)
            _options.forceIFrame = ForceIFrame;

        if (Height is not null)
            _options.height = Height;

        if (InterpolateNulls is not null)
            _options.interpolateNulls = InterpolateNulls;

        if (LineDashStyle is not null)
            _options.lineDashStyle = LineDashStyle;

        if (Orientation is not null)
            _options.orientation = Orientation;

        if (PointShape is not null)
            _options.pointShape = PointShape;

        if (PointsVisible is not null)
            _options.pointsVisible = PointsVisible;

        if (ReverseCategories is not null)
            _options.reverseCategories = ReverseCategories;

        if (SelectionMode is not null)
            _options.selectionMode = SelectionMode;

        if (Theme is not null)
            _options.theme = Theme;

        if (TitlePosition is not null)
            _options.titlePosition = TitlePosition;

        if (TitleTextStyle is not null)
            _options.titleTextStyle = TitleTextStyle;

        if (Width is not null)
            _options.width = Width;
    }

    // chartType, chartData, chartOptions, elementId, dotNetObjectReference, usedatatable
    protected override async Task OnInitializedAsync() => await JSRuntime.InvokeVoidAsync("GoogleChart", "AreaChart", DataTable is not null ? DataTable!.Build() : ObjectArray, _options, id, objectReference, DataTable is not null ? true : false);
    public void Dispose() => objectReference?.Dispose();
}
