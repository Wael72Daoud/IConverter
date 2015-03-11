using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * 
 * 
 * 
 *      second
 *      millisecond
 *      microsecond
 *      nanosecond
 *      picosecond
 *      minute
 *      hour
 *      day
 *      week
 *      month
 *      year      
 * 
 * 
 */


namespace IConverter.Converters
{
    class Time_Converters
    {

        #region second converters

        public static double second_TO_second(double units)
        {
            return (units * 1);
        }

        public static double second_TO_millisecond(double units)
        {
            return (units * 1000);
        }
        public static double second_TO_microsecond(double units)
        {
            return (units * 1000000);
        }
        public static double second_TO_nanosecond(double units)
        {
            return (units * 999999999.9999999);
        }
        public static double second_TO_picosecond(double units)
        {
            return (units * 1000000000000);
        }
        public static double second_TO_minute(double units)
        {
            return (units * 0.016666666666666666);
        }
        public static double second_TO_hour(double units)
        {
            return (units * 0.0002777777777777778);
        }
        public static double second_TO_day(double units)
        {
            return (units * 0.000011574074074074073);
        }
        public static double second_TO_week(double units)
        {
            return (units * 0.0000016534391534391535);
        }

        public static double second_TO_month(double units)
        {
            return (units * 3.802570537683474 * Math.Pow(10,-7));
        }

        public static double second_TO_year(double units)
        {
            return (units * 3.168808781402895 * Math.Pow(10,-8));
        }
        #endregion


        #region millisecond converters

        public static double millisecond_TO_second(double units)
        {
            return (units * 0.001);
        }

        public static double millisecond_TO_millisecond(double units)
        {
            return (units * 1);
        }
        public static double millisecond_TO_microsecond(double units)
        {
            return (units * 1000.0000000000001);
        }
        public static double millisecond_TO_nanosecond(double units)
        {
            return (units * 1000000);
        }
        public static double millisecond_TO_picosecond(double units)
        {
            return (units * 1000000000);
        }
        public static double millisecond_TO_minute(double units)
        {
            return (units * 0.000016666666666666667);
        }
        public static double millisecond_TO_hour(double units)
        {
            return (units * 2.7777777777777776 * Math.Pow(10,-7));
        }
        public static double millisecond_TO_day(double units)
        {
            return (units * 1.1574074074074074 * Math.Pow(10,-8));
        }
        public static double millisecond_TO_week(double units)
        {
            return (units * 1.6534391534391535 * Math.Pow(10,-9));
        }

        public static double millisecond_TO_month(double units)
        {
            return (units * 3.802570537683474 * Math.Pow(10,-10));
        }

        public static double millisecond_TO_year(double units)
        {
            return (units * 3.168808781402895 * Math.Pow(10,-11));
        }

        #endregion


        #region microsecond converters

        public static double microsecond_TO_second(double units)
        {
            return (units * 0.000001);
        }

        public static double microsecond_TO_millisecond(double units)
        {
            return (units * 0.001);
        }
        public static double microsecond_TO_microsecond(double units)
        {
            return (units * 1);
        }
        public static double microsecond_TO_nanosecond(double units)
        {
            return (units * 999.9999999999999);
        }
        public static double microsecond_TO_picosecond(double units)
        {
            return (units * 1000000);
        }
        public static double microsecond_TO_minute(double units)
        {
            return (units * 1.6666666666666667 * Math.Pow(10,-8));
        }
        public static double microsecond_TO_hour(double units)
        {
            return (units * 2.7777777777777777 * Math.Pow(10,-10));
        }
        public static double microsecond_TO_day(double units)
        {
            return (units * 1.1574074074074073 * Math.Pow(10,11));
        }
        public static double microsecond_TO_week(double units)
        {
            return (units * 1.6534391534391534 * Math.Pow(10,-12));
        }

        public static double microsecond_TO_month(double units)
        {
            return (units * 3.802570537683474 * Math.Pow(10,-13));
        }

        public static double microsecond_TO_year(double units)
        {
            return (units * 3.168808781402895 * Math.Pow(10,-14));
        }
        #endregion


        #region nanosecond converters

        public static double nanosecond_TO_second(double units)
        {
            return (units * 1 * Math.Pow(10,-9));
        }

        public static double nanosecond_TO_millisecond(double units)
        {
            return (units * 0.000001);
        }
        public static double nanosecond_TO_microsecond(double units)
        {
            return (units * 0.001);
        }
        public static double nanosecond_TO_nanosecond(double units)
        {
            return (units * 1);
        }
        public static double nanosecond_TO_picosecond(double units)
        {
            return (units * 1000.0000000000001);
        }
        public static double nanosecond_TO_minute(double units)
        {
            return (units * 1.6666666666666667 * Math.Pow(20,-11));
        }
        public static double nanosecond_TO_hour(double units)
        {
            return (units * 2.777777777777778 * Math.Pow(10,-13));
        }
        public static double nanosecond_TO_day(double units)
        {
            return (units * 1.1574074074074075 * Math.Pow(20,-14));
        }
        public static double nanosecond_TO_week(double units)
        {
            return (units * 1.6534391534391535 * Math.Pow(10,-15));
        }

        public static double nanosecond_TO_month(double units)
        {
            return (units * 3.802570537683474 * Math.Pow(10,-16));
        }

        public static double nanosecond_TO_year(double units)
        {
            return (units * 3.168808781402895 * Math.Pow(10,-17));
        }
        #endregion


        #region picosecond converters

        public static double picosecond_TO_second(double units)
        {
            return (units * 1 * Math.Pow(10,-12));
        }

        public static double picosecond_TO_millisecond(double units)
        {
            return (units * 1 * Math.Pow(10,-9));
        }
        public static double picosecond_TO_microsecond(double units)
        {
            return (units * 0.000001);
        }
        public static double picosecond_TO_nanosecond(double units)
        {
            return (units * 0.001);
        }
        public static double picosecond_TO_picosecond(double units)
        {
            return (units * 1);
        }
        public static double picosecond_TO_minute(double units)
        {
            return (units * 1.6666666666666667 * Math.Pow(10,-14));
        }
        public static double picosecond_TO_hour(double units)
        {
            return (units * 2.7777777777777775 * Math.Pow(10,-16));
        }
        public static double picosecond_TO_day(double units)
        {
            return (units * 1.1574074074074074 * Math.Pow(10,-17));
        }
        public static double picosecond_TO_week(double units)
        {
            return (units * 1.6534391534391533 * Math.Pow(10,-18));
        }

        public static double picosecond_TO_month(double units)
        {
            return (units * 3.802570537683474 * Math.Pow(10,-19));
        }

        public static double picosecond_TO_year(double units)
        {
            return (units * 3.168808781402895 * Math.Pow(10,-20));
        }
        #endregion


        #region minute converters

        public static double minute_TO_second(double units)
        {
            return (units * 60);
        }

        public static double minute_TO_millisecond(double units)
        {
            return (units * 60000);
        }
        public static double minute_TO_microsecond(double units)
        {
            return (units * 60000000);
        }
        public static double minute_TO_nanosecond(double units)
        {
            return (units * 60000000000);
        }
        public static double minute_TO_picosecond(double units)
        {
            return (units * 60000000000000);
        }
        public static double minute_TO_minute(double units)
        {
            return (units * 1);
        }
        public static double minute_TO_hour(double units)
        {
            return (units * 0.016666666666666666);
        }
        public static double minute_TO_day(double units)
        {
            return (units * 0.0006944444444444445);
        }
        public static double minute_TO_week(double units)
        {
            return (units * 0.0000992063492063492);
        }

        public static double minute_TO_month(double units)
        {
            return (units * 0.000022815423226100844);
        }

        public static double minute_TO_year(double units)
        {
            return (units * 0.000001901285268841737);
        }
        #endregion


        #region hour converters

        public static double hour_TO_second(double units)
        {
            return (units * 3600);
        }

        public static double hour_TO_millisecond(double units)
        {
            return (units * 3600000);
        }
        public static double hour_TO_microsecond(double units)
        {
            return (units * 3600000000);
        }
        public static double hour_TO_nanosecond(double units)
        {
            return (units * 3600000000000);
        }
        public static double hour_TO_picosecond(double units)
        {
            return (units * 3600000000000000);
        }
        public static double hour_TO_minute(double units)
        {
            return (units * 60);
        }
        public static double hour_TO_hour(double units)
        {
            return (units * 1);
        }
        public static double hour_TO_day(double units)
        {
            return (units * 0.041666666666666664);
        }
        public static double hour_TO_week(double units)
        {
            return (units * 0.005952380952380952);
        }

        public static double hour_TO_month(double units)
        {
            return (units * 0.0013689253935660506);
        }

        public static double hour_TO_year(double units)
        {
            return (units * 0.00011407711613050422);
        }
        #endregion


        #region day converters

        public static double day_TO_second(double units)
        {
            return (units * 86400);
        }

        public static double day_TO_millisecond(double units)
        {
            return (units * 86400000);
        }
        public static double day_TO_microsecond(double units)
        {
            return (units * 86400000000);
        }
        public static double day_TO_nanosecond(double units)
        {
            return (units * 86400000000000);
        }
        public static double day_TO_picosecond(double units)
        {
            return (units * 86400000000000000);
        }
        public static double day_TO_minute(double units)
        {
            return (units * 1440);
        }
        public static double day_TO_hour(double units)
        {
            return (units * 24);
        }
        public static double day_TO_day(double units)
        {
            return (units * 1);
        }
        public static double day_TO_week(double units)
        {
            return (units * 0.14285714285714285);
        }

        public static double day_TO_month(double units)
        {
            return (units * 0.03285420944558522);
        }

        public static double day_TO_year(double units)
        {
            return (units * 0.0027378507871321012);
        }
        #endregion


        #region week converters

        public static double week_TO_second(double units)
        {
            return (units * 604800);
        }

        public static double week_TO_millisecond(double units)
        {
            return (units * 604800000);
        }
        public static double week_TO_microsecond(double units)
        {
            return (units * 604800000000);
        }
        public static double week_TO_nanosecond(double units)
        {
            return (units * 604800000000000);
        }
        public static double week_TO_picosecond(double units)
        {
            return (units * 604800000000000000);
        }
        public static double week_TO_minute(double units)
        {
            return (units * 10080);
        }
        public static double week_TO_hour(double units)
        {
            return (units * 168);
        }
        public static double week_TO_day(double units)
        {
            return (units * 7);
        }
        public static double week_TO_week(double units)
        {
            return (units * 1);
        }

        public static double week_TO_month(double units)
        {
            return (units * 0.2299794661190965);
        }

        public static double week_TO_year(double units)
        {
            return (units * 0.019164955509924707);
        }
        #endregion


        #region month converters

        public static double month_TO_second(double units)
        {
            return (units * 2629800);
        }

        public static double month_TO_millisecond(double units)
        {
            return (units * 2629800000);
        }
        public static double month_TO_microsecond(double units)
        {
            return (units * 2629800000000);
        }
        public static double month_TO_nanosecond(double units)
        {
            return (units * 2629800000000000);
        }
        public static double month_TO_picosecond(double units)
        {
            return (units * 2629800000000000000);
        }
        public static double month_TO_minute(double units)
        {
            return (units * 43830);
        }
        public static double month_TO_hour(double units)
        {
            return (units * 730.5);
        }
        public static double month_TO_day(double units)
        {
            return (units * 30.4375);
        }
        public static double month_TO_week(double units)
        {
            return (units * 4.348214285714286);
        }

        public static double month_TO_month(double units)
        {
            return (units * 1);
        }

        public static double month_TO_year(double units)
        {
            return (units * 0.08333333333333333);
        }
        #endregion


        #region year converters

        public static double year_TO_second(double units)
        {
            return (units * 31557600);
        }

        public static double year_TO_millisecond(double units)
        {
            return (units * 31557600000);
        }
        public static double year_TO_microsecond(double units)
        {
            return (units * 31557600000000);
        }
        public static double year_TO_nanosecond(double units)
        {
            return (units * 31557600000000000);
        }
        public static double year_TO_picosecond(double units)
        {
            return (units * 31557600000000 * 1000000);
        }
        public static double year_TO_minute(double units)
        {
            return (units * 525960);
        }
        public static double year_TO_hour(double units)
        {
            return (units * 8766);
        }
        public static double year_TO_day(double units)
        {
            return (units * 365.25);
        }
        public static double year_TO_week(double units)
        {
            return (units * 52.17857142857143);
        }

        public static double year_TO_month(double units)
        {
            return (units * 12);
        }

        public static double year_TO_year(double units)
        {
            return (units * 1);
        }
        #endregion
        
    }
}
