using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPDR_Analyzer.Classes
{
    class GetSqlDRAndConn
    {
        public SqlConnection sqlConn { get; set; }
        public SqlDataReader sqlDR { get; set; }

        public GetSqlDRAndConn(SqlConnection sqlConn, SqlDataReader sqlDR)
        {
            this.sqlConn = sqlConn;
            this.sqlDR = sqlDR;
        }
    }
}
