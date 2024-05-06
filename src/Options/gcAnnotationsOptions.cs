/**
 * Author: Ryan A. Kueter
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 */
using GChartsBlazorfied.Models;
namespace GChartsBlazorfied.Options;

public class gcAnnotationsOptions
{
    private gcAnnotations _settings = new();
    internal gcAnnotations ReturnSettings() => _settings;
    public bool alwaysOutside
    {
        set
        {
            _settings.alwaysOutside = value;
        }
    }
    public void BoxStyle(Action<gcBoxStyleOptions> boxStyle)
    {
        var options = new gcBoxStyleOptions();
        if (boxStyle is not null)
            boxStyle(options);
        _settings.boxStyle = options.ReturnSettings();
    }
    public void Datum(Action<gcDatumOptions> datum)
    {
        var options = new gcDatumOptions();
        if (datum is not null)
            datum(options);
        _settings.datum = options.ReturnSettings();
    }
    public void Domain(Action<gcDomainOptions> domain)
    {
        var options = new gcDomainOptions();
        if (domain is not null)
            domain(options);
        _settings.domain = options.ReturnSettings();
    }
    public bool highContrast
    {
        set
        {
            _settings.highContrast = value;
        }
    }
    public void Stem(Action<gcStem> stem)
    {
        var options = new gcStem();
        if (stem is not null)
            stem(options);
        _settings.stem = options;
    }
    public string style
    {
        set
        {
            _settings.style = value;
        }
    }
    public void TextStyle(Action<gcTextStyle> style)
    {
        var options = new gcTextStyle();
        if (style is not null)
            style(options);
        _settings.textStyle = options;
    }
}
