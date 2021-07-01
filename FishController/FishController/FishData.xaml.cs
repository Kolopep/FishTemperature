using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FishController
{
    /// <summary>
    /// Interaction logic for FishData.xaml
    /// </summary>
    public partial class FishData : Page
    {
        List<TemperatureDate> temperatureArray = new List<TemperatureDate>();
        public FishData()
        {
            InitializeComponent();
        }

        private void BSubmit_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                NavigationService.Navigate(new FishGrid(TBFishType.Text, Convert.ToInt32(TBMaxTemperature.Text), Convert.ToInt32(TBMaxExcessTemperature.Text), Convert.ToInt32(TBMinTemperature.Text), Convert.ToInt32(TBMinExcessTemperature.Text), temperatureArray));
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void BAddTemperatur_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                temperatureArray.Add(new TemperatureDate(Convert.ToInt32(TBTemperatureArray.Text), Convert.ToDateTime(TBDateArray.Text)));
                TBInfoTemperatureArray.Text += "Температура: " + TBTemperatureArray.Text + "\n" + "Время: " + Convert.ToDateTime(TBDateArray.Text) + "\n\n";
                TBTemperatureArray.Text = null;
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
    }
}
