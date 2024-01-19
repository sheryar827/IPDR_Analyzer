using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPDR_Analyzer.Classes
{
    class TopLocations
    {
        public string Loc { get; set; }
        
        public int Total { get; set; }

        public TopLocations(string Loc, int Total)
        {
            this.Loc = Loc;
            this.Total = Total;
        }

    }
}
