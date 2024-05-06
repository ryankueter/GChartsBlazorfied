/**
 * Author: Ryan A. Kueter
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 */
namespace GChartsBlazorfied.Options;
using GChartsBlazorfied.Models;

public class gcFormatterOptions
{
    private gcFormatter _settings = new();
    internal gcFormatter ReturnSettings() => _settings;
    public string? type
    {
        set
        {
            _settings.type = value;
        }
    }
    public string? color
    {
        set
        {
            _settings.color = value;
        }
    }
    public double? opacity
    {
        set
        {
            _settings.opacity = value;
        }
    }
    public double? lineWidth
    {
        set
        {
            _settings.lineWidth = value;
        }
    }
    public int? targetAxisIndex
    {
        set
        {
            _settings.targetAxisIndex = value;
        }
    }
    public void lineDashStyle(params int[] styles)
    {
        _settings.lineDashStyle = styles;
    }
    public bool? pointsVisible
    {
        set
        {
            _settings.pointsVisible = value;
        }
    }
    public double? offset
    {
        set
        {
            _settings.offset = value;
        }
    }
    public bool? visibleInLegend
    {
        set
        {
            _settings.visibleInLegend = value;
        }
    }
    public int? degree
    {
        set
        {
            _settings.degree = value;
        }
    }
    public double? pointSize
    {
        set
        {
            _settings.pointSize = value;
        }
    }
    public string? labelInLegend
    {
        set
        {
            _settings.labelInLegend = value;
        }
    }
}
