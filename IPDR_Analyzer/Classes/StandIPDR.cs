using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Web.Services.Description;
namespace IPDR_Analyzer.Classes
{
    public class StandIPDR
    {
        public string Number { get; set; }
        public string Date { get; set; }

        public string Time { get; set; }

        public string Dur { get; set; }

        public string Protocol { get; set; }    

        public string Source_IP { get; set; }

        public string Source_PORT { get; set; }

        public string Dest_IP { get; set; }

        public string Dest_PORT { get; set; }

        public string App { get; set; }

        public string Up { get; set; }

        public string Down { get; set; }

        public string Location { get; set; }

        public double Latitude { get; set; }

        public double Longitude { get; set; }

        public string Weekday { get; set; }
    }
}
