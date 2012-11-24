using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Marketplace;

namespace Oktoberfest
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Set the data context of the listbox control to the sample data
            DataContext = App.ViewModel;
            this.Loaded += new RoutedEventHandler(MainPage_Loaded);

            
        }

        // Load data for the ViewModel Items
        private void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            if (!App.ViewModel.IsDataLoaded)
            {
                App.ViewModel.LoadData();
            }
        }

        private void Canvas_MouseLeftButtonDown(object sender, RoutedEventArgs e)
        {
            border1.Visibility = Visibility.Collapsed;
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            textBlock1.Text = ((Button)(sender)).Tag.ToString();
            border1.Visibility = Visibility.Visible;
        }

        //private void button1_Click(object sender, RoutedEventArgs e)
        //{
        //    border1.Visibility = Visibility.Collapsed;
        //}




        private void panoramaControl_ManipulationStarted(object sender, ManipulationStartedEventArgs e)
        {
            LicenseInformation lic = new LicenseInformation();
            if (lic.IsTrial())
            {
                if (panoramaControl.SelectedIndex >= 2)
                {
                    NavigationService.Navigate(new Uri("/BuyFullversion.xaml", UriKind.RelativeOrAbsolute));
                }
            }


        }



    }
}