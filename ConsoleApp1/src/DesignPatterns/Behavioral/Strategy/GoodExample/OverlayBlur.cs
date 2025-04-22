using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Behavioral.Strategy.GoodExample
{
    class OverlayBlur : IOverlay
    {
        public void Apply()
        {
            Console.WriteLine("Applying blur overlay");
        }
    }
}
