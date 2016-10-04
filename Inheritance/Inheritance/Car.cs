using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Car : Vehicle
    {
        #region variables;

        private int numberDoors;
        private bool doorsOpen = false;
        private bool windowsTinted = false;
        private int numberWindows;

        #endregion

        public Car()
        {
            base.NumberWheels = 4;
        }

        #region Properties

        public int NumberDoors
        {
            get
            {
                return numberDoors;
            }

            set
            {
                numberDoors = value;
            }
        }

        public bool DoorsOpen
        {
            get
            {
                return doorsOpen;
            }
        }

        public bool OpenCloseDoors
        {
            set
            {
                if (doorsOpen)
                {
                    doorsOpen = false;
                }
                else
                {
                    doorsOpen = true;
                }
            }
        }

        public bool WindowsTinted
        {
            get
            {
                return windowsTinted;
            }

            set
            {
                windowsTinted = value;
            }
        }

        #endregion

        #region Methods



        #endregion
    }
}
