/**
 * Author: Ryan A. Kueter
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 */
namespace GChartsBlazorfied.Models;

public class gcFormatter
{
    public string? type { get; set; }
    public string? color { get; set; }
    public double? opacity { get; set; }
    public double? lineWidth { get; set; }
    public int? targetAxisIndex { get; set; }
    public int[]? lineDashStyle { get; set; }
    public bool? pointsVisible { get; set; }
    public double? offset { get; set; }
    public bool? visibleInLegend { get; set; }
    public int? degree { get; set; }
    public double? pointSize { get; set; }
    public string? labelInLegend { get; set; }
}
