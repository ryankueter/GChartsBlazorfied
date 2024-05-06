/**
 * Author: Ryan A. Kueter
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 */
namespace GChartsBlazorfied.Models;

public class gcTooltip
{
    public bool isHtml { get; set; }

    /// <summary>
    /// trigger = "selection" starts an action when an item is clicked (not currently enabled). 
    /// trigger = "both" keeps a tooptip open when clicked. 
    /// </summary>
    public string? trigger { get; set; } = "focus";
    public bool showColorCode { get; set; }
    public bool ignoreBounds { get; set; }
    public gcTextStyle? textStyle { get; set; }
}
