using System;
using System.Collections.Generic;
using System.Text;

namespace FishController
{
    public class Fish
    {
        public DateTime Date { get; set; }
        public int Fact { get; set; }
        public int Normal { get; set; }
        public int Deviation { get; set; }
        public Fish(DateTime Date, int Fact, int Normal, int Deviation)
        {
            this.Date = Date;
            this.Fact = Fact;
            this.Normal = Normal;
            this.Deviation = Deviation;
        }
    }
}
