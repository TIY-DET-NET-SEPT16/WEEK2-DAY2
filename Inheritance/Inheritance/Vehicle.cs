using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Vehicle
    {
        #region variables
        private string model;
        private bool isRunning;
        private int numberWheels;

        #endregion

        public Vehicle()
        {
        }

        #region Properties

        public string Model
        {
            get
            {
                return model;
            }

            set
            {
                model = value;
            }
        }

        public bool StartStopVehicle
        {
            set
            {
                if (!isRunning && value == false)
                {
                    isRunning = true;
                }
                else if (isRunning && value == false)
                {
                    isRunning = false;
                }
            }
        }

        public bool IsRunning
        {
            get
            {
                return isRunning;
            }
        }

        public int NumberWheels
        {
            get
            {
                return numberWheels;
            }

            set
            {
                numberWheels = value;
            }
        }

        #endregion

        #region  methods

        #endregion
    }
}
