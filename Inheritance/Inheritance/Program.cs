using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();

            //Console.WriteLine(myCar.IsRunning);
            //myCar.StartVehicle = true;
            //Console.WriteLine(myCar.IsRunning);
            //myCar.StopVehicle = true;
            //Console.WriteLine(myCar.IsRunning);
            //Console.WriteLine(myCar.NumberWheels);

            Motorcycle myMC = new Motorcycle();
            Console.WriteLine(myMC.IsRunning);
            myMC.StartStopVehicle = true;

            Console.WriteLine(myMC.IsRunning);
            myMC.StartStopVehicle = false;

            Console.WriteLine(myMC.IsRunning);
            Console.WriteLine(myMC.NumberWheels);

            string newSent = Utils.RemoveSpaces("This is the thing I want to remove all the spaces from");
            Console.WriteLine(newSent);

            Console.ReadLine();
        }
    }
}
