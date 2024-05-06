/**
 * Author: Ryan A. Kueter
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 */
using GChartsBlazorfied.Models;
namespace GChartsBlazorfied.Options;

public class gcMinorGridlinesOptions
{
	private gcMinorGridlines _settings = new();
    internal gcMinorGridlines ReturnSettings() => _settings;
	public string? color
	{
		set
		{
			_settings.color = value;
		}
	}
	public int? count
	{
		set
		{
			_settings.count = value;
		}
	}
	public double? interval
	{
		set
		{
			_settings.interval = value;
		}
	}
	public double? minSpacing
	{
		set
		{
			_settings.minSpacing = value;
		}
	}
	public double? multiple
	{
		set
		{
			_settings.multiple = value;
		}
	}
	public void Units(Action<gcUnits> units)
	{
		var options = new gcUnits();
		if (units is not null)
			units(options);
		_settings.units = options;
	}
}
