/**
 * Author: Ryan A. Kueter
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 */
namespace GChartsBlazorfied.Models;

public class gcIcons
{
    public gcIcons AddIcon(Action<gcIcon> icon)
    {
        var options = new gcIcon();
        if (icon is not null)
            icon(options);

        _icons.Add(options);
        return this;
    }
    private List<gcIcon> _icons { get; set; } = new();
    internal gcIcon[] GetFormatters() => _icons.ToArray();
}
