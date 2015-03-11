using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IConverter.Converters
{
    class UnitTemp
    {


        /// <summary>
        /// 
        /// </summary>
        /// <param name="Convert_Left_From"></param>
        /// <param name="Convert_Right_To"></param>
        /// <returns></returns>
        public double Convert(string Convert_Left_From, string Convert_Right_To, string Category_Button,double ConvertFrom)
        {


            if (IConverter.Resources.AppResources.Category_Temperature.ToUpper() == Category_Button)
            {
                if (Convert_Left_From == IConverter.Resources.AppResources.UnitConverter_Temperature_Celsius)
                {
                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Temperature_Celsius)
                    {
                        return Temp_Converters.celsius_TO_celsius(ConvertFrom);
                    }
                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Temperature_Farenheit)
                    {
                        return Temp_Converters.celsius_TO_fahrenheit(ConvertFrom);
                    }
                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Temperature_Kelvin)
                    {
                        return Temp_Converters.celsius_TO_kelvin(ConvertFrom);
                    }
                }



                if (Convert_Left_From == IConverter.Resources.AppResources.UnitConverter_Temperature_Farenheit)
                {
                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Temperature_Celsius)
                    {
                        return Temp_Converters.fahrenheit_TO_celsius(ConvertFrom);
                    }
                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Temperature_Farenheit)
                    {
                        return Temp_Converters.Fahrenheit_TO_Fahrenheit(ConvertFrom);
                    }
                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Temperature_Kelvin)
                    {
                        return Temp_Converters.Fahrenheit_TO_kelvin(ConvertFrom);
                    }
                }



                if (Convert_Left_From == IConverter.Resources.AppResources.UnitConverter_Temperature_Kelvin)
                {
                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Temperature_Celsius)
                    {
                        return Temp_Converters.kelvin_TO_celsius(ConvertFrom);
                    }
                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Temperature_Farenheit)
                    {
                        return Temp_Converters.kelvin_TO_Fahrenheit(ConvertFrom);
                    }
                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Temperature_Kelvin)
                    {
                        return Temp_Converters.kelvin_TO_kelvin(ConvertFrom);
                    }
                }




            }


            return 0.0;
        }
    }
}
