using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Motorcycle : Vehicle
    {
        public int Miles { get; set; }


        public override void DriveAbstract()
        {
            Console.WriteLine("The motocycle has two wheels");
        }
        public override void DriveVirtual()
        {
            Console.WriteLine("Vroom Vroom");
        }
    }
}
