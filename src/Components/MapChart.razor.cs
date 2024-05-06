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

public partial class MapChart
{
	/// <summary>
	/// Element Id
	/// </summary>
	private string id = Guid.NewGuid().ToString();

	[Inject]
	private IJSRuntime JSRuntime { get; set; } = null!;

	[Parameter]
	public string? Style { get; set; }
	[Parameter]
	public IEnumerable<object>? ObjectArray { get; set; }

	[Parameter]
	public gcDataTableBuilder? DataTable { get; set; }

	[Parameter]
	public Action<MapChartOptions>? Options { get; set; }
	private MapChartOptions? _options { get; set; } = new();
	private MapSettings? _settings { get; set; } = new();

    #region Click Event
    private DotNetObjectReference<MapChart>? objectReference;

    [Parameter]
    public EventCallback<gcClickEventArgs> OnClick { get; set; }

    [JSInvokable]
    public void ClickEvent(int rowIndex, int colIndex) => OnClick.InvokeAsync(new gcClickEventArgs { row = rowIndex, column = colIndex });
    #endregion

    protected override void OnInitialized()
    {
        if (GChartsSettings.ApiKey is null)
        {
            throw new Exception("The api key is missing. The <GMapsInitialize /> tag may need to be added with the Api key and language.");
        }

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
            // chartType, chartData, chartOptions, elementId, dotNetObjectReference, usedatatable, ApiKey, UseMaterialTheme
            await JSRuntime.InvokeVoidAsync("gcMapChart", DataTable is not null ? DataTable!.Build() : ObjectArray, _settings, id, objectReference, DataTable is not null ? true : false, GChartsSettings.ApiKey, false);
            StateHasChanged();
        }
    }

    public void Dispose() => objectReference?.Dispose();
}
