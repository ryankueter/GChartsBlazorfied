/**
 * Author: Ryan A. Kueter
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 */
using GChartsBlazorfied.Options;
namespace GChartsBlazorfied.Models;

public class gcMapStyles
{
    public gcMapStyles AddMapStyle(Action<gcMapStyleOptions> style)
    {
        var options = new gcMapStyleOptions();
        if (style is not null)
            style(options);

        _styles.Add(options.ReturnSettings());
        return this;
    }
    private List<gcMapStyle> _styles { get; set; } = new();
    internal gcMapStyle[] GetStyles() => _styles.ToArray();
}
