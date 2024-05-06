/**
 * Author: Ryan A. Kueter
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 */
using GChartsBlazorfied.Models;
namespace GChartsBlazorfied.Options;

public class gcLegendOptions
{
    private gcLegend _settings = new();
    internal gcLegend ReturnSettings() => _settings;
    public string? position
    {
        set
        {
            _settings.position = value;
        }
    }
    public void TextStyle(Action<gcTextStyle> style)
    {
        var options = new gcTextStyle();
        if (style is not null)
            style(options);
        _settings.textStyle = options;
    }
    public string? alignment
    {
        set
        {
            _settings.alignment = value;
        }
    }
    public int? maxLines
    {
        set
        {
            _settings.maxLines = value;
        }
    }
    public int? pageIndex
    {
        set
        {
            _settings.pageIndex = value;
        }
    }
}
