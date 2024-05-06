/**
 * Author: Ryan A. Kueter
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 */
namespace GChartsBlazorfied.Models;

public class gcCrosshair
{
    public string? color { get; set; }
    public gcFocused? focused { get; set; }
    public double? opacity { get; set; }
    public string? orientation { get; set; }
    public gcSelected? selected { get; set; }
    public string? trigger { get; set; }
}
