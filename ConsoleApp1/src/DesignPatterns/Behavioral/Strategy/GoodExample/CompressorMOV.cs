using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Behavioral.Strategy.GoodExample
{
    class CompressorMOV : ICompressor
    {
        public void Compress()
        {
            Console.WriteLine("Compressing using MOV");
        }
    }
}
