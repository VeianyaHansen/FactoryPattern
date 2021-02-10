using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class Motorcycle : IVehicle
    {
        public Motorcycle()
        {
        }

        public void Drive()
        {
            ConsoleLogger.VehicleStartUpDialogue();
            Console.WriteLine("The Motorcycle is revving up");
            Console.WriteLine("vroom");
        }

    }        
}
