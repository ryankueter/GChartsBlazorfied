
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

using GChartsBlazorfied.Settings;
using GChartsBlazorfied.Options;

namespace GChartsBlazorfied;

/// <summary>
/// https://developers.google.com/chart/interactive/docs/gallery/geochart
/// </summary>
public partial class GeoChart
{
    /// <summary>
    /// Element Id
    /// </summary>
    private string id = Guid.NewGuid().ToString();

    [Inject]
    private IJSRuntime JSRuntime { get; set; } = null!;

    [Parameter]
    public string? ApiKey { get; set; }

    [Parameter]
    public string? Style { get; set; }
    [Parameter]
    public IEnumerable<object>? ObjectArray { get; set; }
    [Parameter]
    public gcDataTableBuilder? DataTable { get; set; }

    [Parameter]
    public Action<GeoChartOptions>? Options { get; set; }
    private GeoChartOptions? _options { get; set; } = new();
    private GeoChartSettings? _settings { get; set; }

    #region Click Event
    private DotNetObjectReference<GeoChart>? objectReference;

    [Parameter]
    public EventCallback<gcClickEventArgs> OnClick { get; set; }

    [JSInvokable]
    public void ClickEvent(int rowIndex, int colIndex) => OnClick.InvokeAsync(new gcClickEventArgs { row = rowIndex, column = colIndex });
    #endregion

    protected override void OnInitialized()
    {
        // Invoke the Options
        if (Options is not null)
        {
            Options(_options!);
        }

        _settings = _options!.ReturnSettings();

        objectReference = DotNetObjectReference.Create(this);
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            // chartData, chartOptions, elementId, dotNetObjectReference, usedatatable, apikey, materialTheme
            await JSRuntime.InvokeVoidAsync("gcGeoChart", DataTable is not null ? DataTable!.Build() : ObjectArray, _settings, id, objectReference, DataTable is not null ? true : false, ApiKey, false);
            StateHasChanged();
        }
    }

    public void Dispose() => objectReference?.Dispose();
}
