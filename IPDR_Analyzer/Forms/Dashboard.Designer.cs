namespace IPDR_Analyzer.Forms
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            Utilities.BunifuPages.BunifuAnimatorNS.Animation animation1 = new Utilities.BunifuPages.BunifuAnimatorNS.Animation();
            this.panelMenu = new Bunifu.UI.WinForms.BunifuPanel();
            this.btnAppsDur = new FontAwesome.Sharp.IconButton();
            this.btnCommonGMAP = new FontAwesome.Sharp.IconButton();
            this.btnBasicConver = new FontAwesome.Sharp.IconButton();
            this.btnLocSummary = new FontAwesome.Sharp.IconButton();
            this.btnAppSummaary = new FontAwesome.Sharp.IconButton();
            this.btnGMAP = new FontAwesome.Sharp.IconButton();
            this.btnAddIPDR = new FontAwesome.Sharp.IconButton();
            this.btnAddCase = new FontAwesome.Sharp.IconButton();
            this.bunifuPanel2 = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.panelTitleBar = new Bunifu.UI.WinForms.BunifuPanel();
            this.btnMin = new FontAwesome.Sharp.IconPictureBox();
            this.btnMax = new FontAwesome.Sharp.IconPictureBox();
            this.btnClose = new FontAwesome.Sharp.IconPictureBox();
            this.lbTitleChildForm = new Bunifu.UI.WinForms.BunifuLabel();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.bunifuPages = new Bunifu.UI.WinForms.BunifuPages();
            this.tabPage = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelMenu.SuspendLayout();
            this.bunifuPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.bunifuPages.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(35)))), ((int)(((byte)(250)))));
            this.panelMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelMenu.BackgroundImage")));
            this.panelMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMenu.BorderColor = System.Drawing.Color.Transparent;
            this.panelMenu.BorderRadius = 3;
            this.panelMenu.BorderThickness = 1;
            this.panelMenu.Controls.Add(this.btnAppsDur);
            this.panelMenu.Controls.Add(this.btnCommonGMAP);
            this.panelMenu.Controls.Add(this.btnBasicConver);
            this.panelMenu.Controls.Add(this.btnLocSummary);
            this.panelMenu.Controls.Add(this.btnAppSummaary);
            this.panelMenu.Controls.Add(this.btnGMAP);
            this.panelMenu.Controls.Add(this.btnAddIPDR);
            this.panelMenu.Controls.Add(this.btnAddCase);
            this.panelMenu.Controls.Add(this.bunifuPanel2);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.ShowBorders = true;
            this.panelMenu.Size = new System.Drawing.Size(220, 635);
            this.panelMenu.TabIndex = 0;
            // 
            // btnAppsDur
            // 
            this.btnAppsDur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(35)))), ((int)(((byte)(250)))));
            this.btnAppsDur.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAppsDur.FlatAppearance.BorderSize = 0;
            this.btnAppsDur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppsDur.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnAppsDur.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAppsDur.IconChar = FontAwesome.Sharp.IconChar.ClockFour;
            this.btnAppsDur.IconColor = System.Drawing.Color.Gainsboro;
            this.btnAppsDur.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAppsDur.IconSize = 32;
            this.btnAppsDur.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAppsDur.Location = new System.Drawing.Point(0, 560);
            this.btnAppsDur.Name = "btnAppsDur";
            this.btnAppsDur.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnAppsDur.Size = new System.Drawing.Size(220, 60);
            this.btnAppsDur.TabIndex = 8;
            this.btnAppsDur.Text = "APPS DURATION";
            this.btnAppsDur.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAppsDur.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAppsDur.UseVisualStyleBackColor = false;
            this.btnAppsDur.Click += new System.EventHandler(this.btnAppsDur_Click);
            // 
            // btnCommonGMAP
            // 
            this.btnCommonGMAP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(35)))), ((int)(((byte)(250)))));
            this.btnCommonGMAP.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCommonGMAP.FlatAppearance.BorderSize = 0;
            this.btnCommonGMAP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCommonGMAP.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnCommonGMAP.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCommonGMAP.IconChar = FontAwesome.Sharp.IconChar.LocationDot;
            this.btnCommonGMAP.IconColor = System.Drawing.Color.Gainsboro;
            this.btnCommonGMAP.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCommonGMAP.IconSize = 32;
            this.btnCommonGMAP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCommonGMAP.Location = new System.Drawing.Point(0, 500);
            this.btnCommonGMAP.Name = "btnCommonGMAP";
            this.btnCommonGMAP.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCommonGMAP.Size = new System.Drawing.Size(220, 60);
            this.btnCommonGMAP.TabIndex = 7;
            this.btnCommonGMAP.Text = "COMMON-GMAP";
            this.btnCommonGMAP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCommonGMAP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCommonGMAP.UseVisualStyleBackColor = false;
            this.btnCommonGMAP.Click += new System.EventHandler(this.btnCommonGMAP_Click);
            // 
            // btnBasicConver
            // 
            this.btnBasicConver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(35)))), ((int)(((byte)(250)))));
            this.btnBasicConver.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBasicConver.FlatAppearance.BorderSize = 0;
            this.btnBasicConver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBasicConver.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnBasicConver.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnBasicConver.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.btnBasicConver.IconColor = System.Drawing.Color.Gainsboro;
            this.btnBasicConver.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBasicConver.IconSize = 32;
            this.btnBasicConver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBasicConver.Location = new System.Drawing.Point(0, 440);
            this.btnBasicConver.Name = "btnBasicConver";
            this.btnBasicConver.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnBasicConver.Size = new System.Drawing.Size(220, 60);
            this.btnBasicConver.TabIndex = 6;
            this.btnBasicConver.Text = "BASIC CONVER";
            this.btnBasicConver.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBasicConver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBasicConver.UseVisualStyleBackColor = false;
            this.btnBasicConver.Click += new System.EventHandler(this.btnBasicConver_Click);
            // 
            // btnLocSummary
            // 
            this.btnLocSummary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(35)))), ((int)(((byte)(250)))));
            this.btnLocSummary.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLocSummary.FlatAppearance.BorderSize = 0;
            this.btnLocSummary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocSummary.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnLocSummary.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLocSummary.IconChar = FontAwesome.Sharp.IconChar.LocationArrow;
            this.btnLocSummary.IconColor = System.Drawing.Color.Gainsboro;
            this.btnLocSummary.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLocSummary.IconSize = 32;
            this.btnLocSummary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLocSummary.Location = new System.Drawing.Point(0, 380);
            this.btnLocSummary.Name = "btnLocSummary";
            this.btnLocSummary.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnLocSummary.Size = new System.Drawing.Size(220, 60);
            this.btnLocSummary.TabIndex = 5;
            this.btnLocSummary.Text = "LOC SUMMARY";
            this.btnLocSummary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLocSummary.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLocSummary.UseVisualStyleBackColor = false;
            this.btnLocSummary.Click += new System.EventHandler(this.btnLocSummary_Click);
            // 
            // btnAppSummaary
            // 
            this.btnAppSummaary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(35)))), ((int)(((byte)(250)))));
            this.btnAppSummaary.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAppSummaary.FlatAppearance.BorderSize = 0;
            this.btnAppSummaary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppSummaary.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnAppSummaary.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAppSummaary.IconChar = FontAwesome.Sharp.IconChar.ListAlt;
            this.btnAppSummaary.IconColor = System.Drawing.Color.Gainsboro;
            this.btnAppSummaary.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAppSummaary.IconSize = 32;
            this.btnAppSummaary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAppSummaary.Location = new System.Drawing.Point(0, 320);
            this.btnAppSummaary.Name = "btnAppSummaary";
            this.btnAppSummaary.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnAppSummaary.Size = new System.Drawing.Size(220, 60);
            this.btnAppSummaary.TabIndex = 4;
            this.btnAppSummaary.Text = "APP SUMMARY";
            this.btnAppSummaary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAppSummaary.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAppSummaary.UseVisualStyleBackColor = false;
            this.btnAppSummaary.Click += new System.EventHandler(this.btnAppSummaary_Click);
            // 
            // btnGMAP
            // 
            this.btnGMAP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(35)))), ((int)(((byte)(250)))));
            this.btnGMAP.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGMAP.FlatAppearance.BorderSize = 0;
            this.btnGMAP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGMAP.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnGMAP.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnGMAP.IconChar = FontAwesome.Sharp.IconChar.MapMarkedAlt;
            this.btnGMAP.IconColor = System.Drawing.Color.Gainsboro;
            this.btnGMAP.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGMAP.IconSize = 32;
            this.btnGMAP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGMAP.Location = new System.Drawing.Point(0, 260);
            this.btnGMAP.Name = "btnGMAP";
            this.btnGMAP.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnGMAP.Size = new System.Drawing.Size(220, 60);
            this.btnGMAP.TabIndex = 3;
            this.btnGMAP.Text = "GMAP";
            this.btnGMAP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGMAP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGMAP.UseVisualStyleBackColor = false;
            this.btnGMAP.Click += new System.EventHandler(this.btnGMAP_Click);
            // 
            // btnAddIPDR
            // 
            this.btnAddIPDR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(35)))), ((int)(((byte)(250)))));
            this.btnAddIPDR.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddIPDR.FlatAppearance.BorderSize = 0;
            this.btnAddIPDR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddIPDR.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddIPDR.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAddIPDR.IconChar = FontAwesome.Sharp.IconChar.Message;
            this.btnAddIPDR.IconColor = System.Drawing.Color.Gainsboro;
            this.btnAddIPDR.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddIPDR.IconSize = 32;
            this.btnAddIPDR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddIPDR.Location = new System.Drawing.Point(0, 200);
            this.btnAddIPDR.Name = "btnAddIPDR";
            this.btnAddIPDR.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnAddIPDR.Size = new System.Drawing.Size(220, 60);
            this.btnAddIPDR.TabIndex = 2;
            this.btnAddIPDR.Text = "ADD IPDR";
            this.btnAddIPDR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddIPDR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddIPDR.UseVisualStyleBackColor = false;
            this.btnAddIPDR.Click += new System.EventHandler(this.btnAddIPDR_Click);
            // 
            // btnAddCase
            // 
            this.btnAddCase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(35)))), ((int)(((byte)(250)))));
            this.btnAddCase.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddCase.FlatAppearance.BorderSize = 0;
            this.btnAddCase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCase.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddCase.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAddCase.IconChar = FontAwesome.Sharp.IconChar.Briefcase;
            this.btnAddCase.IconColor = System.Drawing.Color.Gainsboro;
            this.btnAddCase.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddCase.IconSize = 32;
            this.btnAddCase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCase.Location = new System.Drawing.Point(0, 140);
            this.btnAddCase.Name = "btnAddCase";
            this.btnAddCase.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnAddCase.Size = new System.Drawing.Size(220, 60);
            this.btnAddCase.TabIndex = 1;
            this.btnAddCase.Text = "ADD CASE";
            this.btnAddCase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddCase.UseVisualStyleBackColor = false;
            this.btnAddCase.Click += new System.EventHandler(this.btnAddCase_Click);
            // 
            // bunifuPanel2
            // 
            this.bunifuPanel2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(35)))), ((int)(((byte)(250)))));
            this.bunifuPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel2.BackgroundImage")));
            this.bunifuPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel2.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel2.BorderRadius = 0;
            this.bunifuPanel2.BorderThickness = 0;
            this.bunifuPanel2.Controls.Add(this.bunifuPictureBox1);
            this.bunifuPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuPanel2.Location = new System.Drawing.Point(0, 0);
            this.bunifuPanel2.Name = "bunifuPanel2";
            this.bunifuPanel2.ShowBorders = true;
            this.bunifuPanel2.Size = new System.Drawing.Size(220, 140);
            this.bunifuPanel2.TabIndex = 0;
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox1.AutoSizeHeight = true;
            this.bunifuPictureBox1.BackColor = System.Drawing.Color.LightCyan;
            this.bunifuPictureBox1.BorderRadius = 62;
            this.bunifuPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuPictureBox1.Image")));
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(36, 12);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(125, 125);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 0;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(35)))), ((int)(((byte)(250)))));
            this.panelTitleBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelTitleBar.BackgroundImage")));
            this.panelTitleBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelTitleBar.BorderColor = System.Drawing.Color.Transparent;
            this.panelTitleBar.BorderRadius = 0;
            this.panelTitleBar.BorderThickness = 0;
            this.panelTitleBar.Controls.Add(this.btnMin);
            this.panelTitleBar.Controls.Add(this.btnMax);
            this.panelTitleBar.Controls.Add(this.btnClose);
            this.panelTitleBar.Controls.Add(this.lbTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.ShowBorders = true;
            this.panelTitleBar.Size = new System.Drawing.Size(853, 75);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.BackColor = System.Drawing.Color.Transparent;
            this.btnMin.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMin.IconChar = FontAwesome.Sharp.IconChar.CompressArrowsAlt;
            this.btnMin.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMin.IconSize = 28;
            this.btnMin.Location = new System.Drawing.Point(771, 12);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(28, 28);
            this.btnMin.TabIndex = 4;
            this.btnMin.TabStop = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            this.btnMin.MouseLeave += new System.EventHandler(this.btnMin_MouseLeave);
            this.btnMin.MouseHover += new System.EventHandler(this.btnMin_MouseHover);
            // 
            // btnMax
            // 
            this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMax.BackColor = System.Drawing.Color.Transparent;
            this.btnMax.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMax.IconChar = FontAwesome.Sharp.IconChar.Maximize;
            this.btnMax.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMax.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMax.IconSize = 28;
            this.btnMax.Location = new System.Drawing.Point(733, 12);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(28, 28);
            this.btnMax.TabIndex = 3;
            this.btnMax.TabStop = false;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            this.btnMax.MouseLeave += new System.EventHandler(this.btnMax_MouseLeave);
            this.btnMax.MouseHover += new System.EventHandler(this.btnMax_MouseHover);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btnClose.IconColor = System.Drawing.Color.Gainsboro;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 28;
            this.btnClose.Location = new System.Drawing.Point(809, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(28, 28);
            this.btnClose.TabIndex = 2;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            this.btnClose.MouseHover += new System.EventHandler(this.btnClose_MouseHover);
            // 
            // lbTitleChildForm
            // 
            this.lbTitleChildForm.AllowParentOverrides = false;
            this.lbTitleChildForm.AutoEllipsis = false;
            this.lbTitleChildForm.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbTitleChildForm.CursorType = System.Windows.Forms.Cursors.Default;
            this.lbTitleChildForm.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lbTitleChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbTitleChildForm.Location = new System.Drawing.Point(57, 30);
            this.lbTitleChildForm.Name = "lbTitleChildForm";
            this.lbTitleChildForm.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbTitleChildForm.Size = new System.Drawing.Size(45, 21);
            this.lbTitleChildForm.TabIndex = 1;
            this.lbTitleChildForm.Text = "Home";
            this.lbTitleChildForm.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbTitleChildForm.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.Transparent;
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.House;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(18, 24);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(32, 32);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // bunifuPages
            // 
            this.bunifuPages.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.bunifuPages.AllowTransitions = false;
            this.bunifuPages.Controls.Add(this.tabPage);
            this.bunifuPages.Controls.Add(this.tabPage2);
            this.bunifuPages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuPages.Location = new System.Drawing.Point(220, 75);
            this.bunifuPages.Multiline = true;
            this.bunifuPages.Name = "bunifuPages";
            this.bunifuPages.Page = this.tabPage;
            this.bunifuPages.PageIndex = 0;
            this.bunifuPages.PageName = "tabPage";
            this.bunifuPages.PageTitle = "tabPage";
            this.bunifuPages.SelectedIndex = 0;
            this.bunifuPages.Size = new System.Drawing.Size(853, 560);
            this.bunifuPages.TabIndex = 2;
            animation1.AnimateOnlyDifferences = false;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.bunifuPages.Transition = animation1;
            this.bunifuPages.TransitionType = Utilities.BunifuPages.BunifuAnimatorNS.AnimationType.Custom;
            // 
            // tabPage
            // 
            this.tabPage.Location = new System.Drawing.Point(4, 4);
            this.tabPage.Name = "tabPage";
            this.tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage.Size = new System.Drawing.Size(845, 534);
            this.tabPage.TabIndex = 0;
            this.tabPage.Text = "tabPage";
            this.tabPage.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(845, 534);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this.panelTitleBar;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 20;
            this.bunifuElipse2.TargetControl = this.panelMenu;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1073, 635);
            this.Controls.Add(this.bunifuPages);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1089, 674);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panelMenu.ResumeLayout(false);
            this.bunifuPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.bunifuPages.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel panelMenu;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel2;
        private FontAwesome.Sharp.IconButton btnAddCase;
        private FontAwesome.Sharp.IconButton btnBasicConver;
        private FontAwesome.Sharp.IconButton btnLocSummary;
        private FontAwesome.Sharp.IconButton btnAppSummaary;
        private FontAwesome.Sharp.IconButton btnGMAP;
        private FontAwesome.Sharp.IconButton btnAddIPDR;
        private FontAwesome.Sharp.IconButton btnCommonGMAP;
        private Bunifu.UI.WinForms.BunifuPanel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private Bunifu.UI.WinForms.BunifuLabel lbTitleChildForm;
        private Bunifu.UI.WinForms.BunifuPages bunifuPages;
        private System.Windows.Forms.TabPage tabPage;
        private System.Windows.Forms.TabPage tabPage2;
        private FontAwesome.Sharp.IconPictureBox btnMin;
        private FontAwesome.Sharp.IconPictureBox btnMax;
        private FontAwesome.Sharp.IconPictureBox btnClose;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private FontAwesome.Sharp.IconButton btnAppsDur;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
    }
}