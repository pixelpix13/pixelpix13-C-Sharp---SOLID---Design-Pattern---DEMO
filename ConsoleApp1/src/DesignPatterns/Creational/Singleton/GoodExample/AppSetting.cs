using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Creational.Singleton.GoodExample
{
    //here class is sealed to prevent inheritance because if we inherit this class and create an instance of the derived class, it will not be a singleton anymore.
    public class AppSetting
    {
        private static AppSetting _instance;
        private Dictionary<string, object> _settings = new Dictionary<string, object>();

        private AppSetting()
        {
            //private constructor to prevent instantiation from outside the class.
            //we can initialize default settings here if needed.
        }

        public static AppSetting GetInstance()
        {
            if (_instance == null)
            {
                //when we call this method for the first time, we create a new instance of the AppSetting class.
                _instance = new AppSetting();
            }
            //after the first call, we return the same instance of the AppSetting class.
            return _instance;
        }
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
