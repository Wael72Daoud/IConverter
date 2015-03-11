using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * 
 *  cubicmeter
 *  cubicfoot
 *  cubicyard
 *  cubicinch
 *  cubickilometer
 *  cubicmile
 *  cubiccentimeter
 *  cubicmillimeter
 *  liter
 *  milliliter
 *  pint
 *  quart
 *  gallon
 *  
 */

namespace IConverter.Converters
{
    class Volume_Converters
    {


        #region Cubicmeter converters

        public static double cubicmeter_TO_cubicmeter(double unites)
        {
            return (unites * 1 );
        }

       public static double cubicmeter_TO_cubicfoot(double unites)
        {
            return (unites * 35.31472482766414);
        }

        public static double cubicmeter_TO_cubicyard(double unites)
        {
            return (unites * 1.307950376362721);
        }

        public static double cubicmeter_TO_cubicinch(double unites)
        {
            return (unites * 61023.61003472243);
        }

        public static double cubicmeter_TO_cubickilometer(double unites)
        {
            return (unites * 1.0 * Math.Pow(10 , -9));
        }

        public static double cubicmeter_TO_cubicmile(double unites)
        {
            return (unites * 2.39912759 * Math.Pow(10,-10));
        }

        public static double cubicmeter_TO_cubiccentimeter(double unites)
        {
            return (unites * 1000000);
        }

        public static double cubicmeter_TO_cubicmillimeter(double unites)
        {
            return (unites * 999999999.9999999);
        }

        public static double cubicmeter_TO_liter(double unites)
        {
            return (unites * 1000);
        }

         public static double cubicmeter_TO_milliliter(double unites)
        {
            return (unites * 1000000);
        }
         public static double cubicmeter_TO_pint(double unites)
        {
            return (unites * 2113.378531455526);
        }
         public static double cubicmeter_TO_quart(double unites)
        {
            return (unites * 1056.6881491367385);
        }

         public static double cubicmeter_TO_gallon(double unites)
        {
            return (unites * 264.172176857989);
        }




        #endregion 


        #region cubiccentimeter converters

         public static double cubiccentimeter_TO_cubicmeter(double unites)
         {
             return (unites * 0.000001);
         }

        public static double cubiccentimeter_TO_cubicfoot(double unites)
        {
            return (unites * 0.000035314724827664144);
        }

        public static double cubiccentimeter_TO_cubicyard(double unites)
        {
            return (unites * 1.307950619314392 * ( Math.Pow(10, -6)));
        }
        public static double cubiccentimeter_TO_cubicinch(double unites)
        {
            return (unites * 0.0610237440947323);
        }
        public static double cubiccentimeter_TO_cubickilometer(double unites)
        {
            return (unites * 9.999999999999998 * (Math.Pow(10,-16)));
        }
        public static double cubiccentimeter_TO_cubicmile(double unites)
        {
            return (unites * 2.3991286364792304 * (Math.Pow(10,-16)));
        }
        public static double cubiccentimeter_TO_cubiccentimeter(double unites)
        {
            return (unites *    1);
        }
        public static double cubiccentimeter_TO_cubicmillimeter(double unites)
        {
            return (unites * 999.9999999999999);
        }
        public static double cubiccentimeter_TO_liter(double unites)
        {
            return (unites * 0.001);
        }
        public static double cubiccentimeter_TO_milliliter(double unites)
        {
            return (unites * 1);
        }
        public static double cubiccentimeter_TO_pint(double unites)
        {
            return (unites * 0.002113378531455526);
        }
        public static double cubiccentimeter_TO_quart(double unites)
        {
            return (unites * 0.0010566881491367386);
        }
        public static double cubiccentimeter_TO_gallon(double unites)
        {
            return (unites * 0.00026417217685798894);
        }

        #endregion



        #region cubicfoot converters

         public static double cubicfoot_TO_cubicmeter(double unites)
         {
             return (unites * 0.0283168);
         }

        public static double cubicfoot_TO_cubicfoot(double unites)
         {
             return (unites * 1);
         }

        public static double cubicfoot_TO_cubicyard(double unites)
         {
             return (unites * 0.037036969217387895);
         }

        public static double cubicfoot_TO_cubicinch(double unites)
         {
             return (unites * 1727.9933606312281);
         }

        public static double cubicfoot_TO_cubickilometer(double unites)
         {
             return (unites * 2.83168 * Math.Pow(10, -11));
         }

        public static double cubicfoot_TO_cubiccentimeter(double unites)
         {
             return (unites * 28316.8);
         }

      
        public static double cubicfoot_TO_cubicmillimeter(double unites)
        {
            return (unites * 28316799.999999996);
        }

        public static double cubicfoot_TO_cubicmile(double unites)
         {
             return (unites * 6.793564577345508 * Math.Pow(10,-12));
         }

        public static double cubicfoot_TO_liter(double unites)
         {
             return (unites * 28.3168);
         }

        public static double cubicfoot_TO_milliliter(double unites)
         {
             return (unites * 28316.8);
         }

        public static double cubicfoot_TO_pint(double unites)
         {
             return (unites * 59.844117199519836);
         }

        public static double cubicfoot_TO_quart(double unites)
         {
             return (unites * 29.9220269814752);
         }

        public static double cubicfoot_TO_gallon(double unites)
         {
             return (unites * 7.480510697652302);
         }
                
        #endregion


        #region cubicyard converters

         public static double cubicyard_TO_cubicmeter (double unites)
         {
             return (unites * 0.764555);
         }

        public static double cubicyard_TO_cubicfoot (double unites)
         {
             return (unites * 27.00004944061476);
         }

        public static double cubicyard_TO_cubicyard (double unites)
         {
             return (unites * 1);
         }

        public static double cubicyard_TO_cubicinch (double unites)
         {
             return (unites * 46655.90617009721);
         }

        public static double cubicyard_TO_cubickilometer (double unites)
         {
             return (unites * 7.64555 * Math.Pow(10,-10));
         }

        public static double cubicyard_TO_cubicmile (double unites)
         {
             return (unites * 1.8342657946633783 * Math.Pow(10, -10));
         }

        public static double cubicyard_TO_cubiccentimeter (double unites)
         {
             return (unites * 764554.857984);
         }

        public static double cubicyard_TO_cubicmillimeter (double unites)
         {
             return (unites * 764554999.9999999);
         }

        public static double cubicyard_TO_liter (double unites)
         {
             return (unites * 764.555);
         }

        public static double cubicyard_TO_milliliter (double unites)
         {
             return (unites * 764555);
         }

        public static double cubicyard_TO_pint (double unites)
         {
             return (unites * 1615.7941231169795);
         }

        public static double cubicyard_TO_quart (double unites)
         {
             return (unites * 807.8962078632392);
         }

        public static double cubicyard_TO_gallon(double unites)
         {
             return (unites * 201.97415867765974);
         }


        #endregion


        
        #region cubicinch converters

         public static double cubicinch_TO_cubicmeter (double unites)
         {
             return (unites * 0.000016387064);
         }

         public static double cubicinch_TO_cubicfoot (double unites)
         {
             return (unites * 0.0005787059272234151);
         }

         public static double cubicinch_TO_cubicyard (double unites)
         {
             return (unites * 2.143347050754458 * Math.Pow(10,-5));
         }

         public static double cubicinch_TO_cubicinch (double unites)
         {
             return (unites * 1);
         }

         public static double cubicinch_TO_cubickilometer (double unites)
         {
             return (unites * 1.63871 * Math.Pow(10, -14));
         }

         public static double cubicinch_TO_cubicmile (double unites)
         {
             return (unites * 3.9314760878848805 * Math.Pow(10,-15));
         }

         public static double cubicinch_TO_cubiccentimeter (double unites)
         {
             return (unites * 16.3871);
         }

         public static double cubicinch_TO_cubicmillimeter (double unites)
         {
             return (unites * 16387.1);
         }

         public static double cubicinch_TO_liter (double unites)
         {
             return (unites * 0.0163871);
         }

         public static double cubicinch_TO_milliliter (double unites)
         {
             return (unites * 16.3871);
         }

        public static double cubicinch_TO_pint(double unites)
         {
             return (unites * 0.034632145332814855);
         }
        public static double cubicinch_TO_quart(double unites)
         {
             return (unites * 0.01731605436871865);
         }
        public static double cubicinch_TO_gallon(double unites)
         {
             return (unites * 0.004329015879389551);
         }

        #endregion


        #region cubickilometer converters

        public static double cubickilometer_TO_cubicmeter(double unites)
         {
             return (unites * 1000000000);
         }

        public static double cubickilometer_TO_cubicfoot(double unites)
         {
             return (unites * 35314724827.66415);
         }

        public static double cubickilometer_TO_cubicyard(double unites)
         {
             return (unites * 1307950376.3627207);
         }

        public static double cubickilometer_TO_cubicinch(double unites)
         {
             return (unites * 61023610034722.43);
         }

        public static double cubickilometer_TO_cubickilometer(double unites)
         {
             return (unites * 1);
         }

        public static double cubickilometer_TO_cubicmile(double unites)
         {
             return (unites * 0.23991286364792308);
         }

        public static double cubickilometer_TO_cubiccentimeter(double unites)
         {
             return (unites * 1000000000000000);
         }

        public static double cubickilometer_TO_cubicmillimeter(double unites)
         {
             return (unites * 1000000000000000000);
         }

        public static double cubickilometer_TO_liter(double unites)
         {
             return (unites * 1000000000000);
         }

        public static double cubickilometer_TO_milliliter(double unites)
         {
             return (unites * 1000000000000000);
         }

        public static double cubickilometer_TO_pint(double unites)
         {
             return (unites * 2113378531455.5261);
         }
        public static double cubickilometer_TO_quart(double unites)
         {
             return (unites * 1056688149136.7385);
         }
        public static double cubickilometer_TO_gallon(double unites)
         {
             return (unites * 264172176857.98898);
         }

        


        #endregion



        #region cubicmile converters


        public static double cubicmile_TO_cubicmeter(double unites)
         {
             return (unites * 4168180000);
         }

        public static double cubicmile_TO_cubicfoot(double unites)
         {
             return (unites * 147198129732.17313);
         }

        public static double cubicmile_TO_cubicyard(double unites)
         {
             return (unites * 5451772599.747565);
         }

        public static double cubicmile_TO_cubicinch(double unites)
         {
             return (unites * 254357390874529.34);
         }

        public static double cubicmile_TO_cubickilometer(double unites)
         {
             return (unites * 4.16818);
         }

        public static double cubicmile_TO_cubicmile(double unites)
         {
             return (unites * 1);
         }

        public static double cubicmile_TO_cubiccentimeter(double unites)
         {
             return (unites * 4168180000000000);
         }

        public static double cubicmile_TO_cubicmillimeter(double unites)
         {
             return (unites * 4168179999999999500);
         }

        public static double cubicmile_TO_liter(double unites)
         {
             return (unites * 4168180000000);
         }

        public static double cubicmile_TO_milliliter(double unites)
         {
             return (unites * 4168180000000000);
         }

        public static double cubicmile_TO_pint(double unites)
         {
             return (unites * 8808942127242.294);
         }
        public static double cubicmile_TO_quart(double unites)
         {
             return (unites * 4404466409468.7705);
         }
        public static double cubicmile_TO_gallon(double unites)
         {
             return (unites * 1101117184135.9323);
         }

        
        #endregion




        #region cubicmillimeter converters

        public static double cubicmillimeter_TO_cubicmeter(double unites)
         {
             return (unites * 1 * Math.Pow(10,-9));
         }

        public static double cubicmillimeter_TO_cubicfoot(double unites)
         {
             return (unites * 3.531472482766414 * Math.Pow(10,-8));
         }

        public static double cubicmillimeter_TO_cubicyard(double unites)
         {
             return (unites * 1.3079503763627208 * Math.Pow(10,-9));
         }

        public static double cubicmillimeter_TO_cubicinch(double unites)
         {
             return (unites * 0.00006102361003472243);
         }

        public static double cubicmillimeter_TO_cubickilometer(double unites)
         {
             return (unites * 1 * Math.Pow(10,-18));
         }

        public static double cubicmillimeter_TO_cubicmile(double unites)
         {
             return (unites * 2.399128636479231 * Math.Pow(10,-19));
         }

        public static double cubicmillimeter_TO_cubiccentimeter(double unites)
         {
             return (unites * 0.001);
         }

        public static double cubicmillimeter_TO_cubicmillimeter(double unites)
         {
             return (unites * 1);
         }

        public static double cubicmillimeter_TO_liter(double unites)
         {
             return (unites * 0.000001);
         }

        public static double cubicmillimeter_TO_milliliter(double unites)
         {
             return (unites * 0.001);
         }

        public static double cubicmillimeter_TO_pint(double unites)
         {
             return (unites * 0.000002113378531455526);
         }
        public static double cubicmillimeter_TO_quart(double unites)
         {
             return (unites * 0.0000010566881491367387);
         }
        public static double cubicmillimeter_TO_gallon(double unites)
         {
             return (unites * 2.6417217685798897 * Math.Pow(10,-7));
         }

        #endregion


        #region liter converters

        public static double liter_TO_cubicmeter(double unites)
         {
             return (unites * 0.001);
         }

        public static double liter_TO_cubicfoot(double unites)
         {
             return (unites * 0.035314724827664144);
         }

        public static double liter_TO_cubicyard(double unites)
         {
             return (unites * 0.001307950376362721);
         }

        public static double liter_TO_cubicinch(double unites)
         {
             return (unites * 61.02361003472243);
         }

        public static double liter_TO_cubickilometer(double unites)
         {
             return (unites * 1 * Math.Pow(10,-12));
         }

        public static double liter_TO_cubicmile(double unites)
         {
             return (unites * 2.399128636479231 * Math.Pow(10,-13));
         }

        public static double liter_TO_cubiccentimeter(double unites)
         {
             return (unites * 1000.0000000000001);
         }

        public static double liter_TO_cubicmillimeter(double unites)
         {
             return (unites * 1000000);
         }

        public static double liter_TO_liter(double unites)
         {
             return (unites * 1 );
         }

        public static double liter_TO_milliliter(double unites)
         {
             return (unites * 1000.0000000000001);
         }

        public static double liter_TO_pint(double unites)
         {
             return (unites * 2.1133785314555262);
         }
        public static double liter_TO_quart(double unites)
         {
             return (unites * 1.0566881491367385);
         }
        public static double liter_TO_gallon(double unites)
         {
             return (unites * 0.264172176857989);
         }



        #endregion


        #region milliliter converters


        public static double milliliter_TO_cubicmeter(double unites)
         {
             return (unites * 0.000001);
         }

        public static double milliliter_TO_cubicfoot(double unites)
         {
             return (unites * 0.000035314724827664144);
         }

        public static double milliliter_TO_cubicyard(double unites)
         {
             return (unites * 0.0000013079503763627206);
         }

        public static double milliliter_TO_cubicinch(double unites)
         {
             return (unites * 0.061023610034722425);
         }

        public static double milliliter_TO_cubickilometer(double unites)
         {
             return (unites * 9.999999999999998 * Math.Pow(10,-16));
         }

        public static double milliliter_TO_cubicmile(double unites)
         {
             return (unites * 2.3991286364792304 * Math.Pow(10,-16));
         }

        public static double milliliter_TO_cubiccentimeter(double unites)
         {
             return (unites * 1 );
         }

        public static double milliliter_TO_cubicmillimeter(double unites)
         {
             return (unites * 999.9999999999999);
         }

        public static double milliliter_TO_liter(double unites)
         {
             return (unites * 0.001);
         }

        public static double milliliter_TO_milliliter(double unites)
         {
             return (unites * 1);
         }

        public static double milliliter_TO_pint(double unites)
         {
             return (unites * 0.002113378531455526);
         }
        public static double milliliter_TO_quart(double unites)
         {
             return (unites * 0.0010566881491367386);
         }
        public static double milliliter_TO_gallon(double unites)
         {
             return (unites * 0.00026417217685798894);
         }



        #endregion


        #region pint converters


        public static double pint_TO_cubicmeter(double unites)
         {
             return (unites * 0.000473176);
         }

        public static double pint_TO_cubicfoot(double unites)
         {
             return (unites * 0.016710080235054807);
         }

        public static double pint_TO_cubicyard(double unites)
         {
             return (unites * 0.0006188907272858067);
         }

        public static double pint_TO_cubicinch(double unites)
         {
             return (unites * 28.874907701789823);
         }

        public static double pint_TO_cubickilometer(double unites)
         {
             return (unites * 4.73176 * Math.Pow(10,-13));
         }

        public static double pint_TO_cubicmile(double unites)
         {
             return (unites * 1.1352100916946966 * Math.Pow(10, -13));
         }

        public static double pint_TO_cubiccentimeter(double unites)
         {
             return (unites * 473.17600000000004);
         }

        public static double pint_TO_cubicmillimeter(double unites)
         {
             return (unites * 473176);
         }

        public static double pint_TO_liter(double unites)
         {
             return (unites * 0.473176);
         }

        public static double pint_TO_milliliter(double unites)
         {
             return (unites * 473.17600000000004);
         }

        public static double pint_TO_pint(double unites)
         {
             return (unites * 1);
         }
        public static double pint_TO_quart(double unites)
         {
             return (unites * 0.4999994716559254);
         }  
        public static double pint_TO_gallon(double unites)
         {
             return (unites * 0.12499993395695578);
         }



        #endregion



        #region quart converters


        public static double quart_TO_cubicmeter(double unites)
         {
             return (unites * 0.000946353);
         }

        public static double quart_TO_cubicfoot(double unites)
         {
             return (unites * 0.03342019578483445);
         }

        public static double quart_TO_cubicyard(double unites)
         {
             return (unites * 0.00123778276252199);
         }

        public static double quart_TO_cubicinch(double unites)
         {
             return (unites * 57.749876427189676);
         }

        public static double quart_TO_cubickilometer(double unites)
         {
             return (unites * 9.46353 * Math.Pow(10,-13));
         }

        public static double quart_TO_cubicmile(double unites)
         {
             return (unites * 2.2704225825180295 * Math.Pow(10,-13));
         }

        public static double quart_TO_cubiccentimeter(double unites)
         {
             return (unites * 946.3530000000001);
         }

        public static double quart_TO_cubicmillimeter(double unites)
         {
             return (unites * 946353);
         }

        public static double quart_TO_liter(double unites)
         {
             return (unites * 0.946353);
         }

        public static double quart_TO_milliliter(double unites)
         {
             return (unites * 946.3530000000001);
         }

        public static double quart_TO_pint(double unites)
         {
             return (unites * 2.0000021133785313);
         }
        public static double quart_TO_quart(double unites)
         {
             return (unites * 1);
         }
        public static double quart_TO_gallon(double unites)
         {
             return (unites * 0.25000013208608845);
         }



        #endregion



        #region gallon converters

        public static double gallon_TO_cubicmeter(double unites)
         {
             return (unites * 0.00378541);
         }

        public static double gallon_TO_cubicfoot(double unites)
         {
             return (unites * 0.1336807125098881);
         }

        public static double gallon_TO_cubicyard(double unites)
         {
             return (unites * 0.004951128434187207);
         }

        public static double gallon_TO_cubicinch(double unites)
         {
             return (unites * 230.99938366153862);
         }

        public static double gallon_TO_cubickilometer(double unites)
         {
             return (unites * 3.78541 * Math.Pow(10,-12));
         }

        public static double gallon_TO_cubicmile(double unites)
         {
             return (unites * 9.081685531814845 * Math.Pow(10,-13));
         }

        public static double gallon_TO_cubiccentimeter(double unites)
         {
             return (unites * 3785.41);
         }

        public static double gallon_TO_cubicmillimeter(double unites)
         {
             return (unites * 3785409.9999999995);
         }

        public static double gallon_TO_liter(double unites)
         {
             return (unites * 3.7854099999999997);
         }

        public static double gallon_TO_milliliter(double unites)
         {
             return (unites * 3785.41);
         }

        public static double gallon_TO_pint(double unites)
         {
             return (unites * 8.000004226757061);
         }
        public static double gallon_TO_quart(double unites)
         {
             return (unites * 3.9999978866237016);
         }
        public static double gallon_TO_gallon(double unites)
         {
             return (unites * 1);
         }


        #endregion

    }

}
