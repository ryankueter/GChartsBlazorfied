/**
 * Author: Ryan A. Kueter
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 */
namespace GChartsBlazorfied;

//public class gcRow : List<gcCell> { }
public class gcRow
{
    private List<gcCell> _cells = new();
    internal List<gcCell> GetCells() => _cells;
    public void AddCell(object? v, string? f = null)
    {
        _cells.Add(new gcCell(v, f));
    }
}
