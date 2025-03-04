using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcunMedyaOdev3__3_4_5__CihanKurtbey
{
    class Car:IElectricPowered,IFuelPowered
    {
        public string Model { get; set; }

        public Car(string model)
        {
            Model = model;
        }

        // IFuelPowered interface'inden implementasyon
        public void Refuel()
        {
            if (Model == "Audi") 
            { 
                Console.WriteLine($"{Model} is being refueled with gasoline.");
            }
            
        }

        // IElectricPowered interface'inden implementasyon
        public void Recharge()
        {
            if (Model == "Tesla")
            { 
                Console.WriteLine($"{Model} is being recharged with electricity.");
            }
            
        }
    }
}
