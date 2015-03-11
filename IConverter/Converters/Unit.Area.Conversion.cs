using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IConverter.Converters
{
    class UnitArea
    {


        /// <summary>
        /// 
        /// </summary>
        /// <param name="Convert_Left_From"></param>
        /// <param name="Convert_Right_To"></param>
        /// <returns></returns>
        public double Convert(string Convert_Left_From, string Convert_Right_To, string Category_Button, double ConvertFrom)
        {

            

            //double dConverter_Units = Convert.ToDouble(txtUnits.Text.ToString());
            if (IConverter.Resources.AppResources.Category_Area.ToUpper() == Category_Button)
            {

                #region Area --> Acre
                //Area Acre
                if (Convert_Left_From == IConverter.Resources.AppResources.UnitCenverer_Area_Acre)
                {
                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitCenverer_Area_Acre)
                    {
                        return Area_Converters.acre_TO_acre(ConvertFrom);
                    }
                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitCenverer_Area_SquareCentimeter)
                    {
                        return Area_Converters.acre_TO_squarecentimeter(ConvertFrom);
                    }
                        
                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitCenverer_Area_SquareFoot)
                    {
                        return Area_Converters.acre_TO_squarefoot(ConvertFrom);
                    }
                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitCenverer_Area_SquareInch)
                    {
                        return Area_Converters.acre_TO_squareinch(ConvertFrom);
                    }
                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitCenverer_Area_SquareKilometer)
                    {
                        return Area_Converters.acre_TO_squarekilometer(ConvertFrom);
                    }
                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitCenverer_Area_SquareMeter)
                    {
                        return Area_Converters.acre_TO_squaremeter(ConvertFrom);
                    }
                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitCenverer_Area_SquareMicrometer)
                    {
                        return Area_Converters.acre_TO_squaremicrometer(ConvertFrom);
                    }
                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitCenverer_Area_SquareMile)
                    {
                        return Area_Converters.acre_TO_squaremile(ConvertFrom);
                    }
                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitCenverer_Area_SquareMillimeter)
                    {
                        return Area_Converters.acre_TO_millimeter(ConvertFrom);
                    }

                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitCenverer_Area_SquareYard)
                    {
                        return Area_Converters.acre_TO_squareyard(ConvertFrom);
                    }


                }
                #endregion

                #region Area --> Squaremicrometer

                if (Convert_Left_From == IConverter.Resources.AppResources.UnitCenverer_Area_SquareMicrometer)
                {
                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitCenverer_Area_Acre)
                    {
                        return Area_Converters.squaremicrometer_TO_acre(ConvertFrom);
                    }
                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitCenverer_Area_SquareCentimeter)
                    {
                        return Area_Converters.squaremicrometer_TO_centimeter(ConvertFrom);
                    }

                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitCenverer_Area_SquareFoot)
                    {
                        return Area_Converters.squaremicrometer_TO_foot(ConvertFrom);
                    }
                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitCenverer_Area_SquareInch)
                    {
                        return Area_Converters.squaremicrometer_TO_inch(ConvertFrom);
                    }
                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitCenverer_Area_SquareKilometer)
                    {
                        return Area_Converters.squaremicrometer_TO_kilometer(ConvertFrom);
                    }
                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitCenverer_Area_SquareMeter)
                    {
                        return Area_Converters.squaremicrometer_TO_meter(ConvertFrom);
                    }
                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitCenverer_Area_SquareMicrometer)
                    {
                        return Area_Converters.squaremicrometer_TO_squaremicrometer(ConvertFrom);
                    }
                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitCenverer_Area_SquareMile)
                    {
                        return Area_Converters.squaremicrometer_TO_mile(ConvertFrom);
                    }
                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitCenverer_Area_SquareMillimeter)
                    {
                        return Area_Converters.squaremicrometer_TO_millimeter(ConvertFrom);
                    }

                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitCenverer_Area_SquareYard)
                    {
                        return Area_Converters.squaremicrometer_TO_yard(ConvertFrom);
                    }


                }


                #endregion


                #region Area --> squaremillimter

                if (Convert_Left_From == IConverter.Resources.AppResources.UnitCenverer_Area_SquareMillimeter)
                {
                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitCenverer_Area_Acre)
                    {
                        return Area_Converters.squaremillimeter_TO_acre(ConvertFrom);
                    }
                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitCenverer_Area_SquareCentimeter)
                    {
                        return Area_Converters.squaremillimeter_TO_squarecentimeter(ConvertFrom);
                    }

                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitCenverer_Area_SquareFoot)
                    {
                        return Area_Converters.squaremillimeter_TO_squarefoot(ConvertFrom);
                    }
                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitCenverer_Area_SquareInch)
                    {
                        return Area_Converters.squaremillimeter_TO_squareinch(ConvertFrom);
                    }
                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitCenverer_Area_SquareKilometer)
                    {
                        return Area_Converters.squaremillimeter_TO_squarekilometer(ConvertFrom);
                    }
                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitCenverer_Area_SquareMeter)
                    {
                        return Area_Converters.squaremillimeter_TO_squaremeter(ConvertFrom);
                    }
                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitCenverer_Area_SquareMicrometer)
                    {
                        return Area_Converters.squaremillimeter_TO_squaremicrometer(ConvertFrom);
                    }
                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitCenverer_Area_SquareMile)
                    {
                        return Area_Converters.squaremillimeter_TO_squaremile(ConvertFrom);
                    }
                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitCenverer_Area_SquareMillimeter)
                    {
                        return Area_Converters.squaremillimeter_TO_squaremillimeter(ConvertFrom);
                    }

                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitCenverer_Area_SquareYard)
                    {
                        return Area_Converters.squaremillimeter_TO_squareyard(ConvertFrom);
                    }


                }


                #endregion

                #region Area --> squarecentimeter

                if (Convert_Left_From == IConverter.Resources.AppResources.UnitCenverer_Area_SquareCentimeter)
                {
                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitCenverer_Area_Acre)
                    {
                        return Area_Converters.squarecentimeter_TO_acre(ConvertFrom);
                    }
                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitCenverer_Area_SquareCentimeter)
                    {
                        return Area_Converters.squarecentimeter_TO_squarecentimeter(ConvertFrom);
                    }

                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitCenverer_Area_SquareFoot)
                    {
                        return Area_Converters.squarecentimeter_TO_squarefoot(ConvertFrom);
                    }
                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitCenverer_Area_SquareInch)
                    {
                        return Area_Converters.squarecentimeter_TO_squareinch(ConvertFrom);
                    }
                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitCenverer_Area_SquareKilometer)
                    {
                        return Area_Converters.squarecentimeter_TO_squarekilometer(ConvertFrom);
                    }
                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitCenverer_Area_SquareMeter)
                    {
                        return Area_Converters.squarecentimeter_TO_squaremeter(ConvertFrom);
                    }
                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitCenverer_Area_SquareMicrometer)
                    {
                        return Area_Converters.squarecentimeter_TO_squaremicrometer(ConvertFrom);
                    }
                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitCenverer_Area_SquareMile)
                    {
                        return Area_Converters.squarecentimeter_TO_squaremile(ConvertFrom);
                    }
                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitCenverer_Area_SquareMillimeter)
                    {
                        return Area_Converters.squarecentimeter_TO_squaremillimter(ConvertFrom);
                    }

                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitCenverer_Area_SquareYard)
                    {
                        return Area_Converters.squarecentimeter_TO_squareyard(ConvertFrom);
                    }


                }


                #endregion

                #region Area --> squaremile

                if (Convert_Left_From == IConverter.Resources.AppResources.UnitCenverer_Area_SquareMile)
                {
                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitCenverer_Area_Acre)
                    {
                        return Area_Converters.squaremile_TO_acre(ConvertFrom);
                    }
                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitCenverer_Area_SquareCentimeter)
                    {
                        return Area_Converters.squaremile_TO_squarecentimeter(ConvertFrom);
                    }

                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitCenverer_Area_SquareFoot)
                    {
                        return Area_Converters.squaremile_TO_squarefoot(ConvertFrom);
                    }
                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitCenverer_Area_SquareInch)
                    {
                        return Area_Converters.squaremile_TO_squareinch(ConvertFrom);
                    }
                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitCenverer_Area_SquareKilometer)
                    {
                        return Area_Converters.squaremile_TO_squarekilometer(ConvertFrom);
                    }
                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitCenverer_Area_SquareMeter)
                    {
                        return Area_Converters.squaremile_TO_squaremeter(ConvertFrom);
                    }
                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitCenverer_Area_SquareMicrometer)
                    {
                        return Area_Converters.squaremile_TO_squaremicrometer(ConvertFrom);
                    }
                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitCenverer_Area_SquareMile)
                    {
                        return Area_Converters.squaremile_TO_squaremile(ConvertFrom);
                    }
                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitCenverer_Area_SquareMillimeter)
                    {
                        return Area_Converters.squaremile_TO_squaremillimter(ConvertFrom);
                    }

                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitCenverer_Area_SquareYard)
                    {
                        return Area_Converters.squaremile_TO_squareyard(ConvertFrom);
                    }


                }


                #endregion


                #region Area --> squarekilometer

                if (Convert_Left_From == IConverter.Resources.AppResources.UnitCenverer_Area_SquareKilometer)
                {
                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitCenverer_Area_Acre)
                    {
                        return Area_Converters.squarekilometer_TO_acre(ConvertFrom);
                    }
                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitCenverer_Area_SquareCentimeter)
                    {
                        return Area_Converters.squarekilometer_TO_squarecentimeter(ConvertFrom);
                    }

                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitCenverer_Area_SquareFoot)
                    {
                        return Area_Converters.squarekilometer_TO_squarefoot(ConvertFrom);
                    }
                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitCenverer_Area_SquareInch)
                    {
                        return Area_Converters.squarekilometer_TO_squareinch(ConvertFrom);
                    }
                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitCenverer_Area_SquareKilometer)
                    {
                        return Area_Converters.squarekilometer_TO_squarekilometer(ConvertFrom);
                    }
                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitCenverer_Area_SquareMeter)
                    {
                        return Area_Converters.squarekilometer_TO_squaremeter(ConvertFrom);
                    }
                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitCenverer_Area_SquareMicrometer)
                    {
                        return Area_Converters.squarekilometer_TO_squaremicrometer(ConvertFrom);
                    }
                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitCenverer_Area_SquareMile)
                    {
                        return Area_Converters.squarekilometer_TO_squaremile(ConvertFrom);
                    }
                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitCenverer_Area_SquareMillimeter)
                    {
                        return Area_Converters.squarekilometer_TO_squaremillimter(ConvertFrom);
                    }

                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitCenverer_Area_SquareYard)
                    {
                        return Area_Converters.squarekilometer_TO_squareyard(ConvertFrom);
                    }


                }


                #endregion


                #region Area --> squareinch

                if (Convert_Left_From == IConverter.Resources.AppResources.UnitCenverer_Area_SquareInch)
                {
                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitCenverer_Area_Acre)
                    {
                        return Area_Converters.squareinch_TO_acre(ConvertFrom);
                    }
                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitCenverer_Area_SquareCentimeter)
                    {
                        return Area_Converters.squareinch_TO_squarecentimeter(ConvertFrom);
                    }

                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitCenverer_Area_SquareFoot)
                    {
                        return Area_Converters.squareinch_TO_squarefoot(ConvertFrom);
                    }
                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitCenverer_Area_SquareInch)
                    {
                        return Area_Converters.squareinch_TO_squareinch(ConvertFrom);
                    }
                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitCenverer_Area_SquareKilometer)
                    {
                        return Area_Converters.squareinch_TO_squarekilometer(ConvertFrom);
                    }
                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitCenverer_Area_SquareMeter)
                    {
                        return Area_Converters.squareinch_TO_squaremeter(ConvertFrom);
                    }
                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitCenverer_Area_SquareMicrometer)
                    {
                        return Area_Converters.squareinch_TO_squaremicrometer(ConvertFrom);
                    }
                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitCenverer_Area_SquareMile)
                    {
                        return Area_Converters.squareinch_TO_squaremile(ConvertFrom);
                    }
                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitCenverer_Area_SquareMillimeter)
                    {
                        return Area_Converters.squareinch_TO_squaremillimter(ConvertFrom);
                    }

                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitCenverer_Area_SquareYard)
                    {
                        return Area_Converters.squareinch_TO_squareyard(ConvertFrom);
                    }


                }


                #endregion


                #region Area --> squareyard

                if (Convert_Left_From == IConverter.Resources.AppResources.UnitCenverer_Area_SquareYard)
                {
                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitCenverer_Area_Acre)
                    {
                        return Area_Converters.squareyard_TO_acre(ConvertFrom);
                    }
                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitCenverer_Area_SquareCentimeter)
                    {
                        return Area_Converters.squareyard_TO_squarecentimeter(ConvertFrom);
                    }

                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitCenverer_Area_SquareFoot)
                    {
                        return Area_Converters.squareyard_TO_squarefoot(ConvertFrom);
                    }
                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitCenverer_Area_SquareInch)
                    {
                        return Area_Converters.squareyard_TO_squareinch(ConvertFrom);
                    }
                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitCenverer_Area_SquareKilometer)
                    {
                        return Area_Converters.squareyard_TO_squarekilometer(ConvertFrom);
                    }
                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitCenverer_Area_SquareMeter)
                    {
                        return Area_Converters.squareyard_TO_squaremeter(ConvertFrom);
                    }
                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitCenverer_Area_SquareMicrometer)
                    {
                        return Area_Converters.squareyard_TO_squaremicrometer(ConvertFrom);
                    }
                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitCenverer_Area_SquareMile)
                    {
                        return Area_Converters.squareyard_TO_squaremile(ConvertFrom);
                    }
                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitCenverer_Area_SquareMillimeter)
                    {
                        return Area_Converters.squareyard_TO_squaremillimter(ConvertFrom);
                    }

                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitCenverer_Area_SquareYard)
                    {
                        return Area_Converters.squareyard_TO_squareyard(ConvertFrom);
                    }


                }


                #endregion


                #region Area --> squarefoot

                if (Convert_Left_From == IConverter.Resources.AppResources.UnitCenverer_Area_SquareFoot)
                {
                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitCenverer_Area_Acre)
                    {
                        return Area_Converters.squarefoot_TO_acre(ConvertFrom);
                    }
                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitCenverer_Area_SquareCentimeter)
                    {
                        return Area_Converters.squarefoot_TO_squarecentimeter(ConvertFrom);
                    }

                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitCenverer_Area_SquareFoot)
                    {
                        return Area_Converters.squarefoot_TO_squarefoot(ConvertFrom);
                    }
                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitCenverer_Area_SquareInch)
                    {
                        return Area_Converters.squarefoot_TO_squareinch(ConvertFrom);
                    }
                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitCenverer_Area_SquareKilometer)
                    {
                        return Area_Converters.squarefoot_TO_squarekilometer(ConvertFrom);
                    }
                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitCenverer_Area_SquareMeter)
                    {
                        return Area_Converters.squarefoot_TO_squaremeter(ConvertFrom);
                    }
                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitCenverer_Area_SquareMicrometer)
                    {
                        return Area_Converters.squarefoot_TO_squaremicrometer(ConvertFrom);
                    }
                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitCenverer_Area_SquareMile)
                    {
                        return Area_Converters.squarefoot_TO_squaremile(ConvertFrom);
                    }
                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitCenverer_Area_SquareMillimeter)
                    {
                        return Area_Converters.squarefoot_TO_squaremillimter(ConvertFrom);
                    }

                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitCenverer_Area_SquareYard)
                    {
                        return Area_Converters.squarefoot_TO_squareyard(ConvertFrom);
                    }
                    
                }


                #endregion


                #region Area --> squaremeter

                if (Convert_Left_From == IConverter.Resources.AppResources.UnitCenverer_Area_SquareMeter)
                {
                    if (Convert_Right_To == IConverter.Resources.AppResources.UnitCenverer_Area_Acre)
                    {
                        return Area_Converters.squaremeter_TO_acre(ConvertFrom);
                    }
                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitCenverer_Area_SquareCentimeter)
                    {
                        return Area_Converters.squaremeter_TO_squarecentimeter(ConvertFrom);
                    }

                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitCenverer_Area_SquareFoot)
                    {
                        return Area_Converters.squaremeter_TO_squarefoot(ConvertFrom);
                    }
                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitCenverer_Area_SquareInch)
                    {
                        return Area_Converters.squaremeter_TO_squareinch(ConvertFrom);
                    }
                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitCenverer_Area_SquareKilometer)
                    {
                        return Area_Converters.squaremeter_TO_squarekilometer(ConvertFrom);
                    }
                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitCenverer_Area_SquareMeter)
                    {
                        return Area_Converters.squaremeter_TO_squaremeter(ConvertFrom);
                    }
                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitCenverer_Area_SquareMicrometer)
                    {
                        return Area_Converters.squaremeter_TO_squaremicrometer(ConvertFrom);
                    }
                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitCenverer_Area_SquareMile)
                    {
                        return Area_Converters.squaremeter_TO_squaremile(ConvertFrom);
                    }
                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitCenverer_Area_SquareMillimeter)
                    {
                        return Area_Converters.squaremeter_TO_squaremillimter(ConvertFrom);
                    }

                    else if (Convert_Right_To == IConverter.Resources.AppResources.UnitCenverer_Area_SquareYard)
                    {
                        return Area_Converters.squaremeter_TO_squareyard(ConvertFrom);
                    }

                }


                #endregion

            }



            return 0.0;
        }
    }

    }

