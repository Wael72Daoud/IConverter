using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IConverter.Converters
{
    class UnitTime
    {



           /// <summary>
        /// 
        /// </summary>
        /// <param name="Convert_Left_From"></param>
        /// <param name="Convert_Right_To"></param>
        /// <returns></returns>
        public double Convert(string Convert_Left_From, string Convert_Right_To, string Category_Button, double ConvertFrom)
        {
            if (IConverter.Resources.AppResources.Category_Time.ToUpper() == Category_Button)
            {
                #region Time --> day
                
                if (Convert_Left_From == IConverter.Resources.AppResources.UnitConverter_Time_day)
                {

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_day)
                    {
                        return Time_Converters.day_TO_day(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_hour)
                    {
                        return Time_Converters.day_TO_hour(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_microsecond)
                    {
                        return Time_Converters.day_TO_microsecond(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_millisecond)
                    {
                        return Time_Converters.day_TO_millisecond(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_minute)
                    {
                        return Time_Converters.day_TO_minute(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_month)
                    {
                        return Time_Converters.day_TO_month(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_nanosecond)
                    {
                        return Time_Converters.day_TO_nanosecond(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_picosecond)
                    {
                        return Time_Converters.day_TO_picosecond(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_Second)
                    {
                        return Time_Converters.day_TO_second(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_week)
                    {
                        return Time_Converters.day_TO_week(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_year)
                    {
                        return Time_Converters.day_TO_year(ConvertFrom);
                    }



                }



                #endregion


                #region Time --> week

                if (Convert_Left_From == IConverter.Resources.AppResources.UnitConverter_Time_week)
                {

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_day)
                    {
                        return Time_Converters.week_TO_day(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_hour)
                    {
                        return Time_Converters.week_TO_hour(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_microsecond)
                    {
                        return Time_Converters.week_TO_microsecond(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_millisecond)
                    {
                        return Time_Converters.week_TO_millisecond(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_minute)
                    {
                        return Time_Converters.week_TO_minute(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_month)
                    {
                        return Time_Converters.week_TO_month(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_nanosecond)
                    {
                        return Time_Converters.week_TO_nanosecond(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_picosecond)
                    {
                        return Time_Converters.week_TO_picosecond(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_Second)
                    {
                        return Time_Converters.week_TO_second(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_week)
                    {
                        return Time_Converters.week_TO_week(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_year)
                    {
                        return Time_Converters.week_TO_year(ConvertFrom);
                    }
                    
                }
                
                #endregion


                #region Time --> Second

                if (Convert_Left_From == IConverter.Resources.AppResources.UnitConverter_Time_Second)
                {

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_day)
                    {
                        return Time_Converters.second_TO_day(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_hour)
                    {
                        return Time_Converters.second_TO_hour(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_microsecond)
                    {
                        return Time_Converters.second_TO_microsecond(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_millisecond)
                    {
                        return Time_Converters.second_TO_millisecond(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_minute)
                    {
                        return Time_Converters.second_TO_minute(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_month)
                    {
                        return Time_Converters.second_TO_month(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_nanosecond)
                    {
                        return Time_Converters.second_TO_nanosecond(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_picosecond)
                    {
                        return Time_Converters.second_TO_picosecond(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_Second)
                    {
                        return Time_Converters.second_TO_second(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_week)
                    {
                        return Time_Converters.second_TO_week(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_year)
                    {
                        return Time_Converters.second_TO_year(ConvertFrom);
                    }

                }

                #endregion



                #region Time --> picosecond

                if (Convert_Left_From == IConverter.Resources.AppResources.UnitConverter_Time_picosecond)
                {

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_day)
                    {
                        return Time_Converters.picosecond_TO_day(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_hour)
                    {
                        return Time_Converters.picosecond_TO_hour(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_microsecond)
                    {
                        return Time_Converters.picosecond_TO_microsecond(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_millisecond)
                    {
                        return Time_Converters.picosecond_TO_millisecond(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_minute)
                    {
                        return Time_Converters.picosecond_TO_minute(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_month)
                    {
                        return Time_Converters.picosecond_TO_month(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_nanosecond)
                    {
                        return Time_Converters.picosecond_TO_nanosecond(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_picosecond)
                    {
                        return Time_Converters.picosecond_TO_picosecond(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_Second)
                    {
                        return Time_Converters.picosecond_TO_second(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_week)
                    {
                        return Time_Converters.picosecond_TO_week(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_year)
                    {
                        return Time_Converters.picosecond_TO_year(ConvertFrom);
                    }

                }

                #endregion



                #region Time --> nanosecond

                if (Convert_Left_From == IConverter.Resources.AppResources.UnitConverter_Time_nanosecond)
                {

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_day)
                    {
                        return Time_Converters.nanosecond_TO_day(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_hour)
                    {
                        return Time_Converters.nanosecond_TO_hour(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_microsecond)
                    {
                        return Time_Converters.nanosecond_TO_microsecond(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_millisecond)
                    {
                        return Time_Converters.nanosecond_TO_millisecond(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_minute)
                    {
                        return Time_Converters.nanosecond_TO_minute(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_month)
                    {
                        return Time_Converters.nanosecond_TO_month(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_nanosecond)
                    {
                        return Time_Converters.nanosecond_TO_nanosecond(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_picosecond)
                    {
                        return Time_Converters.nanosecond_TO_picosecond(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_Second)
                    {
                        return Time_Converters.nanosecond_TO_second(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_week)
                    {
                        return Time_Converters.nanosecond_TO_week(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_year)
                    {
                        return Time_Converters.nanosecond_TO_year(ConvertFrom);
                    }

                }

                #endregion



                #region Time --> month

                if (Convert_Left_From == IConverter.Resources.AppResources.UnitConverter_Time_month)
                {

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_day)
                    {
                        return Time_Converters.month_TO_day(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_hour)
                    {
                        return Time_Converters.month_TO_hour(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_microsecond)
                    {
                        return Time_Converters.month_TO_microsecond(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_millisecond)
                    {
                        return Time_Converters.month_TO_millisecond(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_minute)
                    {
                        return Time_Converters.month_TO_minute(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_month)
                    {
                        return Time_Converters.month_TO_month(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_nanosecond)
                    {
                        return Time_Converters.month_TO_nanosecond(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_picosecond)
                    {
                        return Time_Converters.month_TO_picosecond(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_Second)
                    {
                        return Time_Converters.month_TO_second(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_week)
                    {
                        return Time_Converters.month_TO_week(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_year)
                    {
                        return Time_Converters.month_TO_year(ConvertFrom);
                    }

                }

                #endregion



                #region Time --> minute

                if (Convert_Left_From == IConverter.Resources.AppResources.UnitConverter_Time_minute)
                {

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_day)
                    {
                        return Time_Converters.minute_TO_day(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_hour)
                    {
                        return Time_Converters.minute_TO_hour(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_microsecond)
                    {
                        return Time_Converters.minute_TO_microsecond(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_millisecond)
                    {
                        return Time_Converters.minute_TO_millisecond(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_minute)
                    {
                        return Time_Converters.minute_TO_minute(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_month)
                    {
                        return Time_Converters.minute_TO_month(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_nanosecond)
                    {
                        return Time_Converters.minute_TO_nanosecond(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_picosecond)
                    {
                        return Time_Converters.minute_TO_picosecond(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_Second)
                    {
                        return Time_Converters.minute_TO_second(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_week)
                    {
                        return Time_Converters.minute_TO_week(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_year)
                    {
                        return Time_Converters.minute_TO_year(ConvertFrom);
                    }

                }

                #endregion



                #region Time --> millisecond

                if (Convert_Left_From == IConverter.Resources.AppResources.UnitConverter_Time_millisecond)
                {

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_day)
                    {
                        return Time_Converters.millisecond_TO_day(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_hour)
                    {
                        return Time_Converters.millisecond_TO_hour(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_microsecond)
                    {
                        return Time_Converters.millisecond_TO_microsecond(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_millisecond)
                    {
                        return Time_Converters.millisecond_TO_millisecond(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_minute)
                    {
                        return Time_Converters.millisecond_TO_minute(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_month)
                    {
                        return Time_Converters.millisecond_TO_month(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_nanosecond)
                    {
                        return Time_Converters.millisecond_TO_nanosecond(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_picosecond)
                    {
                        return Time_Converters.millisecond_TO_picosecond(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_Second)
                    {
                        return Time_Converters.millisecond_TO_second(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_week)
                    {
                        return Time_Converters.millisecond_TO_week(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_year)
                    {
                        return Time_Converters.millisecond_TO_year(ConvertFrom);
                    }

                }

                #endregion




                #region Time --> microsecond

                if (Convert_Left_From == IConverter.Resources.AppResources.UnitConverter_Time_microsecond)
                {

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_day)
                    {
                        return Time_Converters.microsecond_TO_day(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_hour)
                    {
                        return Time_Converters.microsecond_TO_hour(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_microsecond)
                    {
                        return Time_Converters.microsecond_TO_microsecond(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_millisecond)
                    {
                        return Time_Converters.microsecond_TO_millisecond(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_minute)
                    {
                        return Time_Converters.microsecond_TO_minute(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_month)
                    {
                        return Time_Converters.microsecond_TO_month(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_nanosecond)
                    {
                        return Time_Converters.microsecond_TO_nanosecond(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_picosecond)
                    {
                        return Time_Converters.microsecond_TO_picosecond(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_Second)
                    {
                        return Time_Converters.microsecond_TO_second(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_week)
                    {
                        return Time_Converters.microsecond_TO_week(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_year)
                    {
                        return Time_Converters.microsecond_TO_year(ConvertFrom);
                    }

                }

                #endregion




                #region Time --> hour

                if (Convert_Left_From == IConverter.Resources.AppResources.UnitConverter_Time_hour)
                {

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_day)
                    {
                        return Time_Converters.hour_TO_day(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_hour)
                    {
                        return Time_Converters.hour_TO_hour(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_microsecond)
                    {
                        return Time_Converters.hour_TO_microsecond(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_millisecond)
                    {
                        return Time_Converters.hour_TO_millisecond(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_minute)
                    {
                        return Time_Converters.hour_TO_minute(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_month)
                    {
                        return Time_Converters.hour_TO_month(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_nanosecond)
                    {
                        return Time_Converters.hour_TO_nanosecond(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_picosecond)
                    {
                        return Time_Converters.hour_TO_picosecond(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_Second)
                    {
                        return Time_Converters.hour_TO_second(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_week)
                    {
                        return Time_Converters.hour_TO_week(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_year)
                    {
                        return Time_Converters.hour_TO_year(ConvertFrom);
                    }

                }

                #endregion



                #region Time --> day

                if (Convert_Left_From == IConverter.Resources.AppResources.UnitConverter_Time_day)
                {

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_day)
                    {
                        return Time_Converters.day_TO_day(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_hour)
                    {
                        return Time_Converters.day_TO_hour(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_microsecond)
                    {
                        return Time_Converters.day_TO_microsecond(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_millisecond)
                    {
                        return Time_Converters.day_TO_millisecond(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_minute)
                    {
                        return Time_Converters.day_TO_minute(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_month)
                    {
                        return Time_Converters.day_TO_month(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_nanosecond)
                    {
                        return Time_Converters.day_TO_nanosecond(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_picosecond)
                    {
                        return Time_Converters.day_TO_picosecond(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_Second)
                    {
                        return Time_Converters.day_TO_second(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_week)
                    {
                        return Time_Converters.day_TO_week(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_year)
                    {
                        return Time_Converters.day_TO_year(ConvertFrom);
                    }

                }

                #endregion


                #region Time --> year

                if (Convert_Left_From == IConverter.Resources.AppResources.UnitConverter_Time_year)
                {

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_day)
                    {
                        return Time_Converters.year_TO_day(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_hour)
                    {
                        return Time_Converters.year_TO_hour(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_microsecond)
                    {
                        return Time_Converters.year_TO_microsecond(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_millisecond)
                    {
                        return Time_Converters.year_TO_millisecond(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_minute)
                    {
                        return Time_Converters.year_TO_minute(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_month)
                    {
                        return Time_Converters.year_TO_month(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_nanosecond)
                    {
                        return Time_Converters.year_TO_nanosecond(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_picosecond)
                    {
                        return Time_Converters.year_TO_picosecond(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_Second)
                    {
                        return Time_Converters.year_TO_second(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_week)
                    {
                        return Time_Converters.year_TO_week(ConvertFrom);
                    }

                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitConverter_Time_year)
                    {
                        return Time_Converters.year_TO_year(ConvertFrom);
                    }

                }

                #endregion

            }

            return 0.0;
        }
    }
}
