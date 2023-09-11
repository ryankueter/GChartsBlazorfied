/**
 * Author: Ryan A. Kueter
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 */
using GChartsDataTableBlazorfied;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace GChartsBlazorfied;

public partial class PieChart
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
    public double? PieHole { get; set; }
    [Parameter]
    public gcFormatters? Slices { get; set; }
    [Parameter]
    public gcLegend? Legend { get; set; }
    [Parameter]
    public gcTooltip? Tooltip { get; set; }
    [Parameter]
    public gcBackgroundColor? BackgroundColor { get; set; }
    [Parameter]
    public gcChartArea? ChartArea { get; set; }
    [Parameter]
    public gcAnimation? Animation { get; set; }
    [Parameter]
    public bool? ReverseCategories { get; set; }
    [Parameter]
    public double? SliceVisibilityThreshold { get; set; }
    [Parameter]
    public string? PieSliceText { get; set; }
    [Parameter]
    public string? PieSliceBorderColor { get; set; }
    [Parameter]
    public gcPieSliceTextStyle? PieSliceTextStyle { get; set; }
    [Parameter]
    public bool? EnableInteractivity { get; set; }
    [Parameter]
    public string? FocusTarget { get; set; }
    [Parameter]
    public bool? Is3D { get; set; }
    [Parameter]
    public int? PieStartAngle { get; set; }
    [Parameter]
    public string? PieResidueSliceLabel { get; set; }
    [Parameter]
    public gcAnnotations? Annotations { get; set; }
    [Parameter]
    public string? AxisTitlesPosition { get; set; }
    [Parameter]
    public int? FontSize { get; set; }
    [Parameter]
    public string? FontName { get; set; }
    [Parameter]
    public gcColors? Colors { get; set; }
    [Parameter]
    public bool? ForceIFrame { get; set; }
    [Parameter]
    public double? Height { get; set; }
    [Parameter]
    public double? Width { get; set; }
    [Parameter]
    public string? PieResidueSliceColor { get; set; }

    [Parameter]
    public IEnumerable<object>? ObjectArray { get; set; }
    [Parameter]
    public gcDataTableBuilder? DataTable { get; set; }

    [Parameter]
    public PieChartOptions? Options { get; set; }
    private PieChartOptions? _options { get; set; }

    #region Click Event

    [Parameter]
    public EventCallback<gcClickEventArgs> OnClick { get; set; }

    private DotNetObjectReference<PieChart>? objectReference;

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
            _options = new PieChartOptions();

        // Load each manual option
        if (Title is not null)
            _options.title = Title;

        if (Chart is not null)
            _options.chart = Chart;

        if (PieHole is not null)
            _options.pieHole = PieHole;

        if (Slices is not null)
            _options.slices = Slices.GetFormatters();

        if (Legend is not null)
            _options.legend = Legend;

        if (Tooltip is not null)
            _options.tooltip = Tooltip;

        if (BackgroundColor is not null)
            _options.backgroundColor = BackgroundColor;

        if (ChartArea is not null)
            _options.chartArea = ChartArea;

        if (Animation is not null)
            _options.animation = Animation;

        if (ReverseCategories is not null)
            _options.reverseCategories = ReverseCategories;

        if (ChartArea is not null)
            _options.chartArea = ChartArea;

        if (EnableInteractivity is not null)
            _options.enableInteractivity = EnableInteractivity;

        if (SliceVisibilityThreshold is not null)
            _options.sliceVisibilityThreshold = SliceVisibilityThreshold;

        if (PieSliceText is not null)
            _options.pieSliceText = PieSliceText;

        if (PieSliceBorderColor is not null)
            _options.pieSliceBorderColor = PieSliceBorderColor;

        if (PieSliceTextStyle is not null)
            _options.pieSliceTextStyle = PieSliceTextStyle;

        if (FocusTarget is not null)
            _options.focusTarget = FocusTarget;

        if (Is3D is not null)
            _options.is3D = Is3D;

        if (PieStartAngle is not null)
            _options.pieStartAngle = PieStartAngle;

        if (PieResidueSliceLabel is not null)
            _options.pieResidueSliceLabel = PieResidueSliceLabel;

        if (Annotations is not null)
            _options.annotations = Annotations;

        if (AxisTitlesPosition is not null)
            _options.axisTitlesPosition = AxisTitlesPosition;

        if (FontSize is not null)
            _options.fontSize = FontSize;

        if (FontName is not null)
            _options.fontName = FontName;

        if (Colors is not null)
            _options.colors = Colors.GetColors();

        if (ForceIFrame is not null)
            _options.forceIFrame = ForceIFrame;

        if (Height is not null)
            _options.height = Height;

        if (Width is not null)
            _options.width = Width;

        if (PieResidueSliceColor is not null)
            _options.pieResidueSliceColor = PieResidueSliceColor;
    }

    // chartType, chartData, chartOptions, elementId, dotNetObjectReference, usedatatable
    protected override async Task OnInitializedAsync() => await JSRuntime.InvokeVoidAsync("GoogleChart", "PieChart", DataTable is not null ? DataTable!.Build() : ObjectArray, _options, id, objectReference, DataTable is not null ? true : false);
    public void Dispose() => objectReference?.Dispose();
}