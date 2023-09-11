/**
 * Author: Ryan A. Kueter
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 */
namespace GChartsBlazorfied;

public class gcFormatters
{
    private int _index;
    public gcFormatters AddFormatter(object formatter)
    {
        _formatters.Add(_index.ToString(), formatter);
        _index++;
        return this;
    }
    public gcFormatters AddFormatter(string index, object formatter)
    {
        _formatters.Add(index, formatter);
        return this;
    }
    private Dictionary<string, object> _formatters { get; set; } = new();
    public Dictionary<string, object> GetFormatters() => _formatters;
}
