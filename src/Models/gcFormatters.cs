/**
 * Author: Ryan A. Kueter
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 */
using GChartsBlazorfied.Options;
namespace GChartsBlazorfied.Models;

public class gcFormatters
{
    private int _index;
    public gcFormatters AddFormatter(Action<gcFormatterOptions> formatter)
    {
        var options = new gcFormatterOptions();
        if (formatter is not null)
            formatter(options);

        _formatters.Add(_index.ToString(), options.ReturnSettings());
        _index++;
        return this;
    }
    public gcFormatters AddFormatter(string index, Action<gcFormatterOptions> formatter)
    {
        var options = new gcFormatterOptions();
        if (formatter is not null)
            formatter(options);

        _formatters.Add(index, options.ReturnSettings());
        return this;
    }
    private Dictionary<string, object> _formatters { get; set; } = new();
    internal Dictionary<string, object> GetFormatters() => _formatters;
}
