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
    public partial class AddCaseForm : Form
    {
        public AddCaseForm()
        {
            InitializeComponent();
            getProjectCases();
            
        }

        private async void getProjectCases()
        {
            string proc = "exec dbo.Projects_View";
            DataTable dt = await CommonMethods.getRecords(proc);
            gvShowCaseProject.DataSource = dt;
            /*gvShowCaseProject.Columns[0].HeaderText = "Project ID";*/
            gvShowCaseProject.Columns[0].Visible = false;
            gvShowCaseProject.Columns[1].HeaderText = "Project Name";
            gvShowCaseProject.Columns[2].HeaderText = "Created By";
        }

        private async void btnSaveProjectCase_Click(object sender, EventArgs e)
        {
            string procSearch = "exec SP_Project_Search '" + cmbBoxProject.Text + "'";
            DataTable dt = await CommonMethods.getRecords(procSearch);
            if (dt.Rows.Count > 0)
            {

                //CommonMethods.messageDialog("Project already added!");
                MessageBox.Show("Project already added!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (IsProjectFormValid())
            {
                string proc = "exec SP_Project_Insert '" + cmbBoxProject.Text + "', '" + Common.userName + "'";
                CommonMethods.insertRecords(proc);
                //CommonMethods.messageDialog("New Project Added Successfully!");
                MessageBox.Show("New Project Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                getProjectCases();
            }
        }

        private bool IsProjectFormValid()
        {
            var Valid = true;
            if (cmbBoxProject.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Project Name is Required!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbBoxProject.Focus();
                Valid = false;
            }
            if (cmbBoxProject.Text.Trim().Length >= 50)
            {
                MessageBox.Show("Project Name should be less than 50!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbBoxProject.Focus();
                Valid = false;
            }
            return Valid;
        }

        private void AddCaseForm_Load(object sender, EventArgs e)
        {
            
            panelProject.PanelColor = ThemeManager.RandomizeTheme();
        }
    }
}
