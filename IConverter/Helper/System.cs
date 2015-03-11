using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Device.Location;

namespace IConverter.Converters
{
    class System
    {

        /// <summary>
        /// 480x800 or 800x480 (15:9) ratio
        /// </summary>
        /// <returns></returns>
        public static bool isWVGA()
        {
            return (App.Current.Host.Content.ScaleFactor == 100 ? true : false);
            
        }

        /// <summary>
        /// 768x1280 or 1280x768 (15:9) ratio
        /// </summary>
        /// <returns></returns>
        public static bool isWXGA()
        {
            return (App.Current.Host.Content.ScaleFactor == 160 ? true : false);
        }


        /// <summary>
        /// 720x1280 or 1280x720 (16:9) ratio
        /// </summary>
        /// <returns></returns>
        public static bool is720P()
        {
            return (App.Current.Host.Content.ScaleFactor == 150 ? true : false);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static Resolution GetCurrentResoultion()
        {
            if (isWVGA()) return Resolution.WVGA;
            else if (isWXGA()) return Resolution.WXGA;
            else if (is720P()) return Resolution.HD720p;

            else throw new InvalidOperationException("Uknown resolution");
        }


        /// <summary>
        /// 
        /// WVGA    -- 480x800 or 800x480 (15:9) ratio
        /// WXGA    -- 720x1280 or 1280x720 (16:9) ratio
        /// HD720p  -- 720x1280 or 1280x720 (16:9) ratio
        /// </summary>
        public enum Resolution { WVGA, WXGA, HD720p };


    }
}
