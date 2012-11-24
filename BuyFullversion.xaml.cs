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
using Microsoft.Phone.Tasks;
using Microsoft.Phone.Marketplace;

namespace Oktoberfest
{
    public partial class BuyFullversion : PhoneApplicationPage
    {
        public BuyFullversion()
        {
            InitializeComponent();


        }

        private void GoToMainPage()
        {
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.RelativeOrAbsolute));
        }


        private void button1_Click(object sender, RoutedEventArgs e)
        {
            MarketplaceDetailTask detailTask = new MarketplaceDetailTask();
            detailTask.Show();
        }


        private void button2_Click(object sender, RoutedEventArgs e)
        {
            GoToMainPage();
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            LicenseInformation lic = new LicenseInformation();

            if (!lic.IsTrial())
            {
                GoToMainPage();
            }
        }

    }
}