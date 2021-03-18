using System;
using System.Collections.Generic;
using System.Text;

namespace Class_object
{
    class Taxi
    {
        public string DriverName { get; set; }
        public Boolean OnDuty { get; set; }
        public int NumPassanger { get; set; }

        public void TaxiInfo()
        {
            Console.WriteLine("Driver Name : {0}", DriverName);

            if (OnDuty == true)
            {
                Console.WriteLine("On Duty : yes", OnDuty);
            }
            else
            {
                Console.WriteLine("On Duty : no", OnDuty);
            }
            Console.WriteLine("Number of Passanger : {0}", NumPassanger);

        }
        public void PickUpPassanger()
        {
            Console.WriteLine("{0} sedang menjemput penumpang", DriverName);
        }
        public void DropOfPassanger()
        {
            Console.WriteLine("{0} selesai mengantar penumpang", DriverName);



        }
    }
  
  
    }
    