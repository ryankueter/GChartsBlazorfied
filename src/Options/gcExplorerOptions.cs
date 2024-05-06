/**
 * Author: Ryan A. Kueter
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 */
using GChartsBlazorfied.Models;
namespace GChartsBlazorfied.Options;

public class gcExplorerOptions
{
    private gcExplorer _settings = new();
    internal gcExplorer ReturnSettings() => _settings;
    public void actions(params string[] colors)
    {
        _settings.actions = colors;
    }
    public string? axis
    {
        set
        {
            _settings.axis = value;
        }
    }
    public bool? keepInBounds
    {
        set
        {
            _settings.keepInBounds = value;
        }
    }
    public double? maxZoomIn
    {
        set
        {
            _settings.maxZoomIn = value;
        }
    }
    public double? maxZoomOut
    {
        set
        {
            _settings.maxZoomOut = value;
        }
    }
    public double? zoomDelta
    {
        set
        {
            _settings.zoomDelta = value;
        }
    }
}
