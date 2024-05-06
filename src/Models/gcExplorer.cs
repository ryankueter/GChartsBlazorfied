/**
 * Author: Ryan A. Kueter
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 */
namespace GChartsBlazorfied.Models;

public class gcExplorer
{
    public string[]? actions { get; set; }
    public string? axis { get; set; }
    public bool? keepInBounds { get; set; }
    public double? maxZoomIn { get; set; }
    public double? maxZoomOut { get; set; }
    public double? zoomDelta { get; set; }
}
