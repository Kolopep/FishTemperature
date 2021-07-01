using System;
using System.Collections.Generic;
using System.Text;

namespace FishController
{
    public class TemperatureDate
    {
        public int temperature;
        public DateTime date;
        public TemperatureDate(int temperature, DateTime date)
        {
            this.temperature = temperature;
            this.date = date;
        }
    }
}
