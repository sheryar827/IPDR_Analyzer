using Bunifu.UI.WinForms;
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
    public partial class MainForm : Form
    {
        private Form activeForm;

        public MainForm()
        {
            InitializeComponent();
        }



        private void openChildFormPage(Form childForm, object btnSender, TabPage tabPage)
        {

            if (activeForm != null)
            {
                activeForm.Close();

            }
            //ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            tabPage.Controls.Add(childForm);

            //this.btnCDRSummary.Controls.Add(childForm);
            //this.btnCDRSummary.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();
            //lbTitle.Text = childForm.Text;
        }


        private void btnAddCaseProject_Click(object sender, EventArgs e)
        {
            indicator.Top = ((Control)sender).Top;
            bunifuPages.SetPage("tabPage");
            openChildFormPage(new Forms.AddCaseForm(), sender, tabPage);
        }

        private void btnAddCDR_Click(object sender, EventArgs e)
        {
            indicator.Top = ((Control)sender).Top;
            bunifuPages.SetPage("tabPage");
            openChildFormPage(new StandForm(), sender, tabPage);
            this.Text = "STANDARDIZE IPDR";
        }

        private void btnGMap_Click(object sender, EventArgs e)
        {
            indicator.Top = ((Control)sender).Top;
            bunifuPages.SetPage("tabPage");
            openChildFormPage(new GMapForm(), sender, tabPage);
            this.Text = "GMap";
        }

        private void btnLinkAnaly_Click(object sender, EventArgs e)
        {
            indicator.Top = ((Control)sender).Top;
        }

        private void btnCDRSum_Click(object sender, EventArgs e)
        {
            indicator.Top = ((Control)sender).Top;
            bunifuPages.SetPage("tabPage");
            openChildFormPage(new AppSumForm(), sender, tabPage);
            this.Text = "App Summary";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //btnMaimize.PerformClick();
            bunifuPages.SetPage("tabPage");
            openChildFormPage(new AddCaseForm(), sender, tabPage);
            this.Text = "ADD CASE";
        }

        private void bunifuButton6_Click(object sender, EventArgs e)
        {
            indicator.Top = ((Control)sender).Top;
            bunifuPages.SetPage("tabPage");
            openChildFormPage(new LocSumForm(), sender, tabPage);
            this.Text = "Loc Summary";
        }

        private void btnBasicConver_Click(object sender, EventArgs e)
        {
            indicator.Top = ((Control)sender).Top;
            bunifuPages.SetPage("tabPage");
            openChildFormPage(new BasicConversationInfoForm(), sender, tabPage);
            this.Text = "Basic Conversation";
        }

        private void btnCallsCountSec_Click(object sender, EventArgs e)
        {
            indicator.Top = ((Control)sender).Top;
            bunifuPages.SetPage("tabPage");
            openChildFormPage(new AppDurationForm(), sender, tabPage);
            this.Text = "App Duration";
        }

        private void bfbtnCommonLatLng_Click(object sender, EventArgs e)
        {
            indicator.Top = ((Control)sender).Top;
            bunifuPages.SetPage("tabPage");
            openChildFormPage(new CGMapForm(), sender, tabPage);
            this.Text = "Common GMap";
        }
    }
}
