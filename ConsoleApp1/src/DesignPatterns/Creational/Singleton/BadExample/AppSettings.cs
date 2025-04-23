using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Creational.Singleton.BadExample
{
    public class AppSettings
    {
        private Dictionary<string, string> _settings = new Dictionary<string, string>();
        public object Get(string key)
        {
            if (_settings.ContainsKey(key))
            {
                return _settings[key];
            }
            else
            {
                throw new KeyNotFoundException($"Key '{key}' not found in settings.");
            }
        }

        public void Set(string key, string value)
        {
            _settings[key] = value;
      
        }
    }
}
