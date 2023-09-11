/**
 * Author: Ryan A. Kueter
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 */
using GChartsDataTableBlazorfied;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace GChartsBlazorfied;

public partial class LineChart
{
    [Inject]
    private IJSRuntime JSRuntime { get; set; } = null!;

    /// <summary>
    /// Element Id
    /// </summary>
    private string id = Guid.NewGuid().ToString();

    [Parameter]
    public string? Style { get; set; }
    [Parameter]
    public int? Width { get; set; }
    [Parameter]
    public int? Height { get; set; }
    [Parameter]
    public string? Title { get; set; }
    [Parameter]
    public string? CurveType { get; set; }
    [Parameter]
    public gcLegend? Legend { get; set; }
    [Parameter]
    public gcAxis? HAxis { get; set; }
    [Parameter]
    public gcAxis? VAxis { get; set; }
    [Parameter]
    public int? PointSize { get; set; }
    [Parameter]
    public int? LineWidth { get; set; }
    [Parameter]
    public gcAnnotations? Annotations { get; set; }
    [Parameter]
    public gcCrosshair? Crosshair { get; set; }
    [Parameter]
    public gcFormatters? Trendlines { get; set; }
    [Parameter]
    public gcFormatters? Series { get; set; }
    [Parameter]
    public gcBackgroundColor? BackgroundColor { get; set; }
    [Parameter]
    public gcChartArea? ChartArea { get; set; }
    [Parameter]
    public string? IsStacked { get; set; }
    [Parameter]
    public gcTooltip? Tooltip { get; set; }
    [Parameter]
    public string? FocusTarget { get; set; }
    [Parameter]
    public gcExplorer? Explorer { get; set; }
    [Parameter]
    public string? AggregationTarget { get; set; }
    [Parameter]
    public gcAnimation? Animation { get; set; }
    [Parameter]
    public string? AxisTitlesPosition { get; set; }
    [Parameter]
    public gcColors? Colors { get; set; }
    [Parameter]
    public gcChart? Chart { get; set; } // Used with the material theme
    [Parameter]
    public double? DataOpacity { get; set; }
    [Parameter]
    public bool? EnableInteractivity { get; set; }
    [Parameter]
    public double? FontSize { get; set; }
    [Parameter]
    public string? FontName { get; set; }
    [Parameter]
    public bool? ForceIFrame { get; set; }
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
    public IEnumerable<object>? ObjectArray { get; set; }
    [Parameter]
    public gcDataTableBuilder? DataTable { get; set; }

    [Parameter]
    public LineChartOptions? Options { get; set; }
    private LineChartOptions? _options { get; set; }

    #region Click Event

    [Parameter]
    public EventCallback<gcClickEventArgs> OnClick { get; set; }

    private DotNetObjectReference<LineChart>? objectReference;

    [JSInvokable]
    public void ClickEvent(int rowIndex, int colIndex) => OnClick.InvokeAsync(new gcClickEventArgs { row = rowIndex, column = colIndex });
    #endregion

    protected override void OnInitialized()
    {
        objectReference = DotNetObjectReference.Create(this);

        // Load the options
        if (Options is not null)
            _options = Options;
        else
            _options = new LineChartOptions();

        if (Width is not null)
            _options.width = Width;

        if (Height is not null)
            _options.height = Height;

        if (Title is not null)
            _options.title = Title;

        if (CurveType is not null)
            _options.curveType = CurveType;

        if (Legend is not null)
            _options.legend = Legend;

        if (HAxis is not null)
            _options.hAxis = HAxis;

        if (VAxis is not null)
            _options.vAxis = VAxis;

        if (PointSize is not null)
            _options.pointSize = PointSize;

        if (LineWidth is not null)
            _options.lineWidth = LineWidth;

        if (Annotations is not null)
            _options.annotations = Annotations;

        if (Crosshair is not null)
            _options.crosshair = Crosshair;

        if (Trendlines is not null)
            _options.trendlines = Trendlines.GetFormatters();

        if (Series is not null)
            _options.series = Series.GetFormatters();

        if (BackgroundColor is not null)
            _options.backgroundColor = BackgroundColor;

        if (ChartArea is not null)
            _options.chartArea = ChartArea;

        if (IsStacked is not null)
            _options.isStacked = IsStacked;

        if (Tooltip is not null)
            _options.tooltip = Tooltip;

        if (FocusTarget is not null)
            _options.focusTarget = FocusTarget;

        if (Explorer is not null)
            _options.explorer = Explorer;

        if (AggregationTarget is not null)
            _options.aggregationTarget = AggregationTarget;

        if (Animation is not null)
            _options.animation = Animation;

        if (AxisTitlesPosition is not null)
            _options.axisTitlesPosition = AxisTitlesPosition;

        if (Colors is not null)
            _options.colors = Colors.GetColors();

        if (Chart is not null)
            _options.chart = Chart;

        if (DataOpacity is not null)
            _options.dataOpacity = DataOpacity;

        if (EnableInteractivity is not null)
            _options.enableInteractivity = EnableInteractivity;

        if (FontSize is not null)
            _options.fontSize = FontSize;

        if (FontName is not null)
            _options.fontName = FontName;

        if (ForceIFrame is not null)
            _options.forceIFrame = ForceIFrame;

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
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            // chartType, chartData, chartOptions, elementId, dotNetObjectReference, usedatatable
            await JSRuntime.InvokeVoidAsync("GoogleChart", "LineChart", DataTable is not null ? DataTable!.Build() : ObjectArray, _options, id, objectReference, DataTable is not null ? true : false);
        }
    }

    public void Dispose() => objectReference?.Dispose();
}
