using GChartsBlazorfied.Models;
namespace GChartsBlazorfied.Options
{
    public class gcColumnOptions
    {
        private gcColumn _settings = new();
        internal gcColumn ReturnOptions() => _settings;
        public string? id
        {
            set
            {
                _settings.id = value;
            }
        }
        public string? label
        {
            set
            {
                _settings.label = value;
            }
        }
        public string? type
        {
            set
            {
                _settings.type = value;
            }
        }
        public string? role
        {
            set
            {
                _settings.role = value;
            }
        }

        public void P(Action<gcP> p)
        {
            var options = new gcP();
            if (p is not null)
                p(options);
            _settings.p = options;
        }
        public string? pattern
        {
            set
            {
                _settings.pattern = value;
            }
        }
    }
}
