/**
 * Author: Ryan A. Kueter
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 */
namespace GChartsBlazorfied.Models;

public class gcTextStyle
{
    public string? fontName { get; set; }
    public int? fontSize { get; set; }
    public bool? bold { get; set; }
    public bool? italic { get; set; }
    public string? color { get; set; }
    public string? auraColor { get; set; }
    public double? opacity { get; set; } = 1;
}
