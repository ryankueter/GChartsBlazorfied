/**
 * Author: Ryan A. Kueter
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 */
using GChartsDataTableBlazorfied;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace GChartsBlazorfied;

public partial class ScatterChart
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
    public string? Title { get; set; }

    [Parameter]
    public gcChart? Chart { get; set; } // Used with the material theme
    [Parameter]
    public gcAxis? HAxis { get; set; }
    [Parameter]
    public gcAxis? VAxis { get; set; }

    [Parameter]
    public gcChartArea? ChartArea { get; set; }
    [Parameter]
    public double? PointSize { get; set; }
    [Parameter]
    public gcColors? Colors { get; set; }
    [Parameter]
    public gcTextStyle? TextStyle { get; set; }
    [Parameter]
    public gcLegend? Legend { get; set; }
    [Parameter]
    public gcFormatters? TrendLines { get; set; }
    [Parameter]
    public gcBackgroundColor? BackgroundColor { get; set; }
    [Parameter]
    public string? AggregationTarget { get; set; }
    [Parameter]
    public gcAnimation? Animation { get; set; }
    [Parameter]
    public gcAnnotations? Annotations { get; set; }
    [Parameter]
    public string? AxisTitlesPosition { get; set; }
    [Parameter]
    public gcCrosshair? Crosshair { get; set; }
    [Parameter]
    public string? CurveType { get; set; }
    [Parameter]
    public double? DataOpacity { get; set; }
    [Parameter]
    public bool? EnableInteractivity { get; set; }
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
    public double? LineWidth { get; set; }
    [Parameter]
    public string? Orientation { get; set; }
    [Parameter]
    public string? PointShape { get; set; }
    [Parameter]
    public bool? PointsVisible { get; set; }
    [Parameter]
    public string? SelectionMode { get; set; }
    [Parameter]
    public gcFormatters? Series { get; set; }
    [Parameter]
    public string? Theme { get; set; }
    [Parameter]
    public string? TitlePosition { get; set; }
    [Parameter]
    public gcTextStyle? TitleTextStyle { get; set; }
    [Parameter]
    public gcTooltip? Tooltip { get; set; }
    [Parameter]
    public double? Width { get; set; }

    [Parameter]
    public IEnumerable<object>? ObjectArray { get; set; }
    [Parameter]
    public gcDataTableBuilder? DataTable { get; set; }

    [Parameter]
    public ScatterChartOptions? Options { get; set; }
    private ScatterChartOptions? _options { get; set; }

    #region Click Event

    [Parameter]
    public EventCallback<gcClickEventArgs> OnClick { get; set; }

    private DotNetObjectReference<ScatterChart>? objectReference;

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
            _options = new ScatterChartOptions();       

        if (Title is not null)
            _options.title = Title;

        if (Chart is not null)
            _options.chart = Chart;

        if (HAxis is not null)
            _options.hAxis = HAxis;

        if (VAxis is not null)
            _options.vAxis = VAxis;

        if (ChartArea is not null)
            _options.chartArea = ChartArea;

        if (PointSize is not null)
            _options.pointSize = PointSize;

        if (Colors is not null)
            _options.colors = Colors.GetColors();

        if (TextStyle is not null)
            _options.textStyle = TextStyle;

        if (Legend is not null)
            _options.legend = Legend;

        if (TrendLines is not null)
            _options.trendlines = TrendLines.GetFormatters();

        if (BackgroundColor is not null)
            _options.backgroundColor = BackgroundColor;

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

        if (LineWidth is not null)
            _options.lineWidth = LineWidth;

        if (Orientation is not null)
            _options.orientation = Orientation;

        if (PointShape is not null)
            _options.pointShape = PointShape;

        if (PointsVisible is not null)
            _options.pointsVisible = PointsVisible;

        if (SelectionMode is not null)
            _options.selectionMode = SelectionMode;

        if (Series is not null)
            _options.series = Series.GetFormatters();

        if (Theme is not null)
            _options.theme = Theme;

        if (TitlePosition is not null)
            _options.titlePosition = TitlePosition;

        if (TitleTextStyle is not null)
            _options.titleTextStyle = TitleTextStyle;

        if (Tooltip is not null)
            _options.tooltip = Tooltip;

        if (Width is not null)
            _options.width = Width;
    }
    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            // chartType, chartData, chartOptions, elementId, dotNetObjectReference, usedatatable
            await JSRuntime.InvokeVoidAsync("GoogleChart", "ScatterChart", DataTable is not null ? DataTable!.Build() : ObjectArray, _options, id, objectReference, DataTable is not null ? true : false);
        }
    }

    public void Dispose() => objectReference?.Dispose();
}
