namespace IPDR_Analyzer.Forms
{
    partial class AppDurForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppDurForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.flpTime = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.rbDays = new Bunifu.UI.WinForms.BunifuRadioButton();
            this.rbEvening = new Bunifu.UI.WinForms.BunifuRadioButton();
            this.rbMorning = new Bunifu.UI.WinForms.BunifuRadioButton();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.panelDateTime = new System.Windows.Forms.Panel();
            this.btnSearch = new FontAwesome.Sharp.IconPictureBox();
            this.panelDT = new System.Windows.Forms.Panel();
            this.dtpTimeTo = new System.Windows.Forms.DateTimePicker();
            this.dtpDateFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTimeFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpDateTo = new System.Windows.Forms.DateTimePicker();
            this.rbAllData = new System.Windows.Forms.RadioButton();
            this.rbSelected = new System.Windows.Forms.RadioButton();
            this.pcCallsSecCount = new LiveCharts.WinForms.PieChart();
            this.gvCallsSecCount = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuPieChart = new Bunifu.Charts.WinForms.ChartTypes.BunifuPieChart(this.components);
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.flpTime.SuspendLayout();
            this.panelDateTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
            this.panelDT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvCallsSecCount)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gvCallsSecCount);
            this.splitContainer1.Size = new System.Drawing.Size(1153, 717);
            this.splitContainer1.SplitterDistance = 820;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.splitContainer2.Panel1.Controls.Add(this.flpTime);
            this.splitContainer2.Panel1.Controls.Add(this.panelDateTime);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer2.Panel2.Controls.Add(this.pcCallsSecCount);
            this.splitContainer2.Size = new System.Drawing.Size(820, 717);
            this.splitContainer2.SplitterDistance = 164;
            this.splitContainer2.TabIndex = 0;
            // 
            // flpTime
            // 
            this.flpTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flpTime.BackgroundColor = System.Drawing.Color.Transparent;
            this.flpTime.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("flpTime.BackgroundImage")));
            this.flpTime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flpTime.BorderColor = System.Drawing.Color.Transparent;
            this.flpTime.BorderRadius = 3;
            this.flpTime.BorderThickness = 1;
            this.flpTime.Controls.Add(this.bunifuLabel1);
            this.flpTime.Controls.Add(this.bunifuLabel3);
            this.flpTime.Controls.Add(this.rbDays);
            this.flpTime.Controls.Add(this.rbEvening);
            this.flpTime.Controls.Add(this.rbMorning);
            this.flpTime.Controls.Add(this.bunifuLabel2);
            this.flpTime.Location = new System.Drawing.Point(123, 115);
            this.flpTime.Name = "flpTime";
            this.flpTime.ShowBorders = true;
            this.flpTime.Size = new System.Drawing.Size(574, 32);
            this.flpTime.TabIndex = 51;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.ForeColor = System.Drawing.Color.Gainsboro;
            this.bunifuLabel1.Location = new System.Drawing.Point(37, 6);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(145, 21);
            this.bunifuLabel1.TabIndex = 45;
            this.bunifuLabel1.Text = "08:00:00 to 15:59:59";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AllowParentOverrides = false;
            this.bunifuLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.CursorType = null;
            this.bunifuLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel3.ForeColor = System.Drawing.Color.Gainsboro;
            this.bunifuLabel3.Location = new System.Drawing.Point(411, 6);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(148, 21);
            this.bunifuLabel3.TabIndex = 49;
            this.bunifuLabel3.Text = "00:00:00 to 07:59:59";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // rbDays
            // 
            this.rbDays.AllowBindingControlLocation = false;
            this.rbDays.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbDays.BackColor = System.Drawing.Color.Transparent;
            this.rbDays.BindingControlPosition = Bunifu.UI.WinForms.BunifuRadioButton.BindingControlPositions.Right;
            this.rbDays.BorderThickness = 1;
            this.rbDays.Checked = false;
            this.rbDays.Location = new System.Drawing.Point(199, 6);
            this.rbDays.Name = "rbDays";
            this.rbDays.OutlineColor = System.Drawing.Color.DodgerBlue;
            this.rbDays.OutlineColorTabFocused = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.rbDays.OutlineColorUnchecked = System.Drawing.Color.DarkGray;
            this.rbDays.RadioColor = System.Drawing.Color.DodgerBlue;
            this.rbDays.RadioColorTabFocused = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.rbDays.Size = new System.Drawing.Size(21, 21);
            this.rbDays.TabIndex = 50;
            this.rbDays.Text = null;
            this.rbDays.Click += new System.EventHandler(this.rbDay_Click);
            // 
            // rbEvening
            // 
            this.rbEvening.AllowBindingControlLocation = false;
            this.rbEvening.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbEvening.BackColor = System.Drawing.Color.Transparent;
            this.rbEvening.BindingControlPosition = Bunifu.UI.WinForms.BunifuRadioButton.BindingControlPositions.Right;
            this.rbEvening.BorderThickness = 1;
            this.rbEvening.Checked = false;
            this.rbEvening.Location = new System.Drawing.Point(384, 6);
            this.rbEvening.Name = "rbEvening";
            this.rbEvening.OutlineColor = System.Drawing.Color.DodgerBlue;
            this.rbEvening.OutlineColorTabFocused = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.rbEvening.OutlineColorUnchecked = System.Drawing.Color.DarkGray;
            this.rbEvening.RadioColor = System.Drawing.Color.DodgerBlue;
            this.rbEvening.RadioColorTabFocused = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.rbEvening.Size = new System.Drawing.Size(21, 21);
            this.rbEvening.TabIndex = 48;
            this.rbEvening.Text = null;
            this.rbEvening.Click += new System.EventHandler(this.rbEvening_Click);
            // 
            // rbMorning
            // 
            this.rbMorning.AllowBindingControlLocation = false;
            this.rbMorning.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbMorning.BackColor = System.Drawing.Color.Transparent;
            this.rbMorning.BindingControlPosition = Bunifu.UI.WinForms.BunifuRadioButton.BindingControlPositions.Right;
            this.rbMorning.BorderThickness = 1;
            this.rbMorning.Checked = true;
            this.rbMorning.Location = new System.Drawing.Point(10, 6);
            this.rbMorning.Name = "rbMorning";
            this.rbMorning.OutlineColor = System.Drawing.Color.DodgerBlue;
            this.rbMorning.OutlineColorTabFocused = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.rbMorning.OutlineColorUnchecked = System.Drawing.Color.DarkGray;
            this.rbMorning.RadioColor = System.Drawing.Color.DodgerBlue;
            this.rbMorning.RadioColorTabFocused = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.rbMorning.Size = new System.Drawing.Size(21, 21);
            this.rbMorning.TabIndex = 44;
            this.rbMorning.Text = null;
            this.rbMorning.Click += new System.EventHandler(this.rbMorning_Click);
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.CursorType = null;
            this.bunifuLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel2.ForeColor = System.Drawing.Color.Gainsboro;
            this.bunifuLabel2.Location = new System.Drawing.Point(226, 6);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(145, 21);
            this.bunifuLabel2.TabIndex = 47;
            this.bunifuLabel2.Text = "16:00:00 to 23:59:59";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // panelDateTime
            // 
            this.panelDateTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelDateTime.Controls.Add(this.btnSearch);
            this.panelDateTime.Controls.Add(this.panelDT);
            this.panelDateTime.Controls.Add(this.rbAllData);
            this.panelDateTime.Controls.Add(this.rbSelected);
            this.panelDateTime.Location = new System.Drawing.Point(193, 22);
            this.panelDateTime.Name = "panelDateTime";
            this.panelDateTime.Size = new System.Drawing.Size(435, 82);
            this.panelDateTime.TabIndex = 38;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSearch.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnSearch.IconColor = System.Drawing.Color.White;
            this.btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearch.IconSize = 75;
            this.btnSearch.Location = new System.Drawing.Point(360, 0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 82);
            this.btnSearch.TabIndex = 39;
            this.btnSearch.TabStop = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnSearch.MouseLeave += new System.EventHandler(this.btnSearch_MouseLeave);
            this.btnSearch.MouseHover += new System.EventHandler(this.btnSearch_MouseHover);
            // 
            // panelDT
            // 
            this.panelDT.Controls.Add(this.dtpTimeTo);
            this.panelDT.Controls.Add(this.dtpDateFrom);
            this.panelDT.Controls.Add(this.dtpTimeFrom);
            this.panelDT.Controls.Add(this.dtpDateTo);
            this.panelDT.Location = new System.Drawing.Point(117, 3);
            this.panelDT.Name = "panelDT";
            this.panelDT.Size = new System.Drawing.Size(237, 76);
            this.panelDT.TabIndex = 37;
            // 
            // dtpTimeTo
            // 
            this.dtpTimeTo.CustomFormat = "dd-MM-yyyy";
            this.dtpTimeTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTimeTo.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTimeTo.Location = new System.Drawing.Point(118, 40);
            this.dtpTimeTo.Name = "dtpTimeTo";
            this.dtpTimeTo.Size = new System.Drawing.Size(100, 22);
            this.dtpTimeTo.TabIndex = 34;
            this.dtpTimeTo.Value = new System.DateTime(2021, 6, 8, 0, 0, 0, 0);
            // 
            // dtpDateFrom
            // 
            this.dtpDateFrom.CustomFormat = "yyyy-MM-dd";
            this.dtpDateFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateFrom.Location = new System.Drawing.Point(12, 12);
            this.dtpDateFrom.Name = "dtpDateFrom";
            this.dtpDateFrom.Size = new System.Drawing.Size(100, 22);
            this.dtpDateFrom.TabIndex = 29;
            this.dtpDateFrom.Value = new System.DateTime(2021, 6, 22, 0, 0, 0, 0);
            // 
            // dtpTimeFrom
            // 
            this.dtpTimeFrom.CustomFormat = "dd-MM-yyyy";
            this.dtpTimeFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTimeFrom.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTimeFrom.Location = new System.Drawing.Point(118, 12);
            this.dtpTimeFrom.Name = "dtpTimeFrom";
            this.dtpTimeFrom.Size = new System.Drawing.Size(100, 22);
            this.dtpTimeFrom.TabIndex = 33;
            this.dtpTimeFrom.Value = new System.DateTime(2021, 6, 8, 0, 0, 0, 0);
            // 
            // dtpDateTo
            // 
            this.dtpDateTo.CustomFormat = "yyyy-MM-dd";
            this.dtpDateTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateTo.Location = new System.Drawing.Point(12, 40);
            this.dtpDateTo.Name = "dtpDateTo";
            this.dtpDateTo.Size = new System.Drawing.Size(100, 22);
            this.dtpDateTo.TabIndex = 31;
            this.dtpDateTo.Value = new System.DateTime(2021, 6, 22, 16, 6, 42, 0);
            // 
            // rbAllData
            // 
            this.rbAllData.AutoSize = true;
            this.rbAllData.Checked = true;
            this.rbAllData.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.rbAllData.ForeColor = System.Drawing.Color.White;
            this.rbAllData.Location = new System.Drawing.Point(11, 12);
            this.rbAllData.Name = "rbAllData";
            this.rbAllData.Size = new System.Drawing.Size(84, 25);
            this.rbAllData.TabIndex = 35;
            this.rbAllData.TabStop = true;
            this.rbAllData.Text = "All Data";
            this.rbAllData.UseVisualStyleBackColor = true;
            this.rbAllData.Click += new System.EventHandler(this.rbAllData_Click);
            // 
            // rbSelected
            // 
            this.rbSelected.AutoSize = true;
            this.rbSelected.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.rbSelected.ForeColor = System.Drawing.Color.White;
            this.rbSelected.Location = new System.Drawing.Point(11, 40);
            this.rbSelected.Name = "rbSelected";
            this.rbSelected.Size = new System.Drawing.Size(92, 25);
            this.rbSelected.TabIndex = 36;
            this.rbSelected.Text = "Selected";
            this.rbSelected.UseVisualStyleBackColor = true;
            this.rbSelected.Click += new System.EventHandler(this.rbSelected_Click);
            // 
            // pcCallsSecCount
            // 
            this.pcCallsSecCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.pcCallsSecCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcCallsSecCount.Location = new System.Drawing.Point(0, 0);
            this.pcCallsSecCount.Name = "pcCallsSecCount";
            this.pcCallsSecCount.Size = new System.Drawing.Size(820, 549);
            this.pcCallsSecCount.TabIndex = 1;
            this.pcCallsSecCount.Text = "pieChart1";
            // 
            // gvCallsSecCount
            // 
            this.gvCallsSecCount.AllowCustomTheming = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.gvCallsSecCount.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gvCallsSecCount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvCallsSecCount.BackgroundColor = System.Drawing.Color.White;
            this.gvCallsSecCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvCallsSecCount.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gvCallsSecCount.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvCallsSecCount.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gvCallsSecCount.ColumnHeadersHeight = 40;
            this.gvCallsSecCount.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvCallsSecCount.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.gvCallsSecCount.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gvCallsSecCount.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.gvCallsSecCount.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.gvCallsSecCount.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.gvCallsSecCount.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.gvCallsSecCount.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.gvCallsSecCount.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.gvCallsSecCount.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gvCallsSecCount.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.gvCallsSecCount.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.gvCallsSecCount.CurrentTheme.Name = null;
            this.gvCallsSecCount.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gvCallsSecCount.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.gvCallsSecCount.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gvCallsSecCount.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.gvCallsSecCount.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvCallsSecCount.DefaultCellStyle = dataGridViewCellStyle6;
            this.gvCallsSecCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvCallsSecCount.EnableHeadersVisualStyles = false;
            this.gvCallsSecCount.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.gvCallsSecCount.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.gvCallsSecCount.HeaderBgColor = System.Drawing.Color.Empty;
            this.gvCallsSecCount.HeaderForeColor = System.Drawing.Color.White;
            this.gvCallsSecCount.Location = new System.Drawing.Point(0, 0);
            this.gvCallsSecCount.Name = "gvCallsSecCount";
            this.gvCallsSecCount.RowHeadersVisible = false;
            this.gvCallsSecCount.RowTemplate.Height = 40;
            this.gvCallsSecCount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvCallsSecCount.Size = new System.Drawing.Size(329, 717);
            this.gvCallsSecCount.TabIndex = 0;
            this.gvCallsSecCount.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this.splitContainer2.Panel1;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 20;
            this.bunifuElipse2.TargetControl = this.gvCallsSecCount;
            // 
            // bunifuPieChart
            // 
            this.bunifuPieChart.BackgroundColor = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("bunifuPieChart.BackgroundColor")));
            this.bunifuPieChart.BorderColor = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("bunifuPieChart.BorderColor")));
            this.bunifuPieChart.BorderWidth = 0;
            this.bunifuPieChart.Data = ((System.Collections.Generic.List<double>)(resources.GetObject("bunifuPieChart.Data")));
            this.bunifuPieChart.HoverBackgroundColor = System.Drawing.Color.Empty;
            this.bunifuPieChart.HoverBorderColor = System.Drawing.Color.Empty;
            this.bunifuPieChart.HoverBorderWidth = 0;
            this.bunifuPieChart.Label = "Label here";
            this.bunifuPieChart.TargetCanvas = null;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 20;
            this.bunifuElipse3.TargetControl = this.pcCallsSecCount;
            // 
            // AppDurForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1153, 717);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AppDurForm";
            this.Text = "AppDurForm";
            this.Load += new System.EventHandler(this.AppDurForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.flpTime.ResumeLayout(false);
            this.flpTime.PerformLayout();
            this.panelDateTime.ResumeLayout(false);
            this.panelDateTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
            this.panelDT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvCallsSecCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Panel panelDateTime;
        private System.Windows.Forms.Panel panelDT;
        private System.Windows.Forms.DateTimePicker dtpTimeTo;
        private System.Windows.Forms.DateTimePicker dtpDateFrom;
        private System.Windows.Forms.DateTimePicker dtpTimeFrom;
        private System.Windows.Forms.DateTimePicker dtpDateTo;
        private System.Windows.Forms.RadioButton rbAllData;
        private System.Windows.Forms.RadioButton rbSelected;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private FontAwesome.Sharp.IconPictureBox btnSearch;
        private Bunifu.UI.WinForms.BunifuDataGridView gvCallsSecCount;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private Bunifu.UI.WinForms.BunifuRadioButton rbEvening;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuRadioButton rbMorning;
        private System.Windows.Forms.RadioButton rbDay;
        private Bunifu.UI.WinForms.BunifuRadioButton rbDays;
        private LiveCharts.WinForms.PieChart pcCallsSecCount;
        private Bunifu.UI.WinForms.BunifuPanel flpTime;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Charts.WinForms.ChartTypes.BunifuPieChart bunifuPieChart;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
    }
}