/**
 * Author: Ryan A. Kueter
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 */
using System.ComponentModel.DataAnnotations;

namespace GChartsBlazorfied;

public class gcAxis
{
    public string? title { get; set; }
    public gcTextStyle? titleTextStyle { get; set; }
    public gcTextStyle? textStyle { get; set; }
    public int minValue { get; set; }
    public int maxValue { get; set; }
    public string? format { get; set; }
    public int direction { get; set; } = 1;
    public bool slantedText { get; set; }

    [Range(-90, 90)]
    public int slantedTextAngle { get; set; }
    public double? baseline { get; set; }
    public string? baselineColor { get; set; }
    public gcViewWindow? viewWindow { get; set; }
    public gcGridlines? gridlines { get; set; }
    public gcMinorGridlines? minorGridlines { get; set; }
    public bool logScale { get; set; }
    public string? scaleType { get; set; }
    public string? textPosition { get; set; }
    public List<object>? ticks { get; set; }
    public bool allowContainerBoundaryTextCutoff { get; set; }
    public double? maxAlternation { get; set; }
    public double? maxTextLines { get; set; }
    public double? minTextSpacing { get; set; }
    public double? showTextEvery { get; set; }
    public string? viewWindowMode { get; set; }
}
