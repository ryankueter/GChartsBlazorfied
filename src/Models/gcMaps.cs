/**
 * Author: Ryan A. Kueter
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 */
using GChartsBlazorfied.Options;
using GChartsBlazorfied.Models;
namespace GChartsBlazorfied.Models;

public class gcMaps
{
    public gcMaps AddMap(string name, Action<gcMapOptions> map)
    {
        var options = new gcMapOptions();
        if (map is not null)
            map(options);

        _maps.Add(name, options.ReturnSettings());
        return this;
    }
    private Dictionary<string, gcMap> _maps { get; set; } = new();
    internal Dictionary<string, gcMap> GetMaps() => _maps;
}
