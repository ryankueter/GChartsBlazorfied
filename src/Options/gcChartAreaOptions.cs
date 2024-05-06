/**
 * Author: Ryan A. Kueter
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 */
using GChartsBlazorfied.Models;
namespace GChartsBlazorfied.Options;

public class gcChartAreaOptions
{
	private gcChartArea _settings = new();
    internal gcChartArea ReturnSettings() => _settings;
	public string? left
	{
		set
		{
			_settings.left = value;
		}
	}
	public string? top
	{
		set
		{
			_settings.top = value;
		}
	}
	public string? width
	{
		set
		{
			_settings.width = value;
		}
	}
	public string? height
	{
		set
		{
			_settings.height = value;
		}
	}
	public void BackgroundColor(Action<gcBackgroundColor> backgroundColor)
	{
		var options = new gcBackgroundColor();
		if (backgroundColor is not null)
			backgroundColor(options);
		_settings.backgroundColor = options;
	}
}
