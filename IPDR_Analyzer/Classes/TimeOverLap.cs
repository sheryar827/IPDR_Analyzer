using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPDR_Analyzer.Classes
{
    public class TimeOverLap
    {
        public string Number { get; set; }
        
        public string Date { get; set; }
        public string StartTime { get; set; } = string.Empty;
        public string EndTime { get; set; } = string.Empty;

        public string loc { get; set; } = string.Empty;

        public double Lat {  get; set; }

        public double Lng { get; set; }

        public TimeOverLap(string number
            , string date
            , string startdate
            , string enddate
            , string loc
            , double lat
            , double lng) { 
        
            this.Number = number;
            this.Date = date;
            this.StartTime = startdate;
            this.EndTime = enddate;
            this.loc = loc;
            this.Lat = lat;
            this.Lng = lng;
        }


    }
}
