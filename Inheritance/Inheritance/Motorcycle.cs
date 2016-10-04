using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Motorcycle : Vehicle
    {
        public Motorcycle()
        {
            base.NumberWheels = 2;
        }
    }
}
