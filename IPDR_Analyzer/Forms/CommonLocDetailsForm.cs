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
        public CommonLocDetailsForm(DataTable specificLatLngRecord)
        {
            InitializeComponent();
            gvCommonSpecificLatLngDetail.DataSource = specificLatLngRecord;
        }
    }
}
