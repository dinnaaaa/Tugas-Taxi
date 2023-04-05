using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tugas_taxi;

namespace Tugas1
{
    public class program
    {
        static void Main(string[] args)
        {
            Taxi taxi = new Taxi();

            taxi.DriverName = "Jono";
            taxi.OnDuty = true;
            taxi.NumPassanger = "10";

            taxi.TaxiInfo();
            taxi.PickUpPassanger();
            taxi.DropOffPassanger();

            Console.ReadKey();
        }
    }
}