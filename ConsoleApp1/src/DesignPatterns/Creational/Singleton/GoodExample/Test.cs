using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Creational.Singleton.GoodExample
{
    public class Test
    {
        public static void Run()
        {
            // Get the singleton instance
            var settings = AppSetting.GetInstance();
            Console.WriteLine(settings.Get("app_name")); // Output: My Application
        
        }
    }
}
