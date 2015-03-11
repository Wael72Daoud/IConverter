using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IConverter.Converters
{
    class Temp_Converters
    {


        #region celsius converters

        public static double celsius_TO_celsius(double units)
        {

            return (units * 1);
        }


        public static double celsius_TO_kelvin(double units)
        {
            return (units + 273);

        }

      
        public static double celsius_TO_fahrenheit(double units)
        {

            return (units * 1.8 + 32);
        }


        #endregion


        #region fahernheit converters

        public static double fahrenheit_TO_celsius(double units)
        {

            return ((units - 32)  * 0.55555555555556);
        }

        public static double Fahrenheit_TO_kelvin(double units)
        {
            return (.5555 * (units -32) + 273);
        }
        public static double Fahrenheit_TO_Fahrenheit(double units)
        {
            return (units * 1);
        }

        #endregion 

         

        #region kelvin
        public static double kelvin_TO_celsius(double units)
        {
            return (units -273);
        }

        public static double kelvin_TO_kelvin(double units)
        {
            return (units * 1);
        }

        public static double kelvin_TO_Fahrenheit(double units)
        {
            return ((units -273) * 1.8) + 32;
        }

        #endregion


    }
}
