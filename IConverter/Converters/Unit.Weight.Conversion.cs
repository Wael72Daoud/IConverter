using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IConverter.Converters
{
    class UnitWeight
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Convert_Left_From"></param>
        /// <param name="Convert_Right_To"></param>
        /// <param name="Category_Button"></param>
        /// <returns></returns>
        public double Convert(string Convert_Left_From, string Convert_Right_To, string Category_Button, double ConvertFrom)
        {

            if (IConverter.Resources.AppResources.Category_Weight.ToUpper() == Category_Button)
            {
                if (Convert_Left_From == IConverter.Resources.AppResources.UnitConverter_Weight_atomicMassUnit)
                {
                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Weight_atomicMassUnit)
                    {
                        return (Weight_Converters.atomicmassunit_TO_atomicmassunit(ConvertFrom));
                    }
                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Weight_carrat)
                    {
                        return (Weight_Converters.atomicmassunit_TO_carrat(ConvertFrom));
                    }
                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Weight_gram)
                    {
                        return (Weight_Converters.atomicmassunit_TO_gram(ConvertFrom));
                    }
                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Weight_kilogram)
                    {
                        return (Weight_Converters.atomicmassunit_TO_kilogram(ConvertFrom));
                    }
                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Weight_milligram)
                    {
                        return (Weight_Converters.atomicmassunit_TO_milligram(ConvertFrom));
                    }
                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Weight_ounce)
                    {
                        return (Weight_Converters.atomicmassunit_TO_ounce(ConvertFrom));
                    }
                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Weight_pound)
                    {
                        return (Weight_Converters.atomicmassunit_TO_pound(ConvertFrom));
                    }
                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Weight_ton)
                    {
                        return (Weight_Converters.atomicmassunit_TO_ton(ConvertFrom));
                    }
                }


                if (Convert_Left_From == IConverter.Resources.AppResources.UnitConverter_Weight_carrat)
                {
                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Weight_atomicMassUnit)
                    {
                        return (Weight_Converters.carrat_TO_atomicmassunit(ConvertFrom));
                    }
                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Weight_carrat)
                    {
                        return (Weight_Converters.carrat_TO_carrat(ConvertFrom));
                    }
                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Weight_gram)
                    {
                        return (Weight_Converters.carrat_TO_gram(ConvertFrom));
                    }
                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Weight_kilogram)
                    {
                        return (Weight_Converters.carrat_TO_kilogram(ConvertFrom));
                    }
                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Weight_milligram)
                    {
                        return (Weight_Converters.carrat_TO_milligram(ConvertFrom));
                    }
                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Weight_ounce)
                    {
                        return (Weight_Converters.carrat_TO_ounce(ConvertFrom));
                    }
                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Weight_pound)
                    {
                        return (Weight_Converters.carrat_TO_pound(ConvertFrom));
                    }
                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Weight_ton)
                    {
                        return (Weight_Converters.carrat_TO_ton(ConvertFrom));
                    }
                }



                if (Convert_Left_From == IConverter.Resources.AppResources.UnitConverter_Weight_gram)
                {
                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Weight_atomicMassUnit)
                    {
                        return (Weight_Converters.gram_TO_atomicmassunit(ConvertFrom));
                    }
                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Weight_carrat)
                    {
                        return (Weight_Converters.gram_TO_carrat(ConvertFrom));
                    }
                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Weight_gram)
                    {
                        return (Weight_Converters.gram_TO_gram(ConvertFrom));
                    }
                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Weight_kilogram)
                    {
                        return (Weight_Converters.gram_TO_kilogram(ConvertFrom));
                    }
                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Weight_milligram)
                    {
                        return (Weight_Converters.gram_TO_milligram(ConvertFrom));
                    }
                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Weight_ounce)
                    {
                        return (Weight_Converters.gram_TO_ounce(ConvertFrom));
                    }
                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Weight_pound)
                    {
                        return (Weight_Converters.gram_TO_pound(ConvertFrom));
                    }
                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Weight_ton)
                    {
                        return (Weight_Converters.gram_TO_ton(ConvertFrom));
                    }
                }


                if (Convert_Left_From == IConverter.Resources.AppResources.UnitConverter_Weight_kilogram)
                {
                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Weight_atomicMassUnit)
                    {
                        return (Weight_Converters.kilogram_TO_atomicmassunit(ConvertFrom));
                    }
                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Weight_carrat)
                    {
                        return (Weight_Converters.kilogram_TO_carrat(ConvertFrom));
                    }
                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Weight_gram)
                    {
                        return (Weight_Converters.kilogram_TO_gram(ConvertFrom));
                    }
                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Weight_kilogram)
                    {
                        return (Weight_Converters.kilogram_TO_kilogram(ConvertFrom));
                    }
                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Weight_milligram)
                    {
                        return (Weight_Converters.kilogram_TO_milligram(ConvertFrom));
                    }
                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Weight_ounce)
                    {
                        return (Weight_Converters.kilogram_TO_ounce(ConvertFrom));
                    }
                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Weight_pound)
                    {
                        return (Weight_Converters.kilogram_TO_pound(ConvertFrom));
                    }
                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Weight_ton)
                    {
                        return (Weight_Converters.kilogram_TO_ton(ConvertFrom));
                    }
                }



                if (Convert_Left_From == IConverter.Resources.AppResources.UnitConverter_Weight_milligram)
                {
                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Weight_atomicMassUnit)
                    {
                        return (Weight_Converters.milligram_TO_atomicmassunit(ConvertFrom));
                    }
                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Weight_carrat)
                    {
                        return (Weight_Converters.milligram_TO_carrat(ConvertFrom));
                    }
                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Weight_gram)
                    {
                        return (Weight_Converters.milligram_TO_gram(ConvertFrom));
                    }
                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Weight_kilogram)
                    {
                        return (Weight_Converters.milligram_TO_kilogram(ConvertFrom));
                    }
                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Weight_milligram)
                    {
                        return (Weight_Converters.milligram_TO_milligram(ConvertFrom));
                    }
                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Weight_ounce)
                    {
                        return (Weight_Converters.milligram_TO_ounce(ConvertFrom));
                    }
                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Weight_pound)
                    {
                        return (Weight_Converters.milligram_TO_pound(ConvertFrom));
                    }
                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Weight_ton)
                    {
                        return (Weight_Converters.milligram_TO_ton(ConvertFrom));
                    }
                }



                if (Convert_Left_From == IConverter.Resources.AppResources.UnitConverter_Weight_ounce)
                {
                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Weight_atomicMassUnit)
                    {
                        return (Weight_Converters.ounce_TO_atomicmassunit(ConvertFrom));
                    }
                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Weight_carrat)
                    {
                        return (Weight_Converters.ounce_TO_carrat(ConvertFrom));
                    }
                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Weight_gram)
                    {
                        return (Weight_Converters.ounce_TO_gram(ConvertFrom));
                    }
                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Weight_kilogram)
                    {
                        return (Weight_Converters.ounce_TO_kilogram(ConvertFrom));
                    }
                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Weight_milligram)
                    {
                        return (Weight_Converters.ounce_TO_milligram(ConvertFrom));
                    }
                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Weight_ounce)
                    {
                        return (Weight_Converters.ounce_TO_ounce(ConvertFrom));
                    }
                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Weight_pound)
                    {
                        return (Weight_Converters.ounce_TO_pound(ConvertFrom));
                    }
                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Weight_ton)
                    {
                        return (Weight_Converters.ounce_TO_ton(ConvertFrom));
                    }
                }



                if (Convert_Left_From == IConverter.Resources.AppResources.UnitConverter_Weight_pound)
                {
                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Weight_atomicMassUnit)
                    {
                        return (Weight_Converters.pound_TO_atomicmassunit(ConvertFrom));
                    }
                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Weight_carrat)
                    {
                        return (Weight_Converters.pound_TO_carrat(ConvertFrom));
                    }
                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Weight_gram)
                    {
                        return (Weight_Converters.pound_TO_gram(ConvertFrom));
                    }
                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Weight_kilogram)
                    {
                        return (Weight_Converters.pound_TO_kilogram(ConvertFrom));
                    }
                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Weight_milligram)
                    {
                        return (Weight_Converters.pound_TO_milligram(ConvertFrom));
                    }
                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Weight_ounce)
                    {
                        return (Weight_Converters.pound_TO_ounce(ConvertFrom));
                    }
                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Weight_pound)
                    {
                        return (Weight_Converters.pound_TO_pound(ConvertFrom));
                    }
                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Weight_ton)
                    {
                        return (Weight_Converters.pound_TO_ton(ConvertFrom));
                    }
                }



                if (Convert_Left_From == IConverter.Resources.AppResources.UnitConverter_Weight_ton)
                {
                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Weight_atomicMassUnit)
                    {
                        return (Weight_Converters.ton_TO_atomicmassunit(ConvertFrom));
                    }
                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Weight_carrat)
                    {
                        return (Weight_Converters.ton_TO_carrat(ConvertFrom));
                    }
                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Weight_gram)
                    {
                        return (Weight_Converters.ton_TO_gram(ConvertFrom));
                    }
                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Weight_kilogram)
                    {
                        return (Weight_Converters.ton_TO_kilogram(ConvertFrom));
                    }
                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Weight_milligram)
                    {
                        return (Weight_Converters.ton_TO_milligram(ConvertFrom));
                    }
                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Weight_ounce)
                    {
                        return (Weight_Converters.ton_TO_ounce(ConvertFrom));
                    }
                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Weight_pound)
                    {
                        return (Weight_Converters.ton_TO_pound(ConvertFrom));
                    }
                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Weight_ton)
                    {
                        return (Weight_Converters.ton_TO_ton(ConvertFrom));
                    }
                }

            }

            return 0.0;
        }
    }
}
