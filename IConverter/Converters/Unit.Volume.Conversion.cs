using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IConverter.Converters
{
    class UnitVolume
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


            #region CubicMeter
            if (IConverter.Resources.AppResources.UnitConverter_Volume_Cubicmeter == Convert_Left_From)
            {

                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_Cubiccentimeter)
                {
                    return (Volume_Converters.cubicmeter_TO_cubiccentimeter(ConvertFrom));
                }

                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_Cubicfoot)
                {
                    return (Volume_Converters.cubicmeter_TO_cubicfoot(ConvertFrom));
                }
                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_Cubicinch)
                {
                    return (Volume_Converters.cubicmeter_TO_cubicinch(ConvertFrom));
                }

                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_Cubickilometer)
                {
                    return (Volume_Converters.cubicmeter_TO_cubickilometer(ConvertFrom));
                }

                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_Cubicmeter)
                {
                    return (Volume_Converters.cubicmeter_TO_cubicmeter(ConvertFrom));
                }

                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_Cubicmile)
                {
                    return (Volume_Converters.cubicmeter_TO_cubicmile(ConvertFrom));
                }

                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_Cubicmillimeter)
                {
                    return (Volume_Converters.cubicmeter_TO_cubicmillimeter(ConvertFrom));
                }

                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_Cubicyard)
                {
                    return (Volume_Converters.cubicmeter_TO_cubicyard(ConvertFrom));
                }
                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_gallon)
                {
                    return (Volume_Converters.cubicmeter_TO_gallon(ConvertFrom));
                }

                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_liter)
                {
                    return (Volume_Converters.cubicmeter_TO_liter(ConvertFrom));
                }
                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_milliliter)
                {
                    return (Volume_Converters.cubicmeter_TO_milliliter(ConvertFrom));
                }
                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_pint)
                {
                    return (Volume_Converters.cubicmeter_TO_pint(ConvertFrom));
                }
                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_quart)
                {
                    return (Volume_Converters.cubicmeter_TO_quart(ConvertFrom));
                }

            }
            #endregion


            #region cubicfoot

            if (IConverter.Resources.AppResources.UnitConverter_Volume_Cubicfoot == Convert_Left_From)
            {

                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_Cubiccentimeter)
                {
                    return (Volume_Converters.cubicfoot_TO_cubiccentimeter(ConvertFrom));
                }

                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_Cubicfoot)
                {
                    return (Volume_Converters.cubicfoot_TO_cubicfoot(ConvertFrom));
                }
                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_Cubicinch)
                {
                    return (Volume_Converters.cubicfoot_TO_cubicinch(ConvertFrom));
                }

                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_Cubickilometer)
                {
                    return (Volume_Converters.cubicfoot_TO_cubickilometer(ConvertFrom));
                }

                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_Cubicmeter)
                {
                    return (Volume_Converters.cubicfoot_TO_cubicmeter(ConvertFrom));
                }

                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_Cubicmile)
                {
                    return (Volume_Converters.cubicfoot_TO_cubicmile(ConvertFrom));
                }

                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_Cubicmillimeter)
                {
                    return (Volume_Converters.cubicfoot_TO_cubicmillimeter(ConvertFrom));
                }

                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_Cubicyard)
                {
                    return (Volume_Converters.cubicfoot_TO_cubicyard(ConvertFrom));
                }
                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_gallon)
                {
                    return (Volume_Converters.cubicfoot_TO_gallon(ConvertFrom));
                }

                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_liter)
                {
                    return (Volume_Converters.cubicfoot_TO_liter(ConvertFrom));
                }
                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_milliliter)
                {
                    return (Volume_Converters.cubicfoot_TO_milliliter(ConvertFrom));
                }
                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_pint)
                {
                    return (Volume_Converters.cubicfoot_TO_pint(ConvertFrom));
                }
                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_quart)
                {
                    return (Volume_Converters.cubicfoot_TO_quart(ConvertFrom));
                }

            }


            #endregion


            #region cubicyard

            if (IConverter.Resources.AppResources.UnitConverter_Volume_Cubicyard == Convert_Left_From)
            {

                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_Cubiccentimeter)
                {
                    return (Volume_Converters.cubicyard_TO_cubiccentimeter(ConvertFrom));
                }

                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_Cubicyard)
                {
                    return (Volume_Converters.cubicyard_TO_cubicyard(ConvertFrom));
                }

                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_Cubicfoot)
                {
                    return (Volume_Converters.cubicyard_TO_cubicfoot(ConvertFrom));
                }
                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_Cubicinch)
                {
                    return (Volume_Converters.cubicyard_TO_cubicinch(ConvertFrom));
                }

                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_Cubickilometer)
                {
                    return (Volume_Converters.cubicyard_TO_cubickilometer(ConvertFrom));
                }

                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_Cubicmeter)
                {
                    return (Volume_Converters.cubicyard_TO_cubicmeter(ConvertFrom));
                }

                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_Cubicmile)
                {
                    return (Volume_Converters.cubicyard_TO_cubicmile(ConvertFrom));
                }

                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_Cubicmillimeter)
                {
                    return (Volume_Converters.cubicyard_TO_cubicmillimeter(ConvertFrom));
                }

                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_Cubicyard)
                {
                    return (Volume_Converters.cubicyard_TO_cubicyard(ConvertFrom));
                }
                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_gallon)
                {
                    return (Volume_Converters.cubicyard_TO_gallon(ConvertFrom));
                }

                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_liter)
                {
                    return (Volume_Converters.cubicyard_TO_liter(ConvertFrom));
                }
                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_milliliter)
                {
                    return (Volume_Converters.cubicyard_TO_milliliter(ConvertFrom));
                }
                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_pint)
                {
                    return (Volume_Converters.cubicyard_TO_pint(ConvertFrom));
                }
                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_quart)
                {
                    return (Volume_Converters.cubicyard_TO_quart(ConvertFrom));
                }

            }

            #endregion


            #region cubicinch

            if (IConverter.Resources.AppResources.UnitConverter_Volume_Cubicinch == Convert_Left_From)
            {

                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_Cubiccentimeter)
                {
                    return (Volume_Converters.cubicinch_TO_cubiccentimeter(ConvertFrom));
                }

                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_Cubicfoot)
                {
                    return (Volume_Converters.cubicinch_TO_cubicfoot(ConvertFrom));
                }
                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_Cubicinch)
                {
                    return (Volume_Converters.cubicinch_TO_cubicinch(ConvertFrom));
                }

                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_Cubickilometer)
                {
                    return (Volume_Converters.cubicinch_TO_cubickilometer(ConvertFrom));
                }

                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_Cubicmeter)
                {
                    return (Volume_Converters.cubicinch_TO_cubicmeter(ConvertFrom));
                }

                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_Cubicmile)
                {
                    return (Volume_Converters.cubicinch_TO_cubicmile(ConvertFrom));
                }

                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_Cubicmillimeter)
                {
                    return (Volume_Converters.cubicinch_TO_cubicmillimeter(ConvertFrom));
                }

                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_Cubicyard)
                {
                    return (Volume_Converters.cubicinch_TO_cubicyard(ConvertFrom));
                }
                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_gallon)
                {
                    return (Volume_Converters.cubicinch_TO_gallon(ConvertFrom));
                }

                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_liter)
                {
                    return (Volume_Converters.cubicinch_TO_liter(ConvertFrom));
                }
                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_milliliter)
                {
                    return (Volume_Converters.cubicinch_TO_milliliter(ConvertFrom));
                }
                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_pint)
                {
                    return (Volume_Converters.cubicinch_TO_pint(ConvertFrom));
                }
                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_quart)
                {
                    return (Volume_Converters.cubicinch_TO_quart(ConvertFrom));
                }

            }


            #endregion


            #region cubickilometer

            if (IConverter.Resources.AppResources.UnitConverter_Volume_Cubickilometer == Convert_Left_From)
            {

                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_Cubiccentimeter)
                {
                    return (Volume_Converters.cubickilometer_TO_cubiccentimeter(ConvertFrom));
                }

                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_Cubicfoot)
                {
                    return (Volume_Converters.cubickilometer_TO_cubicfoot(ConvertFrom));
                }
                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_Cubicinch)
                {
                    return (Volume_Converters.cubickilometer_TO_cubicinch(ConvertFrom));
                }

                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_Cubickilometer)
                {
                    return (Volume_Converters.cubickilometer_TO_cubickilometer(ConvertFrom));
                }

                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_Cubicmeter)
                {
                    return (Volume_Converters.cubickilometer_TO_cubicmeter(ConvertFrom));
                }

                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_Cubicmile)
                {
                    return (Volume_Converters.cubickilometer_TO_cubicmile(ConvertFrom));
                }

                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_Cubicmillimeter)
                {
                    return (Volume_Converters.cubickilometer_TO_cubicmillimeter(ConvertFrom));
                }

                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_Cubicyard)
                {
                    return (Volume_Converters.cubickilometer_TO_cubicyard(ConvertFrom));
                }
                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_gallon)
                {
                    return (Volume_Converters.cubickilometer_TO_gallon(ConvertFrom));
                }

                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_liter)
                {
                    return (Volume_Converters.cubickilometer_TO_liter(ConvertFrom));
                }
                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_milliliter)
                {
                    return (Volume_Converters.cubickilometer_TO_milliliter(ConvertFrom));
                }
                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_pint)
                {
                    return (Volume_Converters.cubickilometer_TO_pint(ConvertFrom));
                }
                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_quart)
                {
                    return (Volume_Converters.cubickilometer_TO_quart(ConvertFrom));
                }

            }


            #endregion


            #region cubicmile

            if (IConverter.Resources.AppResources.UnitConverter_Volume_Cubicmile == Convert_Left_From)
            {

                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_Cubiccentimeter)
                {
                    return (Volume_Converters.cubicmile_TO_cubiccentimeter(ConvertFrom));
                }

                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_Cubicfoot)
                {
                    return (Volume_Converters.cubicmile_TO_cubicfoot(ConvertFrom));
                }
                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_Cubicinch)
                {
                    return (Volume_Converters.cubicmile_TO_cubicinch(ConvertFrom));
                }

                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_Cubickilometer)
                {
                    return (Volume_Converters.cubicmile_TO_cubickilometer(ConvertFrom));
                }

                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_Cubicmeter)
                {
                    return (Volume_Converters.cubicmile_TO_cubicmeter(ConvertFrom));
                }

                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_Cubicmile)
                {
                    return (Volume_Converters.cubicmile_TO_cubicmile(ConvertFrom));
                }

                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_Cubicmillimeter)
                {
                    return (Volume_Converters.cubicmile_TO_cubicmillimeter(ConvertFrom));
                }

                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_Cubicyard)
                {
                    return (Volume_Converters.cubicmile_TO_cubicyard(ConvertFrom));
                }
                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_gallon)
                {
                    return (Volume_Converters.cubicmile_TO_gallon(ConvertFrom));
                }

                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_liter)
                {
                    return (Volume_Converters.cubicmile_TO_liter(ConvertFrom));
                }
                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_milliliter)
                {
                    return (Volume_Converters.cubicmile_TO_milliliter(ConvertFrom));
                }
                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_pint)
                {
                    return (Volume_Converters.cubicmile_TO_pint(ConvertFrom));
                }
                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_quart)
                {
                    return (Volume_Converters.cubicmile_TO_quart(ConvertFrom));
                }

            }

            #endregion


            #region cubiccentimeter

            if (IConverter.Resources.AppResources.UnitConverter_Volume_Cubiccentimeter == Convert_Left_From)
            {

                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_Cubiccentimeter)
                {
                    return (Volume_Converters.cubiccentimeter_TO_cubiccentimeter(ConvertFrom));
                }

                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_Cubicfoot)
                {
                    return (Volume_Converters.cubiccentimeter_TO_cubicfoot(ConvertFrom));
                }
                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_Cubicinch)
                {
                    return (Volume_Converters.cubiccentimeter_TO_cubicinch(ConvertFrom));
                }

                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_Cubickilometer)
                {
                    return (Volume_Converters.cubiccentimeter_TO_cubickilometer(ConvertFrom));
                }

                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_Cubicmeter)
                {
                    return (Volume_Converters.cubiccentimeter_TO_cubicmeter(ConvertFrom));
                }

                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_Cubicmile)
                {
                    return (Volume_Converters.cubiccentimeter_TO_cubicmile(ConvertFrom));
                }

                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_Cubicmillimeter)
                {
                    return (Volume_Converters.cubiccentimeter_TO_cubicmillimeter(ConvertFrom));
                }

                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_Cubicyard)
                {
                    return (Volume_Converters.cubiccentimeter_TO_cubicyard(ConvertFrom));
                }
                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_gallon)
                {
                    return (Volume_Converters.cubiccentimeter_TO_gallon(ConvertFrom));
                }

                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_liter)
                {
                    return (Volume_Converters.cubiccentimeter_TO_liter(ConvertFrom));
                }
                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_milliliter)
                {
                    return (Volume_Converters.cubicmeter_TO_milliliter(ConvertFrom));
                }
                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_pint)
                {
                    return (Volume_Converters.cubiccentimeter_TO_pint(ConvertFrom));
                }
                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_quart)
                {
                    return (Volume_Converters.cubiccentimeter_TO_quart(ConvertFrom));
                }

            }


            #endregion


            #region cubicmillimeter

            if (IConverter.Resources.AppResources.UnitConverter_Volume_Cubicmillimeter == Convert_Left_From)
            {

                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_Cubicmillimeter)
                {
                    return (Volume_Converters.cubicmillimeter_TO_cubiccentimeter(ConvertFrom));
                }

                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_Cubicfoot)
                {
                    return (Volume_Converters.cubicmillimeter_TO_cubicfoot(ConvertFrom));
                }
                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_Cubicinch)
                {
                    return (Volume_Converters.cubicmillimeter_TO_cubicinch(ConvertFrom));
                }

                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_Cubickilometer)
                {
                    return (Volume_Converters.cubicmillimeter_TO_cubickilometer(ConvertFrom));
                }

                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_Cubicmeter)
                {
                    return (Volume_Converters.cubicmillimeter_TO_cubicmeter(ConvertFrom));
                }

                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_Cubicmile)
                {
                    return (Volume_Converters.cubicmillimeter_TO_cubicmile(ConvertFrom));
                }

                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_Cubicmillimeter)
                {
                    return (Volume_Converters.cubicmillimeter_TO_cubicmillimeter(ConvertFrom));
                }

                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_Cubicyard)
                {
                    return (Volume_Converters.cubicmillimeter_TO_cubicyard(ConvertFrom));
                }
                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_gallon)
                {
                    return (Volume_Converters.cubicmillimeter_TO_gallon(ConvertFrom));
                }

                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_liter)
                {
                    return (Volume_Converters.cubicmillimeter_TO_liter(ConvertFrom));
                }
                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_milliliter)
                {
                    return (Volume_Converters.cubicmillimeter_TO_milliliter(ConvertFrom));
                }
                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_pint)
                {
                    return (Volume_Converters.cubicmillimeter_TO_pint(ConvertFrom));
                }
                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_quart)
                {
                    return (Volume_Converters.cubicmillimeter_TO_quart(ConvertFrom));
                }

            }



            #endregion


            #region liter

            if (IConverter.Resources.AppResources.UnitConverter_Volume_liter == Convert_Left_From)
            {

                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_liter)
                {
                    return (Volume_Converters.liter_TO_cubiccentimeter(ConvertFrom));
                }

                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_Cubicfoot)
                {
                    return (Volume_Converters.liter_TO_cubicfoot(ConvertFrom));
                }
                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_Cubicinch)
                {
                    return (Volume_Converters.liter_TO_cubicinch(ConvertFrom));
                }

                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_Cubickilometer)
                {
                    return (Volume_Converters.liter_TO_cubickilometer(ConvertFrom));
                }

                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_Cubicmeter)
                {
                    return (Volume_Converters.liter_TO_cubicmeter(ConvertFrom));
                }

                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_Cubicmile)
                {
                    return (Volume_Converters.liter_TO_cubicmile(ConvertFrom));
                }

                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_Cubicmillimeter)
                {
                    return (Volume_Converters.liter_TO_cubicmillimeter(ConvertFrom));
                }

                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_Cubicyard)
                {
                    return (Volume_Converters.liter_TO_cubicyard(ConvertFrom));
                }
                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_gallon)
                {
                    return (Volume_Converters.liter_TO_gallon(ConvertFrom));
                }

                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_liter)
                {
                    return (Volume_Converters.liter_TO_liter(ConvertFrom));
                }
                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_milliliter)
                {
                    return (Volume_Converters.liter_TO_milliliter(ConvertFrom));
                }
                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_pint)
                {
                    return (Volume_Converters.liter_TO_pint(ConvertFrom));
                }
                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_quart)
                {
                    return (Volume_Converters.liter_TO_quart(ConvertFrom));
                }

            }


            #endregion


            #region millileter


            if (IConverter.Resources.AppResources.UnitConverter_Volume_milliliter == Convert_Left_From)
            {

                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_milliliter)
                {
                    return (Volume_Converters.milliliter_TO_cubiccentimeter(ConvertFrom));
                }

                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_Cubicfoot)
                {
                    return (Volume_Converters.milliliter_TO_cubicfoot(ConvertFrom));
                }
                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_Cubicinch)
                {
                    return (Volume_Converters.milliliter_TO_cubicinch(ConvertFrom));
                }

                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_Cubickilometer)
                {
                    return (Volume_Converters.milliliter_TO_cubickilometer(ConvertFrom));
                }

                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_Cubicmeter)
                {
                    return (Volume_Converters.milliliter_TO_cubicmeter(ConvertFrom));
                }

                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_Cubicmile)
                {
                    return (Volume_Converters.milliliter_TO_cubicmile(ConvertFrom));
                }

                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_Cubicmillimeter)
                {
                    return (Volume_Converters.milliliter_TO_cubicmillimeter(ConvertFrom));
                }

                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_Cubicyard)
                {
                    return (Volume_Converters.milliliter_TO_cubicyard(ConvertFrom));
                }
                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_gallon)
                {
                    return (Volume_Converters.milliliter_TO_gallon(ConvertFrom));
                }

                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_liter)
                {
                    return (Volume_Converters.milliliter_TO_liter(ConvertFrom));
                }
                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_milliliter)
                {
                    return (Volume_Converters.milliliter_TO_milliliter(ConvertFrom));
                }
                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_pint)
                {
                    return (Volume_Converters.milliliter_TO_pint(ConvertFrom));
                }
                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_quart)
                {
                    return (Volume_Converters.milliliter_TO_quart(ConvertFrom));
                }

            }


            #endregion



            #region pint


            if (IConverter.Resources.AppResources.UnitConverter_Volume_pint == Convert_Left_From)
            {

                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_pint)
                {
                    return (Volume_Converters.pint_TO_cubiccentimeter(ConvertFrom));
                }

                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_Cubicfoot)
                {
                    return (Volume_Converters.pint_TO_cubicfoot(ConvertFrom));
                }
                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_Cubicinch)
                {
                    return (Volume_Converters.pint_TO_cubicinch(ConvertFrom));
                }

                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_Cubickilometer)
                {
                    return (Volume_Converters.pint_TO_cubickilometer(ConvertFrom));
                }

                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_Cubicmeter)
                {
                    return (Volume_Converters.pint_TO_cubicmeter(ConvertFrom));
                }

                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_Cubicmile)
                {
                    return (Volume_Converters.pint_TO_cubicmile(ConvertFrom));
                }

                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_Cubicmillimeter)
                {
                    return (Volume_Converters.pint_TO_cubicmillimeter(ConvertFrom));
                }

                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_Cubicyard)
                {
                    return (Volume_Converters.pint_TO_cubicyard(ConvertFrom));
                }
                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_gallon)
                {
                    return (Volume_Converters.pint_TO_gallon(ConvertFrom));
                }

                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_liter)
                {
                    return (Volume_Converters.pint_TO_liter(ConvertFrom));
                }
                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_milliliter)
                {
                    return (Volume_Converters.pint_TO_milliliter(ConvertFrom));
                }
                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_pint)
                {
                    return (Volume_Converters.pint_TO_pint(ConvertFrom));
                }
                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_quart)
                {
                    return (Volume_Converters.pint_TO_quart(ConvertFrom));
                }

            }


            #endregion


            #region quart



            if (IConverter.Resources.AppResources.UnitConverter_Volume_quart == Convert_Left_From)
            {

                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_liter)
                {
                    return (Volume_Converters.quart_TO_cubiccentimeter(ConvertFrom));
                }

                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_Cubicfoot)
                {
                    return (Volume_Converters.quart_TO_cubicfoot(ConvertFrom));
                }
                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_Cubicinch)
                {
                    return (Volume_Converters.quart_TO_cubicinch(ConvertFrom));
                }

                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_Cubickilometer)
                {
                    return (Volume_Converters.quart_TO_cubickilometer(ConvertFrom));
                }

                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_Cubicmeter)
                {
                    return (Volume_Converters.quart_TO_cubicmeter(ConvertFrom));
                }

                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_Cubicmile)
                {
                    return (Volume_Converters.quart_TO_cubicmile(ConvertFrom));
                }

                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_Cubicmillimeter)
                {
                    return (Volume_Converters.quart_TO_cubicmillimeter(ConvertFrom));
                }

                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_Cubicyard)
                {
                    return (Volume_Converters.quart_TO_cubicyard(ConvertFrom));
                }
                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_gallon)
                {
                    return (Volume_Converters.quart_TO_gallon(ConvertFrom));
                }

                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_liter)
                {
                    return (Volume_Converters.quart_TO_liter(ConvertFrom));
                }
                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_milliliter)
                {
                    return (Volume_Converters.quart_TO_milliliter(ConvertFrom));
                }
                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_pint)
                {
                    return (Volume_Converters.quart_TO_pint(ConvertFrom));
                }
                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_quart)
                {
                    return (Volume_Converters.quart_TO_quart(ConvertFrom));
                }

            }



            #endregion


            #region gallon



            if (IConverter.Resources.AppResources.UnitConverter_Volume_gallon == Convert_Left_From)
            {

                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_liter)
                {
                    return (Volume_Converters.gallon_TO_cubiccentimeter(ConvertFrom));
                }

                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_Cubicfoot)
                {
                    return (Volume_Converters.gallon_TO_cubicfoot(ConvertFrom));
                }
                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_Cubicinch)
                {
                    return (Volume_Converters.gallon_TO_cubicinch(ConvertFrom));
                }

                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_Cubickilometer)
                {
                    return (Volume_Converters.gallon_TO_cubickilometer(ConvertFrom));
                }

                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_Cubicmeter)
                {
                    return (Volume_Converters.gallon_TO_cubicmeter(ConvertFrom));
                }

                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_Cubicmile)
                {
                    return (Volume_Converters.gallon_TO_cubicmile(ConvertFrom));
                }

                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_Cubicmillimeter)
                {
                    return (Volume_Converters.gallon_TO_cubicmillimeter(ConvertFrom));
                }

                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_Cubicyard)
                {
                    return (Volume_Converters.gallon_TO_cubicyard(ConvertFrom));
                }
                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_gallon)
                {
                    return (Volume_Converters.gallon_TO_gallon(ConvertFrom));
                }

                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_liter)
                {
                    return (Volume_Converters.gallon_TO_liter(ConvertFrom));
                }
                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_milliliter)
                {
                    return (Volume_Converters.gallon_TO_milliliter(ConvertFrom));
                }
                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_pint)
                {
                    return (Volume_Converters.gallon_TO_pint(ConvertFrom));
                }
                if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Volume_quart)
                {
                    return (Volume_Converters.gallon_TO_quart(ConvertFrom));
                }

            }



            #endregion

            return 0.0;
        }
    }
}
