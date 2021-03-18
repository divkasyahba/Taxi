using System;

namespace Class_object
{
    class Program
    {
        static void Main(string[] args)
        {
            taxi taxi = new taxi();

            taxi.DriverName = "tukiman";
            taxi.OnDuty = true;
            taxi.NumPassanger = 77;

            taxi.TaxiInfo();
            taxi.PickUpPassanger();
            taxi.DropOfPassanger();

            Console.ReadKey();
        }
}
