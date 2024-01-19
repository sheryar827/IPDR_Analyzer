using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPDR_Analyzer.Classes
{
    class LocSummary
    {
        public string Loc { get; set; }

        public double Lat { get; set; }

        public double Lng { get; set; }

        public int Total { get; set; }

        public LocSummary(string Loc, double Lat, double Lng, int Count)
        {
            this.Loc = Loc;
            this.Lat = Lat;
            this.Lng = Lng;
            this.Total = Count;
        }
    }
}
