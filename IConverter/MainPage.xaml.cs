using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using IConverter.Converters;
using System.Threading;
using System.Threading.Tasks;
using System.ComponentModel;


namespace IConverter
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Url of Home page
        private string MainUri = "/Html/index.html";
        bool Button_Inverted = false;
        Button Left_button_Prev;
        Button Right_button_Prev;
        string Category_Button = null;

        
        public delegate void CurrencyDelegateAsync(IAsyncResult ar);
        CurrencyConverter convert = new CurrencyConverter();
        

        System.Windows.Media.SolidColorBrush Yellowbrush = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Colors.Yellow);
        System.Windows.Media.SolidColorBrush Blackbrush = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Colors.Black);
        System.Windows.Media.SolidColorBrush Silverbrush = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Colors.LightGray);
        System.Windows.Media.SolidColorBrush Redbrush = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Colors.Red);
        System.Windows.Media.SolidColorBrush whitebrush = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Colors.White);

        Converters.UnitArea areaConvert = new UnitArea();
        Converters.UnitVolume volumeConvert = new UnitVolume();
        Converters.UnitLength lengthConvert = new UnitLength();
        Converters.UnitWeight weightConvert = new UnitWeight();
        Converters.UnitTemp tempConvert = new UnitTemp();
        Converters.UnitTime timeConvert = new UnitTime();


        public Button CategoriesPrev_Button { set; get; }

        public Button Categories_Button { set;  get; }

        public double Currency_Rate { set; get; }
        
        public bool Getting_Currency_Rate { set; get; }


        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void Browser_Loaded(object sender, RoutedEventArgs e)
        {

           
            // Add your URL here
            Browser.Navigate(new Uri(MainUri, UriKind.Relative));
            Browser.IsScriptEnabled = true;
            
            foreach (string category in Converter_Data.getListOfCategories())
            {

                                
                Button CategoryButton = new Button();
                                              
                CategoryButton.Content = category;
               // CategoryButton.Width = category.Length * 1.0;
                CategoryButton.Height =80;
                CategoryButton.BorderBrush = whitebrush;
                CategoryButton.ClickMode = ClickMode.Press;
                CategoryButton.HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
                CategoryButton.FontSize = 25;
                CategoryButton.FontStretch = FontStretches.Expanded;
                CategoryButton.Name = category;
                CategoryButton.BorderThickness = new Thickness(0.0);
               
                
                
                CategoryButton.Tap += CategoryButton_Tap;
                
                this.CategoriesList.Items.Add(CategoryButton);
               

               // CurrencyConverter test = new CurrencyConverter();
              //  test.Mytest();
                              
            }


        }

        


        void CategoryButton_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            
             this.Categories_Button = sender as Button;

             if (this.CategoriesPrev_Button == null)
             {
                 this.Categories_Button.Foreground =  Yellowbrush;
                 
                 this.CategoriesPrev_Button = this.Categories_Button; 
             }
             else
             {
                 if (this.Categories_Button == this.CategoriesPrev_Button)
                 {
                     this.Categories_Button.Foreground = whitebrush;

                     this.CategoriesPrev_Button = null;
                    
                 }
                 else
                 {
                     this.CategoriesPrev_Button.Foreground = Yellowbrush;
                     this.Categories_Button.Foreground = whitebrush;
                     this.CategoriesPrev_Button = this.Categories_Button;
                     
                 }

                 //this.Categories_Button.Background = Blackbrush;
              
             }

                         
             Fill_Categories_bar();
        }



        /// <summary>
        /// 
        /// </summary>
        void Fill_Categories_bar()
        {

            this.Left_button_Prev = null;
            this.Right_button_Prev = null;
           

            this.ConvertItems_Left.Items.Clear();
           // this.ConvertItems_Right.Items.Clear();

            Category_Button = Categories_Button.Content.ToString().ToUpper();

            if (Categories_Button.Content.ToString().ToUpper() == IConverter.Resources.AppResources.Category_Length.ToUpper())
            {
            //    Category_Button = Categories_Button.Content.ToString().ToUpper();
                foreach (string unit in Converter_Data.getListOfLengthItems())
                {
                    Fill_UnitConverter_LeftSidebar(this.ConvertItems_Left, unit);
                   // Fill_UnitConverter_RightSidebar(this.ConvertItems_Right, unit);
                }

            }


            if (Categories_Button.Content.ToString().ToUpper() == IConverter.Resources.AppResources.Category_Temperature.ToUpper())
            {              
                foreach (string unit in Converter_Data.getListofTemperatureItems())
                {
                    Fill_UnitConverter_LeftSidebar(this.ConvertItems_Left, unit);
                  //  Fill_UnitConverter_RightSidebar(this.ConvertItems_Right, unit);
                }

            }

            if (Categories_Button.Content.ToString().ToUpper() == IConverter.Resources.AppResources.Category_Area.ToUpper())
            {
               
                foreach (string unit in Converter_Data.getListOfAreaItems())
                {
                    Fill_UnitConverter_LeftSidebar(this.ConvertItems_Left, unit);
                   // Fill_UnitConverter_RightSidebar(this.ConvertItems_Right, unit);
                }
            }


            if (Categories_Button.Content.ToString().ToUpper() == IConverter.Resources.AppResources.Category_Volume.ToUpper())
            {
               
                foreach (string unit in Converter_Data.getListOfVolumeItems())
                {
                    Fill_UnitConverter_LeftSidebar(this.ConvertItems_Left, unit);
                  //  Fill_UnitConverter_RightSidebar(this.ConvertItems_Right, unit);
                }
            }



            if (Categories_Button.Content.ToString().ToUpper() == IConverter.Resources.AppResources.Category_Weight.ToUpper())
            {
                
                foreach (string unit in Converter_Data.getListOfWeightItems())
                {
                    Fill_UnitConverter_LeftSidebar(this.ConvertItems_Left, unit);
                 //   Fill_UnitConverter_RightSidebar(this.ConvertItems_Right, unit);
                }
            }


            if (Categories_Button.Content.ToString().ToUpper() == IConverter.Resources.AppResources.Category_Time.ToUpper())
            {

                foreach (string unit in Converter_Data.getListOfTimeItems())
                {
                    Fill_UnitConverter_LeftSidebar(this.ConvertItems_Left, unit);
                  //  Fill_UnitConverter_RightSidebar(this.ConvertItems_Right, unit);
                }
            }


            if (Categories_Button.Content.ToString().ToUpper() == IConverter.Resources.AppResources.Category_Currency.ToUpper())
            {

                foreach (string unit in Converter_Data.getListOfCurrencies())
                {
                    Fill_UnitConverter_LeftSidebar(this.ConvertItems_Left, unit);
                }
               
               this.txtDisplay.Text = "";
               this.Currency_Rate = 0;
               BackgroundWorker BackWorkerThread = new BackgroundWorker();

               BackWorkerThread.DoWork += new DoWorkEventHandler(BackWorkerThread_DoWork);
               BackWorkerThread.RunWorkerAsync();
               BackWorkerThread.RunWorkerCompleted += new RunWorkerCompletedEventHandler(BackWorkerThread_RunWorkerCompleted);
          
                this.Getting_Currency_Rate = true;
                
              //  this.txtDisplay.Text = convert.CONVERT_RATE.ToString();


            }

        }

        void BackWorkerThread_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            
            this.txtDisplay.Text = Convert.ToString(this.Currency_Rate);
        }

        private void BackWorkerThread_DoWork(object sender, DoWorkEventArgs e)
        {
            
          
           // this.txtDisplay.Text = "Please wait";              
          convert.GetGoogleConvertRate("USD", "EGP");
          this.Currency_Rate = convert.CONVERT_RATE;  
            
          
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ConvertItmesbar"></param>
        void Fill_UnitConverter_LeftSidebar(ListBox ConvertItmesbar, string unit)
        {

            Button Unit_Button = new Button();
            Unit_Button.Content = unit;
            Unit_Button.Name = unit + "_left";
            Unit_Button.Width = 480;
            Unit_Button.Height = 100;

            Unit_Button.HorizontalAlignment = System.Windows.HorizontalAlignment.Center;
           // Unit_Button.VerticalAlignment = System.Windows.VerticalAlignment.Center;
            
            Unit_Button.FontSize = 25;
            Unit_Button.FontStretch = FontStretches.Expanded;
            Unit_Button.BorderThickness = new Thickness(0,0,0,0);
            Unit_Button.Padding = new Thickness(0.0);
            Unit_Button.CharacterSpacing = 0;
            Unit_Button.UseLayoutRounding = true;

            Unit_Button.Tap += Unit_Left_Button_Tap;
            ConvertItmesbar.Items.Add(Unit_Button);

        }

    

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ConvertItmesbar"></param>
        void Fill_UnitConverter_RightSidebar(ListBox ConvertItmesbar, string unit)
        {

            Button Unit_Right_Button = new Button();
            Unit_Right_Button.Content = unit;
            Unit_Right_Button.Name = unit + "_right";
            Unit_Right_Button.Width = 120;
            Unit_Right_Button.Height = 60;

            Unit_Right_Button.HorizontalAlignment = System.Windows.HorizontalAlignment.Right;
            Unit_Right_Button.VerticalAlignment = System.Windows.VerticalAlignment.Center;
            Unit_Right_Button.FontSize = 15;
            Unit_Right_Button.BorderThickness = new Thickness(0,0,0,0);
            Unit_Right_Button.Padding = new Thickness(0.0);
            Unit_Right_Button.CharacterSpacing = 0;
            Unit_Right_Button.UseLayoutRounding = true;
            

            Unit_Right_Button.Tap += Unit_Right_Button_Tap;
            ConvertItmesbar.Items.Add(Unit_Right_Button);

        }




        void Unit_Right_Button_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
           
            Button curr = sender as Button;

            if (this.Right_button_Prev == null)
            {

                curr.Background = Redbrush;
                curr.Foreground = Silverbrush;
                this.Right_button_Prev = curr;
            }
            else
            {
                if (curr == this.Right_button_Prev)
                {

                    this.Right_button_Prev.Background = Silverbrush;
                    this.Right_button_Prev.Foreground = whitebrush;
                    this.Right_button_Prev = null; //reset to default case

                }
                else
                {
                    this.Right_button_Prev.Background = Silverbrush;
                    this.Right_button_Prev.Foreground = whitebrush;
                    curr.Background = Redbrush;
                    curr.Foreground = Silverbrush;
                    this.Right_button_Prev = curr;
                    
                }
            }
                        
          
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void Unit_Left_Button_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {

            Button curr = sender as Button;

            if (this.Left_button_Prev == null)
            {

                curr.Background = Redbrush;
                curr.Foreground = Silverbrush;
                this.Left_button_Prev = curr;
            }
            else
            {
                if (curr == this.Left_button_Prev)
                {

                    this.Left_button_Prev.Background = Silverbrush;
                    this.Left_button_Prev.Foreground = whitebrush;
                    this.Left_button_Prev = null; //reset to default case

                }
                else
                {
                    this.Left_button_Prev.Background = Silverbrush;
                    this.Left_button_Prev.Foreground = whitebrush;
                    curr.Background = Redbrush;
                    curr.Foreground = Silverbrush;
                    this.Left_button_Prev = curr;

                }
            }
           // if (!string.IsNullOrEmpty(this.Left_button_Prev.Content.ToString()))
                //this.txtDisplay_Info.Text += this.Left_button_Prev.Content.ToString();    
        }

        

        // Navigates back in the web browser's navigation stack, not the applications.
        private void BackApplicationBar_Click(object sender, EventArgs e)
        {
            Browser.GoBack();
        }

        // Navigates forward in the web browser's navigation stack, not the applications.
        private void ForwardApplicationBar_Click(object sender, EventArgs e)
        {
            Browser.GoForward();
        }

        // Navigates to the initial "home" page.
        private void HomeMenuItem_Click(object sender, EventArgs e)
        {
            Browser.Navigate(new Uri(MainUri, UriKind.Relative));
        }

        // Handle navigation failures.
        private void Browser_NavigationFailed(object sender, System.Windows.Navigation.NavigationFailedEventArgs e)
        {
            MessageBox.Show("Navigation to this page failed, check your internet connection");
        }

        private void ConvertItems_Left_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MessageBox.Show("Testing Item got changed");
        }





        private void Convert_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {

            double ConvertionResult = 0.0;
            string selectCategory = this.Categories_Button.Content.ToString().ToUpper();

            if (!string.IsNullOrEmpty(txtDisplay.Text))
            {
              // if (this.pre
            }

            try
            {
                double unitsToConvert = Convert.ToDouble(this.txtInput.Text);

                if (selectCategory == IConverter.Resources.AppResources.Category_Area.ToString().ToUpper())
                {
                    ConvertionResult = areaConvert.Convert((string)this.Left_button_Prev.Content, (string)this.Right_button_Prev.Content, this.Category_Button, unitsToConvert);
                }


                if (selectCategory == IConverter.Resources.AppResources.Category_Volume.ToString().ToUpper())
                {
                    ConvertionResult = volumeConvert.Convert((string)this.Left_button_Prev.Content, (string)this.Right_button_Prev.Content, this.Category_Button, unitsToConvert);
                }


                if (selectCategory == IConverter.Resources.AppResources.Category_Weight.ToString().ToUpper())
                {
                    ConvertionResult = weightConvert.Convert((string)this.Left_button_Prev.Content, (string)this.Right_button_Prev.Content, this.Category_Button, unitsToConvert);
                }


                if (selectCategory == IConverter.Resources.AppResources.Category_Temperature.ToString().ToUpper())
                {
                    ConvertionResult = tempConvert.Convert((string)this.Left_button_Prev.Content, (string)this.Right_button_Prev.Content, this.Category_Button, unitsToConvert);
                }

                if (selectCategory == IConverter.Resources.AppResources.Category_Length.ToString().ToUpper())
                {
                    ConvertionResult = lengthConvert.Convert((string)this.Left_button_Prev.Content, (string)this.Right_button_Prev.Content, this.Category_Button, unitsToConvert);
                }


                if (selectCategory == IConverter.Resources.AppResources.Category_Time.ToString().ToUpper())
                {
                    ConvertionResult = timeConvert.Convert((string)this.Left_button_Prev.Content, (string)this.Right_button_Prev.Content, this.Category_Button, unitsToConvert);
                }

                if (selectCategory == IConverter.Resources.AppResources.Category_Currency.ToString().ToUpper())
                {
                    ConvertionResult = timeConvert.Convert((string)this.Left_button_Prev.Content, (string)this.Right_button_Prev.Content, this.Category_Button, unitsToConvert);
                }

                
                this.txtDisplay.Text = Convert.ToString(ConvertionResult);
            }
            catch (SystemException sysEx)
            {
                this.txtDisplay.Text = "ERROR";
            }


        }




 
        private void txtDisplay_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            this.txtDisplay.Background = Blackbrush;
            this.txtDisplay.Text = "";
        }

        private void txtDisplay_TextInputStart(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            this.txtDisplay.Background = Blackbrush;
        }

        private void BtnConvert_Click(object sender, RoutedEventArgs e)
        {

        }
      

        
   
           
    }
}