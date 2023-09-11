/**
 * Author: Ryan A. Kueter
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 */
using GChartsDataTableBlazorfied;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace GChartsBlazorfied;

public partial class BarChart
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
    public gcColors? Colors { get; set; }

    [Parameter]
    public gcAxis? HAxis { get; set; }

    [Parameter]
    public gcAxis? VAxis { get; set; }

    [Parameter]
    public gcChartArea? ChartArea { get; set; }

    [Parameter]
    public gcLegend? Legend { get; set; }

    [Parameter]
    public string? IsStacked { get; set; }

    [Parameter]
    public string? Orientation { get; set; }

    [Parameter]
    public gcBar? Bar { get; set; }

    [Parameter]
    public gcAnnotations? Annotations { get; set; }

    [Parameter]
    public gcAnimation? Animation { get; set; }

    [Parameter]
    public gcTooltip? Tooltip { get; set; }
    [Parameter]
    public string? AxisTitlesPosition { get; set; }
    [Parameter]
    public gcBackgroundColor? BackgroundColor { get; set; }
    [Parameter]
    public string? Bars { get; set; }
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
    public double? Width { get; set; }
    [Parameter]
    public bool? ReverseCategories { get; set; }
    [Parameter]
    public gcFormatters? Series { get; set; }
    [Parameter]
    public gcFormatters? Trendlines { get; set; }
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
    public BarChartOptions? Options { get; set; }
    private BarChartOptions? _options { get; set; }

    #region Click Event

    [Parameter]
    public EventCallback<gcClickEventArgs> OnClick { get; set; }
    
    private DotNetObjectReference<BarChart>? objectReference;

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
            _options = new BarChartOptions();

        // Load each manual option
        if (Title is not null)
            _options.title = Title;

        if (Chart is not null)
            _options.chart = Chart;

        if (ChartArea is not null)
            _options.chartArea = ChartArea;

        if (Colors is not null)
            _options.colors = Colors.GetColors();

        if (HAxis is not null)
            _options.hAxis = HAxis;

        if (VAxis is not null)
            _options.vAxis = VAxis;

        if (Legend is not null)
            _options.legend = Legend;

        if (Bar is not null)
            _options.bar = Bar;

        if (IsStacked is not null)
            _options.isStacked = IsStacked;

        if (Annotations is not null)
            _options.annotations = Annotations;

        if (Animation is not null)
            _options.animation = Animation;

        if (Orientation is not null)
            _options.orientation = Orientation;

        if (Tooltip is not null)
            _options.tooltip = Tooltip;

        if (AxisTitlesPosition is not null)
            _options.axisTitlesPosition = AxisTitlesPosition;

        if (BackgroundColor is not null)
            _options.backgroundColor = BackgroundColor;

        if (Bars is not null)
            _options.bars = Bars;

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

        if (Width is not null)
            _options.width = Width;

        if (ReverseCategories is not null)
            _options.reverseCategories = ReverseCategories;

        if (Series is not null)
            _options.series = Series.GetFormatters();

        if (Trendlines is not null)
            _options.trendlines = Trendlines.GetFormatters();

        if (Theme is not null)
            _options.theme = Theme;

        if (TitlePosition is not null)
            _options.titlePosition = TitlePosition;

        if (TitleTextStyle is not null)
            _options.titleTextStyle = TitleTextStyle;
    }

    // chartType, chartData, chartOptions, elementId, dotNetObjectReference, usedatatable
    protected override async Task OnInitializedAsync() => await JSRuntime.InvokeVoidAsync("GoogleChart", "BarChart", DataTable is not null ? DataTable!.Build() : ObjectArray, _options, id, objectReference, DataTable is not null ? true : false);
    public void Dispose() => objectReference?.Dispose();
}
