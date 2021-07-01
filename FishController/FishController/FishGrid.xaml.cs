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
    /// Interaction logic for FishGrid.xaml
    /// </summary>
    public partial class FishGrid : Page
    {
        public FishGrid(string fishType, int maxTemperature, int maxExcessTemperature, int minTemperature, int minExcessTemperature, List<TemperatureDate> temperature)
        {
            InitializeComponent();
            TBFishType.Text += fishType;
            TBMaxTemperature.Text += $"{maxTemperature} Время: {maxExcessTemperature} минут";
            TBMinTemperature.Text += $"{minTemperature} Время: {minExcessTemperature} минут";
            TBDate.Text += DateTime.Now;
            foreach(TemperatureDate c in temperature)
            {
                TBTemperatureArray.Text += c.temperature + " ";
            }

            List<Fish> fish = new List<Fish>();
            for (int i = 0; i < temperature.Count; i++)
            {
                if (temperature[i].temperature > maxTemperature)
                {
                    fish.Add(new Fish(temperature[i].date, temperature[i].temperature, maxTemperature, temperature[i].temperature - maxTemperature));
                }
                if(temperature[i].temperature < minTemperature)
                {
                    fish.Add(new Fish(temperature[i].date, temperature[i].temperature, minTemperature, temperature[i].temperature + minTemperature));
                }
            }
            DGFishData.ItemsSource = fish;
        }
    }
}
