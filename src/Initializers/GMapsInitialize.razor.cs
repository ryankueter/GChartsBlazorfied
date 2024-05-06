using Microsoft.AspNetCore.Components;

namespace GChartsBlazorfied;

public partial class GMapsInitialize
{
    [Parameter]
    public string? ApiKey { get; set; }
    [Parameter]
    public string? Language { get; set; } = "en";
    private string? src { get; set; }
    protected override void OnInitialized()
    {
        if (ApiKey is null)
            throw new ArgumentNullException("An Api Key is required to use Google Maps.", nameof(ApiKey));

        src = $@"https://maps.googleapis.com/maps/api/js?key={ApiKey}&libraries=drawing&language={Language}";
    }
}
