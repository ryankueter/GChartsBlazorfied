/**
 * Author: Ryan A. Kueter
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 */
namespace GChartsBlazorfied.Options;
using GChartsBlazorfied.Models;

public class gcBoxStyleOptions
{
	private gcBoxStyle _settings = new();
    internal gcBoxStyle ReturnSettings() => _settings;
	public string? stroke
	{
		set
		{
			_settings.stroke = value;
		}
	}
	public double? strokeWidth
	{
		set
		{
			_settings.strokeWidth = value;
		}
	}
	public double? rx
	{
		set
		{
			_settings.rx = value;
		}
	}
	public double? ry
	{
		set
		{
			_settings.ry = value;
		}
	}
	public void Gradient(Action<gcGradient> gradient)
	{
		var options = new gcGradient();
		if (gradient is not null)
			gradient(options);
		_settings.gradient = options;
	}
}
