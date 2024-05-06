/**
 * Author: Ryan A. Kueter
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 */
using GChartsBlazorfied.Models;
namespace GChartsBlazorfied.Options;

public class gcCrosshairOptions
{
	private gcCrosshair _settings = new();
    internal gcCrosshair ReturnSettings() => _settings;
	public string? color
	{
		set
		{
			_settings.color = value;
		}
	}
	public void Focused(Action<gcFocused> focused)
	{
		var options = new gcFocused();
		if (focused is not null)
			focused(options);
		_settings.focused = options;
	}
	public double? opacity
	{
		set
		{
			_settings.opacity = value;
		}
	}
	public string? orientation
	{
		set
		{
			_settings.orientation = value;
		}
	}
	public void Selected(Action<gcSelected> selected)
	{
		var options = new gcSelected();
		if (selected is not null)
			selected(options);
		_settings.selected = options;
	}
	public string? trigger
	{
		set
		{
			_settings.trigger = value;
		}
	}
}
