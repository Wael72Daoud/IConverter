using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
//
//
//
 *      kilogram
 *      gram
 *      milligram
 *      ton
 *      pound
 *      ounce
 *      carrat
 *      atomicmassunit

*/


namespace IConverter.Converters
{
    class Weight_Converters
    {

        #region kilogram conversion

        public static double kilogram_TO_kilogram(double unites)
        {
            return (unites * 1);
        }

        public static double kilogram_TO_gram(double unites)
        {
            return (unites * 1000);
        }


        public static double kilogram_TO_milligram(double unites)
        {
            return (unites * 1000000);
        }

        public static double kilogram_TO_ton(double unites)
        {
            return (unites * 0.001);
        }

        public static double kilogram_TO_pound(double unites)
        {
            return (unites * 2.2046244201837774);
        }

        public static double kilogram_TO_ounce(double unites)
        {
            return (unites * 35.27399072294044);
        }

        public static double kilogram_TO_carrat(double unites)
        {
            return (unites * 5000);
        }

        public static double kilogram_TO_atomicmassunit(double unites)
        {
            return (unites * 6.022136652 * Math.Pow(10,26));
        }


        #endregion




        #region gram conversion

        public static double gram_TO_kilogram(double unites)
        {
            return (unites * 0.001);
        }

        public static double gram_TO_gram(double unites)
        {
            return (unites * 1);
        }


        public static double gram_TO_milligram(double unites)
        {
            return (unites * 1000.0000000000001);
        }

        public static double gram_TO_ton(double unites)
        {
            return (unites * 0.000001);
        }

        public static double gram_TO_pound(double unites)
        {
            return (unites * 0.0022046244201837776);
        }

        public static double gram_TO_ounce(double unites)
        {
            return (unites * 0.03527399072294044);
        }

        public static double gram_TO_carrat(double unites)
        {
            return (unites * 5);
        }

        public static double gram_TO_atomicmassunit(double unites)
        {
            return (unites * 6.022136652 * Math.Pow(10,23));
        }

        #endregion





        #region milligram conversion

        public static double milligram_TO_kilogram(double unites)
        {
            return (unites * 0.000001);
        }

        public static double milligram_TO_gram(double unites)
        {
            return (unites * 0.001);
        }


        public static double milligram_TO_milligram(double unites)
        {
            return (unites * 1);
        }

        public static double milligram_TO_ton(double unites)
        {
            return (unites * 9.999999999999998 * Math.Pow(10,-10));
        }

        public static double milligram_TO_pound(double unites)
        {
            return (unites * 0.0000022046244201837774);
        }

        public static double milligram_TO_ounce(double unites)
        {
            return (unites * 0.00003527399072294044);
        }

        public static double milligram_TO_carrat(double unites)
        {
            return (unites * 0.004999999999999999);
        }

        public static double milligram_TO_atomicmassunit(double unites)
        {
            return (unites * 60221366520000000 * 10000);
        }

        #endregion





        #region ton conversion
        public static double ton_TO_kilogram(double unites)
        {
            return (unites * 1000);
        }

        public static double ton_TO_gram(double unites)
        {
            return (unites * 1000000);
        }


        public static double ton_TO_milligram(double unites)
        {
            return (unites * 1000000000);
        }

        public static double ton_TO_ton(double unites)
        {
            return (unites * 1);
        }

        public static double ton_TO_pound(double unites)
        {
            return (unites * 2204.6244201837776);
        }

        public static double ton_TO_ounce(double unites)
        {
            return (unites * 35273.99072294044);
        }

        public static double ton_TO_carrat(double unites)
        {
            return (unites * 5000000);
        }

        public static double ton_TO_atomicmassunit(double unites)
        {
            return (unites * 6.022136652 * Math.Pow(10,29));
        }


        #endregion




        #region pound conversion

        public static double pound_TO_kilogram(double unites)
        {
            return (unites * 0.453592);
        }

        public static double pound_TO_gram(double unites)
        {
            return (unites * 453.592);
        }


        public static double pound_TO_milligram(double unites)
        {
            return (unites * 453592);
        }

        public static double pound_TO_ton(double unites)
        {
            return (unites * 0.000453592);
        }

        public static double pound_TO_pound(double unites)
        {
            return (unites * 1);
        }

        public static double pound_TO_ounce(double unites)
        {
            return (unites * 16);
        }

        public static double pound_TO_carrat(double unites)
        {
            return (unites * 2267.96);
        }

        public static double pound_TO_atomicmassunit(double unites)
        {
            return (unites * 2.7315930082539837 * Math.Pow(10,26));
        }


        #endregion
        

        #region ounce conversion

        public static double ounce_TO_kilogram(double unites)
        {
            return (unites * 0.0283495);
        }

        public static double ounce_TO_gram(double unites)
        {
            return (unites * 28.3495);
        }


        public static double ounce_TO_milligram(double unites)
        {
            return (unites * 28349.5);
        }

        public static double ounce_TO_ton(double unites)
        {
            return (unites * 0.0000283495);
        }

        public static double ounce_TO_pound(double unites)
        {
            return (unites * 0.0625);
        }

        public static double ounce_TO_ounce(double unites)
        {
            return (unites * 1);
        }

        public static double ounce_TO_carrat(double unites)
        {
            return (unites * 141.7475);
        }

        public static double ounce_TO_atomicmassunit(double unites)
        {
            return (unites * 1.7072456301587398 * Math.Pow(10,25));
        }


        #endregion
        

        
        #region carrat conversion

        public static double carrat_TO_kilogram(double unites)
        {
            return (unites * 0.0002);
        }

        public static double carrat_TO_gram(double unites)
        {
            return (unites * 0.2);
        }


        public static double carrat_TO_milligram(double unites)
        {
            return (unites * 200.00000000000003);
        }

        public static double carrat_TO_ton(double unites)
        {
            return (unites * 2.0000000000000002 * Math.Pow(10,-7));
        }

        public static double carrat_TO_pound(double unites)
        {
            return (unites * 0.0004409248840367555);
        }

        public static double carrat_TO_ounce(double unites)
        {
            return (unites * 0.007054798144588088);
        }

        public static double carrat_TO_carrat(double unites)
        {
            return (unites * 1);
        }

        public static double carrat_TO_atomicmassunit(double unites)
        {
            return (unites * 1.2044273304 * Math.Pow(10,23));
        }


        #endregion



        #region atomicmassunit conversion


        public static double atomicmassunit_TO_kilogram(double unites)
        {
            return (unites * 1.6605401999104288 * Math.Pow(10,-27));
        }

        public static double atomicmassunit_TO_gram(double unites)
        {
            return (unites * 1.6605401999104286 * Math.Pow(10,-24));
        }


        public static double atomicmassunit_TO_milligram(double unites)
        {
            return (unites * 1.660540199910429 * Math.Pow(10,-21));
        }

        public static double atomicmassunit_TO_ton(double unites)
        {
            return (unites * 1.660540199910429 * Math.Pow(10,-30));
        }

        public static double atomicmassunit_TO_pound(double unites)
        {
            return (unites * 3.660867475419383 * Math.Pow(10,-27));
        }

        public static double atomicmassunit_TO_ounce(double unites)
        {
            return (unites * 5.857387960671013 * Math.Pow(10,-26));
        }

        public static double atomicmassunit_TO_carrat(double unites)
        {
            return (unites * 8.302700999552143 * Math.Pow(10,-24));
        }

        public static double atomicmassunit_TO_atomicmassunit(double unites)
        {
            return (unites * 1);
        }


        #endregion


    }
}
