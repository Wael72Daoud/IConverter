using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IConverter.Converters
{
  
    public sealed class Converter_Data
    {


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<string> getListOfCategories()
        {
            List<string> categories_List = new List<string>();
            
            try
            {
                categories_List.Add(Resources.AppResources.Category_Length);
                categories_List.Add(Resources.AppResources.Category_Temperature);
                categories_List.Add(Resources.AppResources.Category_Area);
                categories_List.Add(Resources.AppResources.Category_Volume);
                categories_List.Add(Resources.AppResources.Category_Weight);
                categories_List.Add(Resources.AppResources.Category_Time);
                categories_List.Add(Resources.AppResources.Category_Currency);
            }
            catch (SystemException sysEx)
            {
                return null;
            }
            return categories_List;
        }



        public static IEnumerable<string> getListOfAreaItems()
        {

            List<string> AreaCategory_Items = new List<string>();

            try
            {
                AreaCategory_Items.Add(Resources.AppResources.UnitCenverer_Area_Acre);
                AreaCategory_Items.Add(Resources.AppResources.UnitCenverer_Area_SquareCentimeter);
                AreaCategory_Items.Add(Resources.AppResources.UnitCenverer_Area_SquareInch);
                AreaCategory_Items.Add(Resources.AppResources.UnitCenverer_Area_SquareKilometer);
                AreaCategory_Items.Add(Resources.AppResources.UnitCenverer_Area_SquareMeter);
                AreaCategory_Items.Add(Resources.AppResources.UnitCenverer_Area_SquareMicrometer);
                AreaCategory_Items.Add(Resources.AppResources.UnitCenverer_Area_SquareMile);
                AreaCategory_Items.Add(Resources.AppResources.UnitCenverer_Area_SquareMillimeter);
                AreaCategory_Items.Add(Resources.AppResources.UnitCenverer_Area_SquareYard);
                AreaCategory_Items.Add(Resources.AppResources.UnitCenverer_Area_SquareFoot);
              
            }
            catch (SystemException sysEx)
            {
                return null;
            }


            return AreaCategory_Items;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<string> getListOfLengthItems()
        {
            List<string> lenghtCategory_Items = new List<string>();
            try
            {

                lenghtCategory_Items.Add(Resources.AppResources.UnitConverter_Length_centimeter);
                lenghtCategory_Items.Add(Resources.AppResources.UnitConverter_Length_foot);
                lenghtCategory_Items.Add(Resources.AppResources.UnitConverter_Length_inch);
                lenghtCategory_Items.Add(Resources.AppResources.UnitConverter_Length_kilometer);
                lenghtCategory_Items.Add(Resources.AppResources.UnitConverter_Length_LightYear);
                lenghtCategory_Items.Add(Resources.AppResources.UnitConverter_Length_nanometer);
                lenghtCategory_Items.Add(Resources.AppResources.UnitConverter_Length_yard);
                lenghtCategory_Items.Add(Resources.AppResources.UnitConverter_Length_meter);
                lenghtCategory_Items.Add(Resources.AppResources.UnitConverter_Length_micrometer);
                lenghtCategory_Items.Add(Resources.AppResources.UnitConverter_Length_mile);
                lenghtCategory_Items.Add(Resources.AppResources.UnitConverter_Length_millimeter);
                

            }
            catch (SystemException sysEx)
            {
                return null;
            }

            return lenghtCategory_Items;
        }




        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<string> getListofTemperatureItems()
        {
            List<string> TemperatureCatergory_Items = new List<string>();

            try
            {
                TemperatureCatergory_Items.Add(Resources.AppResources.UnitConverter_Temperature_Celsius);
                TemperatureCatergory_Items.Add(Resources.AppResources.UnitConverter_Temperature_Farenheit);
                TemperatureCatergory_Items.Add(Resources.AppResources.UnitConverter_Temperature_Kelvin);

            }
            catch (SystemException sysEx)
            {
                return null;
            }

            return TemperatureCatergory_Items;

        }



        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<string> getListOfVolumeItems()
        {
            List<string> VolumeCategory_Items = new List<string>();

            try
            {
                VolumeCategory_Items.Add(Resources.AppResources.UnitConverter_Volume_Cubiccentimeter);
                VolumeCategory_Items.Add(Resources.AppResources.UnitConverter_Volume_Cubicmeter);
                VolumeCategory_Items.Add(Resources.AppResources.UnitConverter_Volume_Cubicfoot);
                VolumeCategory_Items.Add(Resources.AppResources.UnitConverter_Volume_Cubicinch);
                VolumeCategory_Items.Add(Resources.AppResources.UnitConverter_Volume_Cubickilometer);
                VolumeCategory_Items.Add(Resources.AppResources.UnitConverter_Volume_Cubicmile);
                VolumeCategory_Items.Add(Resources.AppResources.UnitConverter_Volume_Cubicmillimeter);
                VolumeCategory_Items.Add(Resources.AppResources.UnitConverter_Volume_Cubicyard);
                VolumeCategory_Items.Add(Resources.AppResources.UnitConverter_Volume_liter);
                VolumeCategory_Items.Add(Resources.AppResources.UnitConverter_Volume_milliliter);
                VolumeCategory_Items.Add(Resources.AppResources.UnitConverter_Volume_gallon);
                VolumeCategory_Items.Add(Resources.AppResources.UnitConverter_Volume_quart);
                VolumeCategory_Items.Add(Resources.AppResources.UnitConverter_Volume_pint);

            }
            catch (SystemException sysEX)
            {
                return null;
            }


            return VolumeCategory_Items;
        }




        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<string> getListOfWeightItems()
        {

            List<string> WeightCategory_Items = new List<string>();

            try
            {

                WeightCategory_Items.Add(Resources.AppResources.UnitConverter_Weight_atomicMassUnit);
                WeightCategory_Items.Add(Resources.AppResources.UnitConverter_Weight_carrat);
                WeightCategory_Items.Add(Resources.AppResources.UnitConverter_Weight_gram);
                WeightCategory_Items.Add(Resources.AppResources.UnitConverter_Weight_kilogram);
                WeightCategory_Items.Add(Resources.AppResources.UnitConverter_Weight_milligram);
                WeightCategory_Items.Add(Resources.AppResources.UnitConverter_Weight_ounce);
                WeightCategory_Items.Add(Resources.AppResources.UnitConverter_Weight_pound);
                WeightCategory_Items.Add(Resources.AppResources.UnitConverter_Weight_ton);

                
            }
            catch (SystemException sysex)
            {
                return null;
            }


            return WeightCategory_Items;
        }






        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<string> getListOfTimeItems()
        {

            List<string> TimeCategory_Items = new List<string>();

            try
            {

                TimeCategory_Items.Add(Resources.AppResources.UnitConverter_Time_day);
                TimeCategory_Items.Add(Resources.AppResources.UnitConverter_Time_hour);
                TimeCategory_Items.Add(Resources.AppResources.UnitConverter_Time_microsecond);
                TimeCategory_Items.Add(Resources.AppResources.UnitConverter_Time_millisecond);
                TimeCategory_Items.Add(Resources.AppResources.UnitConverter_Time_minute);
                TimeCategory_Items.Add(Resources.AppResources.UnitConverter_Time_month);
                TimeCategory_Items.Add(Resources.AppResources.UnitConverter_Time_nanosecond);
                TimeCategory_Items.Add(Resources.AppResources.UnitConverter_Time_picosecond);
                TimeCategory_Items.Add(Resources.AppResources.UnitConverter_Time_Second);
                TimeCategory_Items.Add(Resources.AppResources.UnitConverter_Time_week);
                TimeCategory_Items.Add(Resources.AppResources.UnitConverter_Time_year);

            }
            catch (SystemException sysex)
            {
                return null;
            }


            return TimeCategory_Items;
        }




        /// <summary>
        /// let of supported currencies
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<string> getListOfCurrencies()
        {

            CurrencyCol CurrCollectionData = new CurrencyCol();
            
            try
            {

                ICollection<Currency> CurrencyCategory_Items = CurrCollectionData.getSupportedCurrencies();
                //CurrencyCategory_Items.


            }
            catch (SystemException sysEx)
            {
                return null;
            }



            return null;

        }






    }



}
