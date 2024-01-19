using IPDR_Analyzer.Classes;
using System;
using System.Collections.Generic;

namespace IPDR_Analyzer.Forms
{
    class Common
    {
        public static string userName = null;
        public const string datef = "MM-dd-yyyy";
        public const string timef = "HH:mm:ss";
        public const string ipdrDBTable = "network_logs";
        public const string projectTableNumber = "ProjectsTableNumber";
        public static List<StandIPDR> allRecordNum = null;
        public static string numForAnalysis = null;
        public static string project_Name = null;

        public static TimeSpan mStart = Convert.ToDateTime("08:00:00").TimeOfDay;
        public static TimeSpan mEnd = Convert.ToDateTime("15:59:59").TimeOfDay;
        public static TimeSpan dStart = Convert.ToDateTime("16:00:00").TimeOfDay;
        public static TimeSpan dEnd = Convert.ToDateTime("23:59:59").TimeOfDay;
        public static TimeSpan eStart = Convert.ToDateTime("00:00:00").TimeOfDay;
        public static TimeSpan eEnd = Convert.ToDateTime("07:59:59").TimeOfDay;

        public const string NoRecord = "No Record Found!!";
    }
}
