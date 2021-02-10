using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class ThreeWheeler : IVehicle
    {
        public ThreeWheeler()
        {
        }

        public void Drive()
        {
            ConsoleLogger.VehicleStartUpDialogue();
            Console.WriteLine("Let's get going");
        }

    }    
}
