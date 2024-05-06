/**
 * Author: Ryan A. Kueter
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 */
namespace GChartsBlazorfied.Models;

public class gcHistogram
{
    public double? lastBucketPercentile { get; set; }
    public double? bucketSize { get; set; }
    public double? maxNumBuckets { get; set; }
    public double? minValue { get; set; }
    public double? maxValue { get; set; }
    public bool? hideBucketItems { get; set; }
    public string? numBucketsRule { get; set; } = gcNumBucketsRuleType.Sturges;
}
