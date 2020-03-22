using System;

namespace TugasClassDanObject
{
    public class Taxi
    {
        //property
        public string DriveName { get; set; }
        public bool OnDuty { get; set; }
        public int NumPassenger { get; set; }

        //method
        public void TaxiInfo()
        {
            Console.WriteLine("Driver Name: {0}", DriveName);
            if (OnDuty)
            {
                Console.WriteLine("On Duty: Yes");
            }
            else
            {
                Console.WriteLine("On Duty : No");
            }
            Console.WriteLine("Number Of Passenger: {0}", NumPassenger);
        }
        public void PickUpPassenger()
        {
            if (OnDuty)
            {
                Console.WriteLine("DriveName : {0} sedang menjemput penumpang", DriveName);
            }
            else
            {
                Console.WriteLine("DriveName: {0} tidak sedang menjemput penumpang", DriveName);
            }

        }
        public void DropOfPassenger()
        {
            if (OnDuty)
            {
                Console.Write("DriveName: {0} selesai mengantar penumpang", DriveName);
            }
            else
            {
                Console.Write("DriveName: {0} tidak sedang mengantar penumpang", DriveName);
            }

        }
    }
}
