using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace IPDR_Analyzer.Classes
{
    class TopAppCallSec
    {
        public string App { get; set; }
        public string AppCallMin { get; set; }
        public long AppCallSec { get; set; }


        public TopAppCallSec(string App, string AppCallMin, int AppCallSec)
        {
            this.App = App;
            this.AppCallMin = AppCallMin;
            this.AppCallSec = AppCallSec;
        }
    }
}
