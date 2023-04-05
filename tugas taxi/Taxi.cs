using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugas_taxi
{
    internal class Taxi
    {
            public string DriverName { get; set; }
            public bool OnDuty { get; set; }
            public string NumPassanger { get; set; }

            public void TaxiInfo()
            {
                Console.WriteLine("Driver Name : {0}", DriverName);
                if (OnDuty == true)
                {
                    Console.WriteLine("On Duty : Yes");
                }
                if (OnDuty == false)
                {
                    Console.WriteLine("On Duty : No");
                }
                Console.WriteLine("Num Passanger : {0}", NumPassanger);
            }

            public void PickUpPassanger()
            {
                Console.WriteLine("{0} Sedang menjemput penumpang\n", DriverName);
            }

            public void DropOffPassanger()
            {
                Console.WriteLine("{0} Sedang menjemput penumpang\n", DriverName);
            }
        }
    }


