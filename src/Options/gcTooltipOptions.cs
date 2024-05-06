/**
 * Author: Ryan A. Kueter
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 */
using GChartsBlazorfied.Models;
namespace GChartsBlazorfied.Options;

public class gcTooltipOptions
{
	private gcTooltip _settings = new();
    internal gcTooltip ReturnSettings() => _settings;
	public bool isHtml
	{
		set
		{
			_settings.isHtml = value;
		}
	}
	/// <summary>
	/// trigger = "selection" starts an action when an item is clicked (not currently enabled). 
	/// trigger = "both" keeps a tooptip open when clicked. 
	/// </summary>
	public string? trigger
	{
		set
		{
			_settings.trigger = value;
		}
	}
	public bool showColorCode
	{
		set
		{
			_settings.showColorCode = value;
		}
	}
	public bool ignoreBounds
	{
		set
		{
			_settings.ignoreBounds = value;
		}
	}
	public void TextStyle(Action<gcTextStyle> textStyle)
	{
		var options = new gcTextStyle();
		if (textStyle is not null)
			textStyle(options);
		_settings.textStyle = options;
	}
}
