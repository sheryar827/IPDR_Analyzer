using FontAwesome.Sharp;
using System.Collections.Generic;
using System;
using System.Drawing;
using System.Windows.Forms;
using Color = System.Drawing.Color;
using System.Runtime.InteropServices;
using System.Windows.Controls.Primitives;
using IPDR_Analyzer.Classes;

namespace IPDR_Analyzer.Forms
{
    public partial class Dashboard : Form
    {
        private Form activeForm;
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        
        //Constructor
        public Dashboard()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new System.Drawing.Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);

            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //Struct
        /*private struct RGBColors
        {
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
            public static Color color7 = Color.FromArgb(24, 161, 251);
            public static Color color8 = Color.FromArgb(63, 195, 128);
            public static Color color9 = Color.FromArgb(255, 193, 7);
            public static Color color10 = Color.FromArgb(0, 123, 255);
            public static Color color11 = Color.FromArgb(102, 187, 106);
            public static Color color12 = Color.FromArgb(255, 87, 34);
            public static Color color13 = Color.FromArgb(33, 150, 243);
            public static Color color14 = Color.FromArgb(144, 202, 249);
            public static Color color15 = Color.FromArgb(233, 30, 99);
        }*/


        /*private Color GetRandomColor()
        {
            List<Color> colors = new List<Color>
    {
        RGBColors.color1,
        RGBColors.color2,
        RGBColors.color3,
        RGBColors.color4,
        RGBColors.color5,
        RGBColors.color6,
        RGBColors.color7,
        RGBColors.color8,
        RGBColors.color9,
        RGBColors.color10,
        RGBColors.color11,
        RGBColors.color12,
        RGBColors.color13,
        RGBColors.color14,
        RGBColors.color15,
        // Add the rest of your colors here
    };

            Random random = new Random();
            int randomIndex = random.Next(colors.Count);
            return colors[randomIndex];
        }*/

        //Methods
        private void ActivateButton(object senderBtn, Color color)
        {
            if(senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton) senderBtn;
                currentBtn.BackColor = Color.FromArgb(37,36,81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                //Icon Current Child Form
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
            }
        }

        private void DisableButton()
        {
            if(currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(108, 35, 250);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void btnAddCase_Click(object sender, System.EventArgs e)
        {
            ActivateButton(sender, ThemeManager.RandomizeTheme());
            bunifuPages.SetPage("tabPage");
            openChildFormPage(new AddCaseForm(), sender, tabPage);
            lbTitleChildForm.Text = "ADD CASE";
        }

        private void btnAddIPDR_Click(object sender, System.EventArgs e)
        {
            ActivateButton(sender, ThemeManager.RandomizeTheme());
            bunifuPages.SetPage("tabPage");
            openChildFormPage(new StandForm(), sender, tabPage);
            lbTitleChildForm.Text = "STANDARDIZE IPDR";
        }

        private void btnGMAP_Click(object sender, System.EventArgs e)
        {
            ActivateButton(sender, ThemeManager.RandomizeTheme());
            bunifuPages.SetPage("tabPage");
            openChildFormPage(new GMapForm(), sender, tabPage);
            lbTitleChildForm.Text = "GMap";
        }

        private void btnAppSummaary_Click(object sender, System.EventArgs e)
        {
            ActivateButton(sender, ThemeManager.RandomizeTheme());
            bunifuPages.SetPage("tabPage");
            openChildFormPage(new AppSumForm(), sender, tabPage);
            lbTitleChildForm.Text = "App Summary";
        }

        private void btnLocSummary_Click(object sender, System.EventArgs e)
        {
            ActivateButton(sender, ThemeManager.RandomizeTheme());
            bunifuPages.SetPage("tabPage");
            openChildFormPage(new LocSumForm(), sender, tabPage);
            lbTitleChildForm.Text = "Loc Summary";
        }

        private void btnBasicConver_Click(object sender, System.EventArgs e)
        {
            ActivateButton(sender, ThemeManager.RandomizeTheme());
            bunifuPages.SetPage("tabPage");
            openChildFormPage(new BasicConversationInfoForm(), sender, tabPage);
            lbTitleChildForm.Text = "Basic Conver";
        }

        private void btnCommonGMAP_Click(object sender, System.EventArgs e)
        {
            ActivateButton(sender, ThemeManager.RandomizeTheme());
            bunifuPages.SetPage("tabPage");
            openChildFormPage(new CGMapForm(), sender, tabPage);
            lbTitleChildForm.Text = "Common GMAP";
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            bunifuPages.SetPage("tabPage");
            openChildFormPage(new AddCaseForm(), sender, tabPage);
            lbTitleChildForm.Text = "ADD CASE";
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void btnMax_MouseHover(object sender, EventArgs e)
        {
            //btnMax.IconChar = IconChar.WindowMaximize;
            btnMax.BackColor = ThemeManager.RandomizeTheme();
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            //btnClose.IconChar = IconChar.Xmark;
            btnClose.BackColor = Color.Transparent;
        }

        private void btnClose_MouseHover(object sender, EventArgs e)
        {
            //btnClose.IconChar = IconChar.WindowClose;
            btnClose.BackColor = ThemeManager.RandomizeTheme();
        }

        private void btnMax_MouseLeave(object sender, EventArgs e)
        {
            //btnMax.IconChar = IconChar.Maximize;
            btnMax.BackColor = Color.Transparent;
        }

        private void btnMin_MouseHover(object sender, EventArgs e)
        {
            //btnMin.IconChar = IconChar.WindowMinimize;
            btnMin.BackColor = ThemeManager.RandomizeTheme();
        }

        private void btnMin_MouseLeave(object sender, EventArgs e)
        {
            //btnMin.IconChar= IconChar.Minimize;
            btnMin.BackColor = Color.Transparent;
        }

        private void btnAppsDur_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, ThemeManager.RandomizeTheme());
            bunifuPages.SetPage("tabPage");
            openChildFormPage(new AppDurForm(), sender, tabPage);
            lbTitleChildForm.Text = "APPS DURATION";
        }
    }
}
