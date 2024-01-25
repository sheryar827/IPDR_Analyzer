namespace IPDR_Analyzer.Forms
{
    partial class StandForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StandForm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.gvShowProject = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.gvIPDRNumber = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.gvStandIPDR = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.bflbErrorExcelSheet = new Bunifu.UI.WinForms.BunifuLabel();
            this.tbErrorHandling = new System.Windows.Forms.TextBox();
            this.btnExport = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.btnBrowse = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvShowProject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvIPDRNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStandIPDR)).BeginInit();
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
            this.splitContainer1.Panel2.Controls.Add(this.bflbErrorExcelSheet);
            this.splitContainer1.Panel2.Controls.Add(this.tbErrorHandling);
            this.splitContainer1.Panel2.Controls.Add(this.btnExport);
            this.splitContainer1.Panel2.Controls.Add(this.progressBar);
            this.splitContainer1.Panel2.Controls.Add(this.btnBrowse);
            this.splitContainer1.Size = new System.Drawing.Size(1327, 613);
            this.splitContainer1.SplitterDistance = 1037;
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
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.gvStandIPDR);
            this.splitContainer2.Size = new System.Drawing.Size(1037, 613);
            this.splitContainer2.SplitterDistance = 201;
            this.splitContainer2.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.gvShowProject);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.gvIPDRNumber);
            this.splitContainer3.Size = new System.Drawing.Size(1037, 201);
            this.splitContainer3.SplitterDistance = 678;
            this.splitContainer3.TabIndex = 0;
            // 
            // gvShowProject
            // 
            this.gvShowProject.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.gvShowProject.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gvShowProject.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvShowProject.BackgroundColor = System.Drawing.Color.White;
            this.gvShowProject.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvShowProject.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gvShowProject.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvShowProject.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gvShowProject.ColumnHeadersHeight = 40;
            this.gvShowProject.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvShowProject.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.gvShowProject.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gvShowProject.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.gvShowProject.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.gvShowProject.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.gvShowProject.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.gvShowProject.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.gvShowProject.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.gvShowProject.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gvShowProject.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.gvShowProject.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.gvShowProject.CurrentTheme.Name = null;
            this.gvShowProject.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gvShowProject.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.gvShowProject.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gvShowProject.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.gvShowProject.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvShowProject.DefaultCellStyle = dataGridViewCellStyle3;
            this.gvShowProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvShowProject.EnableHeadersVisualStyles = false;
            this.gvShowProject.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.gvShowProject.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.gvShowProject.HeaderBgColor = System.Drawing.Color.Empty;
            this.gvShowProject.HeaderForeColor = System.Drawing.Color.White;
            this.gvShowProject.Location = new System.Drawing.Point(0, 0);
            this.gvShowProject.Name = "gvShowProject";
            this.gvShowProject.RowHeadersVisible = false;
            this.gvShowProject.RowTemplate.Height = 40;
            this.gvShowProject.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvShowProject.Size = new System.Drawing.Size(678, 201);
            this.gvShowProject.TabIndex = 0;
            this.gvShowProject.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.gvShowProject.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvShowProject_CellDoubleClick);
            // 
            // gvIPDRNumber
            // 
            this.gvIPDRNumber.AllowCustomTheming = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(236)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.gvIPDRNumber.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gvIPDRNumber.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvIPDRNumber.BackgroundColor = System.Drawing.Color.White;
            this.gvIPDRNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvIPDRNumber.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gvIPDRNumber.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(143)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvIPDRNumber.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gvIPDRNumber.ColumnHeadersHeight = 40;
            this.gvIPDRNumber.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(236)))), ((int)(((byte)(219)))));
            this.gvIPDRNumber.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.gvIPDRNumber.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gvIPDRNumber.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(209)))), ((int)(((byte)(169)))));
            this.gvIPDRNumber.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.gvIPDRNumber.CurrentTheme.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.gvIPDRNumber.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(232)))), ((int)(((byte)(212)))));
            this.gvIPDRNumber.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.gvIPDRNumber.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.gvIPDRNumber.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gvIPDRNumber.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(143)))), ((int)(((byte)(90)))));
            this.gvIPDRNumber.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.gvIPDRNumber.CurrentTheme.Name = null;
            this.gvIPDRNumber.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(239)))), ((int)(((byte)(226)))));
            this.gvIPDRNumber.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.gvIPDRNumber.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gvIPDRNumber.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(209)))), ((int)(((byte)(169)))));
            this.gvIPDRNumber.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(239)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(209)))), ((int)(((byte)(169)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvIPDRNumber.DefaultCellStyle = dataGridViewCellStyle6;
            this.gvIPDRNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvIPDRNumber.EnableHeadersVisualStyles = false;
            this.gvIPDRNumber.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(232)))), ((int)(((byte)(212)))));
            this.gvIPDRNumber.HeaderBackColor = System.Drawing.Color.MediumSeaGreen;
            this.gvIPDRNumber.HeaderBgColor = System.Drawing.Color.Empty;
            this.gvIPDRNumber.HeaderForeColor = System.Drawing.Color.White;
            this.gvIPDRNumber.Location = new System.Drawing.Point(0, 0);
            this.gvIPDRNumber.Name = "gvIPDRNumber";
            this.gvIPDRNumber.RowHeadersVisible = false;
            this.gvIPDRNumber.RowTemplate.Height = 40;
            this.gvIPDRNumber.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvIPDRNumber.Size = new System.Drawing.Size(355, 201);
            this.gvIPDRNumber.TabIndex = 1;
            this.gvIPDRNumber.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.MediumSeaGreen;
            this.gvIPDRNumber.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvIPDRNumber_CellContentClick);
            // 
            // gvStandIPDR
            // 
            this.gvStandIPDR.AllowCustomTheming = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(191)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            this.gvStandIPDR.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.gvStandIPDR.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvStandIPDR.BackgroundColor = System.Drawing.Color.White;
            this.gvStandIPDR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvStandIPDR.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gvStandIPDR.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.DarkViolet;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(0)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvStandIPDR.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.gvStandIPDR.ColumnHeadersHeight = 40;
            this.gvStandIPDR.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(191)))), ((int)(((byte)(244)))));
            this.gvStandIPDR.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.gvStandIPDR.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gvStandIPDR.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(102)))), ((int)(((byte)(228)))));
            this.gvStandIPDR.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.gvStandIPDR.CurrentTheme.BackColor = System.Drawing.Color.DarkViolet;
            this.gvStandIPDR.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(178)))), ((int)(((byte)(241)))));
            this.gvStandIPDR.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DarkViolet;
            this.gvStandIPDR.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.gvStandIPDR.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gvStandIPDR.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(0)))), ((int)(((byte)(168)))));
            this.gvStandIPDR.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.gvStandIPDR.CurrentTheme.Name = null;
            this.gvStandIPDR.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(204)))), ((int)(((byte)(246)))));
            this.gvStandIPDR.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.gvStandIPDR.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gvStandIPDR.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(102)))), ((int)(((byte)(228)))));
            this.gvStandIPDR.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(204)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(102)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvStandIPDR.DefaultCellStyle = dataGridViewCellStyle9;
            this.gvStandIPDR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvStandIPDR.EnableHeadersVisualStyles = false;
            this.gvStandIPDR.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(178)))), ((int)(((byte)(241)))));
            this.gvStandIPDR.HeaderBackColor = System.Drawing.Color.DarkViolet;
            this.gvStandIPDR.HeaderBgColor = System.Drawing.Color.Empty;
            this.gvStandIPDR.HeaderForeColor = System.Drawing.Color.White;
            this.gvStandIPDR.Location = new System.Drawing.Point(0, 0);
            this.gvStandIPDR.Name = "gvStandIPDR";
            this.gvStandIPDR.RowHeadersVisible = false;
            this.gvStandIPDR.RowTemplate.Height = 40;
            this.gvStandIPDR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvStandIPDR.Size = new System.Drawing.Size(1037, 408);
            this.gvStandIPDR.TabIndex = 1;
            this.gvStandIPDR.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.DarkViolet;
            // 
            // bflbErrorExcelSheet
            // 
            this.bflbErrorExcelSheet.AllowParentOverrides = false;
            this.bflbErrorExcelSheet.AutoEllipsis = false;
            this.bflbErrorExcelSheet.AutoSize = false;
            this.bflbErrorExcelSheet.CursorType = null;
            this.bflbErrorExcelSheet.Dock = System.Windows.Forms.DockStyle.Top;
            this.bflbErrorExcelSheet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.bflbErrorExcelSheet.ForeColor = System.Drawing.Color.Red;
            this.bflbErrorExcelSheet.Location = new System.Drawing.Point(0, 318);
            this.bflbErrorExcelSheet.Name = "bflbErrorExcelSheet";
            this.bflbErrorExcelSheet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bflbErrorExcelSheet.Size = new System.Drawing.Size(286, 21);
            this.bflbErrorExcelSheet.TabIndex = 17;
            this.bflbErrorExcelSheet.Text = "Excel Sheet Error";
            this.bflbErrorExcelSheet.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.bflbErrorExcelSheet.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // tbErrorHandling
            // 
            this.tbErrorHandling.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbErrorHandling.Location = new System.Drawing.Point(0, 106);
            this.tbErrorHandling.Multiline = true;
            this.tbErrorHandling.Name = "tbErrorHandling";
            this.tbErrorHandling.Size = new System.Drawing.Size(286, 212);
            this.tbErrorHandling.TabIndex = 16;
            // 
            // btnExport
            // 
            this.btnExport.AllowAnimations = true;
            this.btnExport.AllowMouseEffects = true;
            this.btnExport.AllowToggling = false;
            this.btnExport.AnimationSpeed = 200;
            this.btnExport.AutoGenerateColors = false;
            this.btnExport.AutoRoundBorders = false;
            this.btnExport.AutoSizeLeftIcon = true;
            this.btnExport.AutoSizeRightIcon = true;
            this.btnExport.BackColor = System.Drawing.Color.Transparent;
            this.btnExport.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnExport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExport.BackgroundImage")));
            this.btnExport.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnExport.ButtonText = "Export Stand";
            this.btnExport.ButtonTextMarginLeft = 0;
            this.btnExport.ColorContrastOnClick = 45;
            this.btnExport.ColorContrastOnHover = 45;
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnExport.CustomizableEdges = borderEdges1;
            this.btnExport.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnExport.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnExport.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnExport.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnExport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExport.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.IconLeft = null;
            this.btnExport.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExport.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnExport.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnExport.IconMarginLeft = 11;
            this.btnExport.IconPadding = 10;
            this.btnExport.IconRight = null;
            this.btnExport.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExport.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnExport.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnExport.IconSize = 25;
            this.btnExport.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnExport.IdleBorderRadius = 0;
            this.btnExport.IdleBorderThickness = 0;
            this.btnExport.IdleFillColor = System.Drawing.Color.Empty;
            this.btnExport.IdleIconLeftImage = null;
            this.btnExport.IdleIconRightImage = null;
            this.btnExport.IndicateFocus = false;
            this.btnExport.Location = new System.Drawing.Point(0, 74);
            this.btnExport.Margin = new System.Windows.Forms.Padding(2);
            this.btnExport.Name = "btnExport";
            this.btnExport.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnExport.OnDisabledState.BorderRadius = 1;
            this.btnExport.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnExport.OnDisabledState.BorderThickness = 1;
            this.btnExport.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnExport.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnExport.OnDisabledState.IconLeftImage = null;
            this.btnExport.OnDisabledState.IconRightImage = null;
            this.btnExport.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExport.onHoverState.BorderRadius = 1;
            this.btnExport.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnExport.onHoverState.BorderThickness = 1;
            this.btnExport.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExport.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnExport.onHoverState.IconLeftImage = null;
            this.btnExport.onHoverState.IconRightImage = null;
            this.btnExport.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExport.OnIdleState.BorderRadius = 1;
            this.btnExport.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnExport.OnIdleState.BorderThickness = 1;
            this.btnExport.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExport.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnExport.OnIdleState.IconLeftImage = null;
            this.btnExport.OnIdleState.IconRightImage = null;
            this.btnExport.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnExport.OnPressedState.BorderRadius = 1;
            this.btnExport.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnExport.OnPressedState.BorderThickness = 1;
            this.btnExport.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnExport.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnExport.OnPressedState.IconLeftImage = null;
            this.btnExport.OnPressedState.IconRightImage = null;
            this.btnExport.Size = new System.Drawing.Size(286, 32);
            this.btnExport.TabIndex = 15;
            this.btnExport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExport.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnExport.TextMarginLeft = 0;
            this.btnExport.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnExport.UseDefaultRadiusAndThickness = true;
            // 
            // progressBar
            // 
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.progressBar.Location = new System.Drawing.Point(0, 51);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(286, 23);
            this.progressBar.TabIndex = 14;
            // 
            // btnBrowse
            // 
            this.btnBrowse.AllowAnimations = true;
            this.btnBrowse.AllowMouseEffects = true;
            this.btnBrowse.AllowToggling = true;
            this.btnBrowse.AnimationSpeed = 200;
            this.btnBrowse.AutoGenerateColors = false;
            this.btnBrowse.AutoRoundBorders = false;
            this.btnBrowse.AutoSizeLeftIcon = true;
            this.btnBrowse.AutoSizeRightIcon = true;
            this.btnBrowse.BackColor = System.Drawing.Color.Transparent;
            this.btnBrowse.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(74)))), ((int)(((byte)(86)))));
            this.btnBrowse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBrowse.BackgroundImage")));
            this.btnBrowse.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnBrowse.ButtonText = "Browse IPDR";
            this.btnBrowse.ButtonTextMarginLeft = 0;
            this.btnBrowse.ColorContrastOnClick = 45;
            this.btnBrowse.ColorContrastOnHover = 45;
            this.btnBrowse.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnBrowse.CustomizableEdges = borderEdges2;
            this.btnBrowse.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBrowse.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnBrowse.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnBrowse.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnBrowse.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBrowse.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnBrowse.Font = new System.Drawing.Font("Segoe UI Semibold", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.btnBrowse.IconLeft = null;
            this.btnBrowse.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBrowse.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnBrowse.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnBrowse.IconMarginLeft = 11;
            this.btnBrowse.IconPadding = 10;
            this.btnBrowse.IconRight = null;
            this.btnBrowse.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBrowse.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnBrowse.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnBrowse.IconSize = 25;
            this.btnBrowse.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(74)))), ((int)(((byte)(86)))));
            this.btnBrowse.IdleBorderRadius = 10;
            this.btnBrowse.IdleBorderThickness = 1;
            this.btnBrowse.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(74)))), ((int)(((byte)(86)))));
            this.btnBrowse.IdleIconLeftImage = null;
            this.btnBrowse.IdleIconRightImage = null;
            this.btnBrowse.IndicateFocus = true;
            this.btnBrowse.Location = new System.Drawing.Point(0, 0);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnBrowse.OnDisabledState.BorderRadius = 10;
            this.btnBrowse.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnBrowse.OnDisabledState.BorderThickness = 1;
            this.btnBrowse.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnBrowse.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnBrowse.OnDisabledState.IconLeftImage = null;
            this.btnBrowse.OnDisabledState.IconRightImage = null;
            this.btnBrowse.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBrowse.onHoverState.BorderRadius = 10;
            this.btnBrowse.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnBrowse.onHoverState.BorderThickness = 1;
            this.btnBrowse.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBrowse.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnBrowse.onHoverState.IconLeftImage = null;
            this.btnBrowse.onHoverState.IconRightImage = null;
            this.btnBrowse.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBrowse.OnIdleState.BorderRadius = 10;
            this.btnBrowse.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnBrowse.OnIdleState.BorderThickness = 1;
            this.btnBrowse.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBrowse.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.btnBrowse.OnIdleState.IconLeftImage = null;
            this.btnBrowse.OnIdleState.IconRightImage = null;
            this.btnBrowse.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBrowse.OnPressedState.BorderRadius = 10;
            this.btnBrowse.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnBrowse.OnPressedState.BorderThickness = 1;
            this.btnBrowse.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBrowse.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnBrowse.OnPressedState.IconLeftImage = null;
            this.btnBrowse.OnPressedState.IconRightImage = null;
            this.btnBrowse.Size = new System.Drawing.Size(286, 51);
            this.btnBrowse.TabIndex = 10;
            this.btnBrowse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBrowse.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBrowse.TextMarginLeft = 0;
            this.btnBrowse.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnBrowse.UseDefaultRadiusAndThickness = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this.gvShowProject;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 20;
            this.bunifuElipse2.TargetControl = this.gvIPDRNumber;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 20;
            this.bunifuElipse3.TargetControl = this.gvStandIPDR;
            // 
            // StandForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 613);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StandForm";
            this.Text = "StandForm";
            this.Load += new System.EventHandler(this.StandForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvShowProject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvIPDRNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStandIPDR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private Bunifu.UI.WinForms.BunifuDataGridView gvShowProject;
        private Bunifu.UI.WinForms.BunifuDataGridView gvIPDRNumber;
        private Bunifu.UI.WinForms.BunifuDataGridView gvStandIPDR;
        private Bunifu.UI.WinForms.BunifuLabel bflbErrorExcelSheet;
        private System.Windows.Forms.TextBox tbErrorHandling;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnExport;
        private System.Windows.Forms.ProgressBar progressBar;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnBrowse;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
    }
}