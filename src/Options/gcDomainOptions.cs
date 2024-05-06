/**
 * Author: Ryan A. Kueter
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 */
using GChartsBlazorfied.Models;
namespace GChartsBlazorfied.Options;

public class gcDomainOptions
{
	private gcDomain _settings = new();
    internal gcDomain ReturnSettings() => _settings;
	public string? style
	{
		set
		{
			_settings.style = value;
		}
	}
	public void Stem(Action<gcStem> stem)
	{
		var options = new gcStem();
		if (stem is not null)
			stem(options);
		_settings.stem = options;
	}
}
