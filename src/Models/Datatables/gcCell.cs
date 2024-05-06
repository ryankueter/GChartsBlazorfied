/**
 * Author: Ryan A. Kueter
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 */
namespace GChartsBlazorfied;

public class gcCell
{
    public object? v { get; init; }
    public string? f { get; init; }
    public gcCell(object? v, string? f = null)
    {
        this.v = v;
        this.f = f;
    }
}
