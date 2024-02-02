using IPDR_Analyzer.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPDR_Analyzer.Forms
{
    public partial class CommonLocDetailsForm : Form
    {
        //List<StandIPDR> matchingRecords = new List<StandIPDR>();

        public CommonLocDetailsForm(DataTable specificLatLngRecord
            , List<StandIPDR> mr)
        {
            InitializeComponent();

            gvCommonSpecificLatLngDetail.DataSource = specificLatLngRecord;
            gvLocation.DataSource = mr;
        }

        
    }
}
