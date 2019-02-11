using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace LabNumber27
{
    /// <summary>
    /// Interaction logic for ForecastInfo.xaml
    /// </summary>
    public partial class ForecastInfo : Window
    {
        
        public ForecastInfo()
        {
            InitializeComponent();
        }

        
        private async void loadForecastInfo_Click(object sender, RoutedEventArgs e)
        {
            var forecastInfo = await ForecastProcessor.LoadForecastInformation();

            latitudeText.Text = $"Latitude is { forecastInfo.Latitude.ToLocalTime().ToShortTimeString()}";
            longitudeText.Text = $"Longitude is { forecastInfo.Longitude.ToLocalTime().ToShortTimeString()}";
        }
    }
}
