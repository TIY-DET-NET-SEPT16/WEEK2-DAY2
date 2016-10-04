using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public static class Utils
    {
        public static string RemoveSpaces(string startingSent)
        {
            string returnValue = "";

            returnValue = startingSent.Replace(" ", "");

            return returnValue;
        }
    }
}
