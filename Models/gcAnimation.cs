/**
 * Author: Ryan A. Kueter
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 */
namespace GChartsBlazorfied;

public class gcAnimation
{
    public int duration { get; set; }
    public string? easing { get; set; } = gcAnimationEasingType.Linear;
    public bool startup { get; set; }
}
