using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPDR_Analyzer.Classes
{
    class AppSummary
    {
        public string App { get; set; }
        public int Total { get; set; }

        public AppSummary(string appName, int totalCount) { 
            this.App = appName;
            this.Total = totalCount;
        }
    }
}
