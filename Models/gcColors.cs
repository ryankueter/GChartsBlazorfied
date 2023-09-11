/**
 * Author: Ryan A. Kueter
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 */
namespace GChartsBlazorfied;

public class gcColors
{
    private string[] _colors;
    public gcColors(params string[] colors)
    {
        _colors = colors;
    }
    public string[] GetColors()
    {
        return _colors;
    }
}
