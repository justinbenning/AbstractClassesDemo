using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Car : Vehicle
    {
        public string Color { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine("Default abstract drive");
        }
    }
}
