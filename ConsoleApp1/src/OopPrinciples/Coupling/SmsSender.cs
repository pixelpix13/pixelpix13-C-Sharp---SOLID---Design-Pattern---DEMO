using ConsoleApp1.Coupling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.src.OopPrinciples.Coupling
{
    class SmsSender : INotificationService
    {
        public void SendNotification(string message)
        {
            // SMS sending logic
            Console.WriteLine($"Sending SMS: {message}, message from the SmsSender Class");
        }
    }
}
