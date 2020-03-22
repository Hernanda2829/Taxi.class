using System;

namespace TugasClassDanObject
{
    class Program
    {   
        static void Main(string[] args)
        {
            Taxi taxi = new Taxi();

            taxi.DriveName = "Giri";
            taxi.OnDuty = true;
            taxi.NumPassenger = 10;

            taxi.TaxiInfo();
            Console.WriteLine("\n");
            taxi.PickUpPassenger();
            taxi.DropOfPassenger();

            Console.ReadKey();
        }
    }
}