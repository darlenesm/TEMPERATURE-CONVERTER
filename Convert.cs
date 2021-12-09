using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operations
{
    public class Convert
    {
        

        //Celsius convertion
        public static double convertionCtoK(double a)
        {
            return a + 273.15;
        }
        public static double convertionCtoF(double a)
        {
            return (a * 9 / 5) + 32;
        }

        //Kelvin Convertion
        public static double convertionKtoC(double a)
        {
            return a - 273.15;
        }
        public static double convertionKtoF(double a)
        {
            return (a - 273.15) * 9/5 + 32;
        }

        //Fahrenheit convertion
        public static double convertionFtoC(double a)
        {
            return (a - 32) * 5 / 9;
        }
        public static double convertionFtoK(double a)
        {
            return (a - 32) * 5 / 9 + 273.15;
        }


    }
}
