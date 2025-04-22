using ConsoleApp1.SOLID.D.BetterExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.src.SOLID.D.BetterExample
{
    class ElectricEngine : IEngine
    {
        public void Start()
        {
            System.Console.WriteLine("Electric engine started.");
        }
    }
}
