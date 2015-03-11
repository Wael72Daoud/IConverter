using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IConverter.Converters
{
    class UnitLength
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



            if (IConverter.Resources.AppResources.Category_Length.ToUpper() == Category_Button)
            {

                #region Length --> centimeter

                if (Convert_Left_From == IConverter.Resources.AppResources.UnitConverter_Length_centimeter)
                {
                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_centimeter)
                    {
                        return (ConvertFrom);
                    }
                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_foot)
                    {
                        return (Length_Converters.centimeter_TO_foot(ConvertFrom));
                    }

                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_inch)
                    {
                        return (Length_Converters.centimeter_TO_inch(ConvertFrom));
                    }

                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_kilometer)
                    {
                        return (Length_Converters.centimeter_TO_kilometer(ConvertFrom));
                    }

                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_LightYear)
                    {
                        return (Length_Converters.centimeter_TO_lightyear(ConvertFrom));
                    }
                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_meter)
                    {
                        return (Length_Converters.centimeter_TO_meter(ConvertFrom));
                    }
                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_micrometer)
                    {
                        return (Length_Converters.centimeter_TO_micrometer(ConvertFrom));
                    }

                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_mile)
                    {
                        return (Length_Converters.centimeter_TO_mile(ConvertFrom));
                    }

                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_millimeter)
                    {
                        return (Length_Converters.centimeter_TO_millimeter(ConvertFrom));
                    }

                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_nanometer)
                    {
                        return (Length_Converters.centimeter_TO_nanometer(ConvertFrom));
                    }

                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_yard)
                    {
                        return (Length_Converters.centimeter_TO_yard(ConvertFrom));
                    }

                }

                #endregion

                #region Length --> foot

                if (Convert_Left_From == IConverter.Resources.AppResources.UnitConverter_Length_foot)
                {
                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_centimeter)
                    {
                        return ( Length_Converters.foot_TO_centimeter(ConvertFrom));
                    }
                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_foot)
                    {
                        return (Length_Converters.foot_TO_foot(ConvertFrom));
                    }

                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_inch)
                    {
                        return (Length_Converters.foot_TO_inch(ConvertFrom));
                    }

                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_kilometer)
                    {
                        return (Length_Converters.foot_TO_kilometer(ConvertFrom));
                    }

                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_LightYear)
                    {
                        return (Length_Converters.foot_TO_lightyear(ConvertFrom));
                    }
                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_meter)
                    {
                        return (Length_Converters.foot_TO_meter(ConvertFrom));
                    }
                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_micrometer)
                    {
                        return (Length_Converters.foot_TO_micrometer(ConvertFrom));
                    }

                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_mile)
                    {
                        return (Length_Converters.foot_TO_mile(ConvertFrom));
                    }

                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_millimeter)
                    {
                        return (Length_Converters.foot_TO_millimeter(ConvertFrom));
                    }

                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_nanometer)
                    {
                        return (Length_Converters.foot_TO_nanometer(ConvertFrom));
                    }

                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_yard)
                    {
                        return (Length_Converters.foot_TO_yard(ConvertFrom));
                    }

                }

                
                #endregion


                #region Length --> inch

                if (Convert_Left_From == IConverter.Resources.AppResources.UnitConverter_Length_inch)
                {
                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_centimeter)
                    {
                        return (Length_Converters.inch_TO_centimeter(ConvertFrom));
                    }
                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_foot)
                    {
                        return (Length_Converters.inch_TO_foot(ConvertFrom));
                    }

                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_inch)
                    {
                        return (Length_Converters.inch_TO_inch(ConvertFrom));
                    }

                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_kilometer)
                    {
                        return (Length_Converters.inch_TO_kilometer(ConvertFrom));
                    }

                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_LightYear)
                    {
                        return (Length_Converters.inch_TO_lightyear(ConvertFrom));
                    }
                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_meter)
                    {
                        return (Length_Converters.inch_TO_meter(ConvertFrom));
                    }
                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_micrometer)
                    {
                        return (Length_Converters.inch_TO_micrometer(ConvertFrom));
                    }

                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_mile)
                    {
                        return (Length_Converters.inch_TO_mile(ConvertFrom));
                    }

                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_millimeter)
                    {
                        return (Length_Converters.inch_TO_millimeter(ConvertFrom));
                    }

                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_nanometer)
                    {
                        return (Length_Converters.inch_TO_nanometer(ConvertFrom));
                    }

                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_yard)
                    {
                        return (Length_Converters.inch_TO_yard(ConvertFrom));
                    }

                }
                #endregion


                #region Length --> kilometer

                if (Convert_Left_From == IConverter.Resources.AppResources.UnitConverter_Length_kilometer)
                {
                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_centimeter)
                    {
                        return (Length_Converters.kilometer_TO_centimeter(ConvertFrom));
                    }
                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_foot)
                    {
                        return (Length_Converters.kilometer_TO_foot(ConvertFrom));
                    }

                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_inch)
                    {
                        return (Length_Converters.kilometer_TO_inch(ConvertFrom));
                    }

                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_kilometer)
                    {
                        return (Length_Converters.kilometer_TO_kilometer(ConvertFrom));
                    }

                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_LightYear)
                    {
                        return (Length_Converters.kilometer_TO_lightyear(ConvertFrom));
                    }
                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_meter)
                    {
                        return (Length_Converters.kilometer_TO_meter(ConvertFrom));
                    }
                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_micrometer)
                    {
                        return (Length_Converters.kilometer_TO_micrometer(ConvertFrom));
                    }

                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_mile)
                    {
                        return (Length_Converters.kilometer_TO_mile(ConvertFrom));
                    }

                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_millimeter)
                    {
                        return (Length_Converters.kilometer_TO_millimeter(ConvertFrom));
                    }

                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_nanometer)
                    {
                        return (Length_Converters.kilometer_TO_nanometer(ConvertFrom));
                    }

                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_yard)
                    {
                        return (Length_Converters.kilometer_TO_yard(ConvertFrom));
                    }

                }
                #endregion

                #region Length -->  meter

                if (Convert_Left_From == IConverter.Resources.AppResources.UnitConverter_Length_meter)
                {
                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_centimeter)
                    {
                        return (Length_Converters.meter_TO_centimeter(ConvertFrom));
                    }
                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_foot)
                    {
                        return (Length_Converters.meter_TO_foot(ConvertFrom));
                    }

                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_inch)
                    {
                        return (Length_Converters.meter_TO_inch(ConvertFrom));
                    }

                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_kilometer)
                    {
                        return (Length_Converters.meter_TO_kilometer(ConvertFrom));
                    }

                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_LightYear)
                    {
                        return (Length_Converters.meter_TO_lightyear(ConvertFrom));
                    }
                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_meter)
                    {
                        return (Length_Converters.meter_TO_meter(ConvertFrom));
                    }
                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_micrometer)
                    {
                        return (Length_Converters.meter_TO_micrometer(ConvertFrom));
                    }

                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_mile)
                    {
                        return (Length_Converters.meter_TO_mile(ConvertFrom));
                    }

                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_millimeter)
                    {
                        return (Length_Converters.meter_TO_millimeter(ConvertFrom));
                    }

                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_nanometer)
                    {
                        return (Length_Converters.meter_TO_nanometer(ConvertFrom));
                    }

                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_yard)
                    {
                        return (Length_Converters.meter_TO_yard(ConvertFrom));
                    }

                }


                #endregion

                #region Length --> mile

                if (Convert_Left_From == IConverter.Resources.AppResources.UnitConverter_Length_mile)
                {
                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_meter)
                    {
                        return (Length_Converters.mile_TO_meter(ConvertFrom));
                    }
                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_foot)
                    {
                        return (Length_Converters.mile_TO_foot(ConvertFrom));
                    }

                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_inch)
                    {
                        return (Length_Converters.mile_TO_inch(ConvertFrom));
                    }

                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_kilometer)
                    {
                        return (Length_Converters.mile_TO_kilometer(ConvertFrom));
                    }

                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_LightYear)
                    {
                        return (Length_Converters.mile_TO_lightyear(ConvertFrom));
                    }
                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_meter)
                    {
                        return (Length_Converters.mile_TO_meter(ConvertFrom));
                    }
                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_micrometer)
                    {
                        return (Length_Converters.mile_TO_micrometer(ConvertFrom));
                    }

                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_mile)
                    {
                        return (Length_Converters.mile_TO_mile(ConvertFrom));
                    }

                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_millimeter)
                    {
                        return (Length_Converters.mile_TO_millimeter(ConvertFrom));
                    }

                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_nanometer)
                    {
                        return (Length_Converters.mile_TO_nanometer(ConvertFrom));
                    }

                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_yard)
                    {
                        return (Length_Converters.mile_TO_yard(ConvertFrom));
                    }

                }


                #endregion


                #region Length --> millimeter

                if (Convert_Left_From == IConverter.Resources.AppResources.UnitConverter_Length_millimeter)
                {
                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_centimeter)
                    {
                        return (Length_Converters.millimeter_TO_centimeter(ConvertFrom));
                    }
                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_foot)
                    {
                        return (Length_Converters.millimeter_TO_foot(ConvertFrom));
                    }

                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_inch)
                    {
                        return (Length_Converters.millimeter_TO_inch(ConvertFrom));
                    }

                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_kilometer)
                    {
                        return (Length_Converters.millimeter_TO_kilometer(ConvertFrom));
                    }

                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_LightYear)
                    {
                        return (Length_Converters.millimeter_TO_lightyear(ConvertFrom));
                    }
                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_meter)
                    {
                        return (Length_Converters.millimeter_TO_meter(ConvertFrom));
                    }
                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_micrometer)
                    {
                        return (Length_Converters.millimeter_TO_micrometer(ConvertFrom));
                    }

                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_mile)
                    {
                        return (Length_Converters.millimeter_TO_mile(ConvertFrom));
                    }

                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_millimeter)
                    {
                        return (Length_Converters.millimeter_TO_millimeter(ConvertFrom));
                    }

                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_nanometer)
                    {
                        return (Length_Converters.millimeter_TO_nanometer(ConvertFrom));
                    }

                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_yard)
                    {
                        return (Length_Converters.millimeter_TO_yard(ConvertFrom));
                    }

                }



                #endregion


                #region Length --> micrometer

                if (Convert_Left_From == IConverter.Resources.AppResources.UnitConverter_Length_micrometer)
                {
                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_centimeter)
                    {
                        return (Length_Converters.micrometer_TO_centimeter(ConvertFrom));
                    }
                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_foot)
                    {
                        return (Length_Converters.micrometer_TO_foot(ConvertFrom));
                    }

                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_inch)
                    {
                        return (Length_Converters.micrometer_TO_inch(ConvertFrom));
                    }

                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_kilometer)
                    {
                        return (Length_Converters.micrometer_TO_kilometer(ConvertFrom));
                    }

                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_LightYear)
                    {
                        return (Length_Converters.micrometer_TO_lightyear(ConvertFrom));
                    }
                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_meter)
                    {
                        return (Length_Converters.micrometer_TO_meter(ConvertFrom));
                    }
                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_micrometer)
                    {
                        return (Length_Converters.micrometer_TO_micrometer(ConvertFrom));
                    }

                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_mile)
                    {
                        return (Length_Converters.micrometer_TO_mile(ConvertFrom));
                    }

                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_millimeter)
                    {
                        return (Length_Converters.micrometer_TO_millimeter(ConvertFrom));
                    }

                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_nanometer)
                    {
                        return (Length_Converters.micrometer_TO_nanometer(ConvertFrom));
                    }

                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_yard)
                    {
                        return (Length_Converters.micrometer_TO_yard(ConvertFrom));
                    }

                }



                #endregion



                #region Length --> nanometer

                if (Convert_Left_From == IConverter.Resources.AppResources.UnitConverter_Length_nanometer)
                {
                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_centimeter)
                    {
                        return (Length_Converters.nanometer_TO_centimeter(ConvertFrom));
                    }
                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_foot)
                    {
                        return (Length_Converters.nanometer_TO_foot(ConvertFrom));
                    }

                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_inch)
                    {
                        return (Length_Converters.nanometer_TO_inch(ConvertFrom));
                    }

                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_kilometer)
                    {
                        return (Length_Converters.nanometer_TO_kilometer(ConvertFrom));
                    }

                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_LightYear)
                    {
                        return (Length_Converters.nanometer_TO_lightyear(ConvertFrom));
                    }
                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_meter)
                    {
                        return (Length_Converters.nanometer_TO_meter(ConvertFrom));
                    }
                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_micrometer)
                    {
                        return (Length_Converters.nanometer_TO_micrometer(ConvertFrom));
                    }

                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_mile)
                    {
                        return (Length_Converters.nanometer_TO_mile(ConvertFrom));
                    }

                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_millimeter)
                    {
                        return (Length_Converters.nanometer_TO_millimeter(ConvertFrom));
                    }

                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_nanometer)
                    {
                        return (Length_Converters.nanometer_TO_nanometer(ConvertFrom));
                    }

                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_yard)
                    {
                        return (Length_Converters.nanometer_TO_yard(ConvertFrom));
                    }

                }



                #endregion


                #region Length --> lightyear

                if (Convert_Left_From == IConverter.Resources.AppResources.UnitConverter_Length_LightYear)
                {
                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_centimeter)
                    {
                        return (Length_Converters.lightyear_TO_centimeter(ConvertFrom));
                    }
                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_foot)
                    {
                        return (Length_Converters.lightyear_TO_foot(ConvertFrom));
                    }

                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_inch)
                    {
                        return (Length_Converters.lightyear_TO_inch(ConvertFrom));
                    }

                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_kilometer)
                    {
                        return (Length_Converters.lightyear_TO_kilometer(ConvertFrom));
                    }

                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_LightYear)
                    {
                        return (Length_Converters.lightyear_TO_lightyear(ConvertFrom));
                    }
                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_meter)
                    {
                        return (Length_Converters.lightyear_TO_meter(ConvertFrom));
                    }
                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_micrometer)
                    {
                        return (Length_Converters.lightyear_TO_micrometer(ConvertFrom));
                    }

                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_mile)
                    {
                        return (Length_Converters.lightyear_TO_mile(ConvertFrom));
                    }

                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_millimeter)
                    {
                        return (Length_Converters.lightyear_TO_millimeter(ConvertFrom));
                    }

                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_nanometer)
                    {
                        return (Length_Converters.lightyear_TO_nanometer(ConvertFrom));
                    }

                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_yard)
                    {
                        return (Length_Converters.lightyear_TO_yard(ConvertFrom));
                    }

                }



                #endregion


                #region Length --> yard

                if (Convert_Left_From == IConverter.Resources.AppResources.UnitConverter_Length_yard)
                {
                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_centimeter)
                    {
                        return (Length_Converters.yard_TO_centimeter(ConvertFrom));
                    }
                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_foot)
                    {
                        return (Length_Converters.yard_TO_foot(ConvertFrom));
                    }

                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_inch)
                    {
                        return (Length_Converters.yard_TO_inch(ConvertFrom));
                    }

                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_kilometer)
                    {
                        return (Length_Converters.yard_TO_kilometer(ConvertFrom));
                    }

                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_LightYear)
                    {
                        return (Length_Converters.yard_TO_lightyear(ConvertFrom));
                    }
                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_meter)
                    {
                        return (Length_Converters.yard_TO_meter(ConvertFrom));
                    }
                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_micrometer)
                    {
                        return (Length_Converters.yard_TO_micrometer(ConvertFrom));
                    }

                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_mile)
                    {
                        return (Length_Converters.yard_TO_mile(ConvertFrom));
                    }

                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_millimeter)
                    {
                        return (Length_Converters.yard_TO_millimeter(ConvertFrom));
                    }

                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_nanometer)
                    {
                        return (Length_Converters.yard_TO_nanometer(ConvertFrom));
                    }

                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Length_yard)
                    {
                        return (Length_Converters.yard_TO_yard(ConvertFrom));
                    }

                }



                #endregion



            }





            return 0.0;
        }

    }
}
