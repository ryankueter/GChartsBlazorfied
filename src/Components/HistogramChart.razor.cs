/**
 * Author: Ryan A. Kueter
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 */

using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

using GChartsBlazorfied.Settings;
using GChartsBlazorfied.Options;

namespace GChartsBlazorfied;

public partial class HistogramChart
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
    public IEnumerable<object>? ObjectArray { get; set; }
    [Parameter]
    public gcDataTableBuilder? DataTable { get; set; }

    [Parameter]
    public Action<HistogramChartOptions>? Options { get; set; }
    public HistogramChartOptions? _options { get; set; } = new();
    private HistogramChartSettings? _settings { get; set; }

    #region Click Event

    [Parameter]
    public EventCallback<gcClickEventArgs> OnClick { get; set; }

    private DotNetObjectReference<HistogramChart>? objectReference;

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

        if (Title is not null)
        {
            _settings.title = Title;
        }

        objectReference = DotNetObjectReference.Create(this);
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            // chartType, chartData, chartOptions, elementId, dotNetObjectReference, usedatatable, UseMaterialTheme
            await JSRuntime.InvokeVoidAsync("gcHistogramChart", DataTable is not null ? DataTable!.Build() : ObjectArray, _settings, id, objectReference, DataTable is not null ? true : false, null, false);
            StateHasChanged();
        }
    }
    public void Dispose() => objectReference?.Dispose();
}
