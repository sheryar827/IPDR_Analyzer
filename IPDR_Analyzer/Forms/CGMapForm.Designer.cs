﻿namespace IPDR_Analyzer.Forms
{
    partial class CGMapForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CGMapForm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.gvProjectNum = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gMap = new GMap.NET.WindowsForms.GMapControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExtract = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.DatePickerStartDate = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.txtDateLimit = new System.Windows.Forms.TextBox();
            this.bunifuLoader = new Bunifu.UI.WinForms.BunifuLoader();
            this.btnPlotCommonLatLng = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.lbCommonLatLng = new System.Windows.Forms.ListBox();
            this.btnLocDetails = new System.Windows.Forms.Button();
            this.bunifuElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gvProjectNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gvProjectNum
            // 
            this.gvProjectNum.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(236)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.gvProjectNum.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gvProjectNum.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvProjectNum.BackgroundColor = System.Drawing.Color.White;
            this.gvProjectNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvProjectNum.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gvProjectNum.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(143)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvProjectNum.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gvProjectNum.ColumnHeadersHeight = 40;
            this.gvProjectNum.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(236)))), ((int)(((byte)(219)))));
            this.gvProjectNum.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.gvProjectNum.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gvProjectNum.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(209)))), ((int)(((byte)(169)))));
            this.gvProjectNum.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.gvProjectNum.CurrentTheme.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.gvProjectNum.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(232)))), ((int)(((byte)(212)))));
            this.gvProjectNum.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.gvProjectNum.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.gvProjectNum.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gvProjectNum.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(143)))), ((int)(((byte)(90)))));
            this.gvProjectNum.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.gvProjectNum.CurrentTheme.Name = null;
            this.gvProjectNum.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(239)))), ((int)(((byte)(226)))));
            this.gvProjectNum.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.gvProjectNum.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gvProjectNum.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(209)))), ((int)(((byte)(169)))));
            this.gvProjectNum.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(239)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(209)))), ((int)(((byte)(169)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvProjectNum.DefaultCellStyle = dataGridViewCellStyle3;
            this.gvProjectNum.Dock = System.Windows.Forms.DockStyle.Top;
            this.gvProjectNum.EnableHeadersVisualStyles = false;
            this.gvProjectNum.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(232)))), ((int)(((byte)(212)))));
            this.gvProjectNum.HeaderBackColor = System.Drawing.Color.MediumSeaGreen;
            this.gvProjectNum.HeaderBgColor = System.Drawing.Color.Empty;
            this.gvProjectNum.HeaderForeColor = System.Drawing.Color.White;
            this.gvProjectNum.Location = new System.Drawing.Point(0, 0);
            this.gvProjectNum.Name = "gvProjectNum";
            this.gvProjectNum.RowHeadersVisible = false;
            this.gvProjectNum.RowTemplate.Height = 40;
            this.gvProjectNum.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvProjectNum.Size = new System.Drawing.Size(283, 246);
            this.gvProjectNum.TabIndex = 0;
            this.gvProjectNum.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.MediumSeaGreen;
            this.gvProjectNum.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvProjectNum_CellClick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gMap);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel2.Controls.Add(this.bunifuLoader);
            this.splitContainer1.Panel2.Controls.Add(this.btnPlotCommonLatLng);
            this.splitContainer1.Panel2.Controls.Add(this.lbCommonLatLng);
            this.splitContainer1.Panel2.Controls.Add(this.btnLocDetails);
            this.splitContainer1.Panel2.Controls.Add(this.gvProjectNum);
            this.splitContainer1.Size = new System.Drawing.Size(1311, 894);
            this.splitContainer1.SplitterDistance = 1022;
            this.splitContainer1.TabIndex = 1;
            // 
            // gMap
            // 
            this.gMap.Bearing = 0F;
            this.gMap.CanDragMap = true;
            this.gMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gMap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMap.GrayScaleMode = false;
            this.gMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMap.LevelsKeepInMemory = 5;
            this.gMap.Location = new System.Drawing.Point(0, 0);
            this.gMap.MarkersEnabled = true;
            this.gMap.MaxZoom = 2;
            this.gMap.MinZoom = 2;
            this.gMap.MouseWheelZoomEnabled = true;
            this.gMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMap.Name = "gMap";
            this.gMap.NegativeMode = false;
            this.gMap.PolygonsEnabled = true;
            this.gMap.RetryLoadTile = 0;
            this.gMap.RoutesEnabled = true;
            this.gMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMap.ShowTileGridLines = false;
            this.gMap.Size = new System.Drawing.Size(1020, 892);
            this.gMap.TabIndex = 0;
            this.gMap.Zoom = 0D;
            this.gMap.OnMarkerClick += new GMap.NET.WindowsForms.MarkerClick(this.gMap_OnMarkerClick);
            this.gMap.Load += new System.EventHandler(this.gMap_Load);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExtract);
            this.groupBox1.Controls.Add(this.DatePickerStartDate);
            this.groupBox1.Controls.Add(this.txtDateLimit);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(0, 486);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 154);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SEARCH";
            // 
            // btnExtract
            // 
            this.btnExtract.AllowAnimations = true;
            this.btnExtract.AllowMouseEffects = true;
            this.btnExtract.AllowToggling = false;
            this.btnExtract.AnimationSpeed = 200;
            this.btnExtract.AutoGenerateColors = false;
            this.btnExtract.AutoRoundBorders = false;
            this.btnExtract.AutoSizeLeftIcon = true;
            this.btnExtract.AutoSizeRightIcon = true;
            this.btnExtract.BackColor = System.Drawing.Color.Transparent;
            this.btnExtract.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnExtract.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExtract.BackgroundImage")));
            this.btnExtract.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnExtract.ButtonText = "Plot  Date Lat Lng";
            this.btnExtract.ButtonTextMarginLeft = 0;
            this.btnExtract.ColorContrastOnClick = 45;
            this.btnExtract.ColorContrastOnHover = 45;
            this.btnExtract.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnExtract.CustomizableEdges = borderEdges1;
            this.btnExtract.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnExtract.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnExtract.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnExtract.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnExtract.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExtract.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnExtract.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnExtract.ForeColor = System.Drawing.Color.White;
            this.btnExtract.IconLeft = null;
            this.btnExtract.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExtract.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnExtract.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnExtract.IconMarginLeft = 11;
            this.btnExtract.IconPadding = 10;
            this.btnExtract.IconRight = null;
            this.btnExtract.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExtract.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnExtract.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnExtract.IconSize = 25;
            this.btnExtract.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnExtract.IdleBorderRadius = 0;
            this.btnExtract.IdleBorderThickness = 0;
            this.btnExtract.IdleFillColor = System.Drawing.Color.Empty;
            this.btnExtract.IdleIconLeftImage = null;
            this.btnExtract.IdleIconRightImage = null;
            this.btnExtract.IndicateFocus = false;
            this.btnExtract.Location = new System.Drawing.Point(3, 112);
            this.btnExtract.Name = "btnExtract";
            this.btnExtract.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnExtract.OnDisabledState.BorderRadius = 1;
            this.btnExtract.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnExtract.OnDisabledState.BorderThickness = 1;
            this.btnExtract.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnExtract.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnExtract.OnDisabledState.IconLeftImage = null;
            this.btnExtract.OnDisabledState.IconRightImage = null;
            this.btnExtract.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnExtract.onHoverState.BorderRadius = 1;
            this.btnExtract.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnExtract.onHoverState.BorderThickness = 1;
            this.btnExtract.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnExtract.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnExtract.onHoverState.IconLeftImage = null;
            this.btnExtract.onHoverState.IconRightImage = null;
            this.btnExtract.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnExtract.OnIdleState.BorderRadius = 1;
            this.btnExtract.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnExtract.OnIdleState.BorderThickness = 1;
            this.btnExtract.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnExtract.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnExtract.OnIdleState.IconLeftImage = null;
            this.btnExtract.OnIdleState.IconRightImage = null;
            this.btnExtract.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnExtract.OnPressedState.BorderRadius = 1;
            this.btnExtract.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnExtract.OnPressedState.BorderThickness = 1;
            this.btnExtract.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnExtract.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnExtract.OnPressedState.IconLeftImage = null;
            this.btnExtract.OnPressedState.IconRightImage = null;
            this.btnExtract.Size = new System.Drawing.Size(277, 39);
            this.btnExtract.TabIndex = 2;
            this.btnExtract.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExtract.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnExtract.TextMarginLeft = 0;
            this.btnExtract.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnExtract.UseDefaultRadiusAndThickness = true;
            this.btnExtract.Click += new System.EventHandler(this.btnExtract_Click);
            // 
            // DatePickerStartDate
            // 
            this.DatePickerStartDate.BackColor = System.Drawing.Color.Transparent;
            this.DatePickerStartDate.BorderColor = System.Drawing.Color.Silver;
            this.DatePickerStartDate.BorderRadius = 1;
            this.DatePickerStartDate.Color = System.Drawing.Color.Silver;
            this.DatePickerStartDate.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.DatePickerStartDate.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.DatePickerStartDate.DisabledColor = System.Drawing.Color.Gray;
            this.DatePickerStartDate.DisplayWeekNumbers = false;
            this.DatePickerStartDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.DatePickerStartDate.DPHeight = 0;
            this.DatePickerStartDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.DatePickerStartDate.FillDatePicker = false;
            this.DatePickerStartDate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.DatePickerStartDate.ForeColor = System.Drawing.Color.Black;
            this.DatePickerStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePickerStartDate.Icon = ((System.Drawing.Image)(resources.GetObject("DatePickerStartDate.Icon")));
            this.DatePickerStartDate.IconColor = System.Drawing.Color.Gray;
            this.DatePickerStartDate.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.DatePickerStartDate.LeftTextMargin = 5;
            this.DatePickerStartDate.Location = new System.Drawing.Point(3, 54);
            this.DatePickerStartDate.MinimumSize = new System.Drawing.Size(4, 32);
            this.DatePickerStartDate.Name = "DatePickerStartDate";
            this.DatePickerStartDate.Size = new System.Drawing.Size(277, 32);
            this.DatePickerStartDate.TabIndex = 1;
            // 
            // txtDateLimit
            // 
            this.txtDateLimit.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtDateLimit.Enabled = false;
            this.txtDateLimit.ForeColor = System.Drawing.Color.Red;
            this.txtDateLimit.Location = new System.Drawing.Point(3, 25);
            this.txtDateLimit.Name = "txtDateLimit";
            this.txtDateLimit.Size = new System.Drawing.Size(277, 29);
            this.txtDateLimit.TabIndex = 0;
            // 
            // bunifuLoader
            // 
            this.bunifuLoader.AllowStylePresets = true;
            this.bunifuLoader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuLoader.BackColor = System.Drawing.Color.Transparent;
            this.bunifuLoader.CapStyle = Bunifu.UI.WinForms.BunifuLoader.CapStyles.Round;
            this.bunifuLoader.Color = System.Drawing.Color.DodgerBlue;
            this.bunifuLoader.Colors = new Bunifu.UI.WinForms.Bloom[0];
            this.bunifuLoader.Customization = "";
            this.bunifuLoader.DashWidth = 0.5F;
            this.bunifuLoader.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuLoader.Image = null;
            this.bunifuLoader.Location = new System.Drawing.Point(49, 696);
            this.bunifuLoader.Name = "bunifuLoader";
            this.bunifuLoader.NoRounding = false;
            this.bunifuLoader.Preset = Bunifu.UI.WinForms.BunifuLoader.StylePresets.Solid;
            this.bunifuLoader.RingStyle = Bunifu.UI.WinForms.BunifuLoader.RingStyles.Solid;
            this.bunifuLoader.ShowText = false;
            this.bunifuLoader.Size = new System.Drawing.Size(185, 185);
            this.bunifuLoader.Speed = 7;
            this.bunifuLoader.TabIndex = 3;
            this.bunifuLoader.Text = "bunifuLoader1";
            this.bunifuLoader.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuLoader.Thickness = 6;
            this.bunifuLoader.Transparent = true;
            this.bunifuLoader.Visible = false;
            // 
            // btnPlotCommonLatLng
            // 
            this.btnPlotCommonLatLng.AllowAnimations = true;
            this.btnPlotCommonLatLng.AllowMouseEffects = true;
            this.btnPlotCommonLatLng.AllowToggling = false;
            this.btnPlotCommonLatLng.AnimationSpeed = 200;
            this.btnPlotCommonLatLng.AutoGenerateColors = false;
            this.btnPlotCommonLatLng.AutoRoundBorders = false;
            this.btnPlotCommonLatLng.AutoSizeLeftIcon = true;
            this.btnPlotCommonLatLng.AutoSizeRightIcon = true;
            this.btnPlotCommonLatLng.BackColor = System.Drawing.Color.Transparent;
            this.btnPlotCommonLatLng.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnPlotCommonLatLng.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPlotCommonLatLng.BackgroundImage")));
            this.btnPlotCommonLatLng.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPlotCommonLatLng.ButtonText = "Extract Common LAT LNG";
            this.btnPlotCommonLatLng.ButtonTextMarginLeft = 0;
            this.btnPlotCommonLatLng.ColorContrastOnClick = 45;
            this.btnPlotCommonLatLng.ColorContrastOnHover = 45;
            this.btnPlotCommonLatLng.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnPlotCommonLatLng.CustomizableEdges = borderEdges2;
            this.btnPlotCommonLatLng.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPlotCommonLatLng.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnPlotCommonLatLng.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnPlotCommonLatLng.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnPlotCommonLatLng.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPlotCommonLatLng.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnPlotCommonLatLng.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnPlotCommonLatLng.ForeColor = System.Drawing.Color.White;
            this.btnPlotCommonLatLng.IconLeft = null;
            this.btnPlotCommonLatLng.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlotCommonLatLng.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnPlotCommonLatLng.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnPlotCommonLatLng.IconMarginLeft = 11;
            this.btnPlotCommonLatLng.IconPadding = 10;
            this.btnPlotCommonLatLng.IconRight = null;
            this.btnPlotCommonLatLng.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPlotCommonLatLng.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnPlotCommonLatLng.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnPlotCommonLatLng.IconSize = 25;
            this.btnPlotCommonLatLng.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnPlotCommonLatLng.IdleBorderRadius = 0;
            this.btnPlotCommonLatLng.IdleBorderThickness = 0;
            this.btnPlotCommonLatLng.IdleFillColor = System.Drawing.Color.Empty;
            this.btnPlotCommonLatLng.IdleIconLeftImage = null;
            this.btnPlotCommonLatLng.IdleIconRightImage = null;
            this.btnPlotCommonLatLng.IndicateFocus = false;
            this.btnPlotCommonLatLng.Location = new System.Drawing.Point(0, 440);
            this.btnPlotCommonLatLng.Margin = new System.Windows.Forms.Padding(2);
            this.btnPlotCommonLatLng.Name = "btnPlotCommonLatLng";
            this.btnPlotCommonLatLng.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnPlotCommonLatLng.OnDisabledState.BorderRadius = 1;
            this.btnPlotCommonLatLng.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPlotCommonLatLng.OnDisabledState.BorderThickness = 1;
            this.btnPlotCommonLatLng.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnPlotCommonLatLng.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnPlotCommonLatLng.OnDisabledState.IconLeftImage = null;
            this.btnPlotCommonLatLng.OnDisabledState.IconRightImage = null;
            this.btnPlotCommonLatLng.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnPlotCommonLatLng.onHoverState.BorderRadius = 1;
            this.btnPlotCommonLatLng.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPlotCommonLatLng.onHoverState.BorderThickness = 1;
            this.btnPlotCommonLatLng.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnPlotCommonLatLng.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnPlotCommonLatLng.onHoverState.IconLeftImage = null;
            this.btnPlotCommonLatLng.onHoverState.IconRightImage = null;
            this.btnPlotCommonLatLng.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnPlotCommonLatLng.OnIdleState.BorderRadius = 1;
            this.btnPlotCommonLatLng.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPlotCommonLatLng.OnIdleState.BorderThickness = 1;
            this.btnPlotCommonLatLng.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnPlotCommonLatLng.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnPlotCommonLatLng.OnIdleState.IconLeftImage = null;
            this.btnPlotCommonLatLng.OnIdleState.IconRightImage = null;
            this.btnPlotCommonLatLng.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnPlotCommonLatLng.OnPressedState.BorderRadius = 1;
            this.btnPlotCommonLatLng.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPlotCommonLatLng.OnPressedState.BorderThickness = 1;
            this.btnPlotCommonLatLng.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnPlotCommonLatLng.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnPlotCommonLatLng.OnPressedState.IconLeftImage = null;
            this.btnPlotCommonLatLng.OnPressedState.IconRightImage = null;
            this.btnPlotCommonLatLng.Size = new System.Drawing.Size(283, 46);
            this.btnPlotCommonLatLng.TabIndex = 22;
            this.btnPlotCommonLatLng.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPlotCommonLatLng.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPlotCommonLatLng.TextMarginLeft = 0;
            this.btnPlotCommonLatLng.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnPlotCommonLatLng.UseDefaultRadiusAndThickness = true;
            this.btnPlotCommonLatLng.Click += new System.EventHandler(this.btnPlotCommonLatLng_Click);
            // 
            // lbCommonLatLng
            // 
            this.lbCommonLatLng.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbCommonLatLng.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lbCommonLatLng.FormattingEnabled = true;
            this.lbCommonLatLng.ItemHeight = 21;
            this.lbCommonLatLng.Location = new System.Drawing.Point(0, 289);
            this.lbCommonLatLng.Margin = new System.Windows.Forms.Padding(2);
            this.lbCommonLatLng.Name = "lbCommonLatLng";
            this.lbCommonLatLng.Size = new System.Drawing.Size(283, 151);
            this.lbCommonLatLng.TabIndex = 21;
            // 
            // btnLocDetails
            // 
            this.btnLocDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLocDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLocDetails.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLocDetails.FlatAppearance.BorderSize = 0;
            this.btnLocDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocDetails.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnLocDetails.ForeColor = System.Drawing.Color.White;
            this.btnLocDetails.Location = new System.Drawing.Point(0, 246);
            this.btnLocDetails.Name = "btnLocDetails";
            this.btnLocDetails.Size = new System.Drawing.Size(283, 43);
            this.btnLocDetails.TabIndex = 20;
            this.btnLocDetails.Text = "Location Details";
            this.btnLocDetails.UseVisualStyleBackColor = false;
            this.btnLocDetails.Click += new System.EventHandler(this.btnLocDetails_Click);
            // 
            // bunifuElipse
            // 
            this.bunifuElipse.ElipseRadius = 20;
            this.bunifuElipse.TargetControl = this.gvProjectNum;
            // 
            // CGMapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1311, 894);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CGMapForm";
            this.Text = "CGMapForm";
            ((System.ComponentModel.ISupportInitialize)(this.gvProjectNum)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuDataGridView gvProjectNum;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private GMap.NET.WindowsForms.GMapControl gMap;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnPlotCommonLatLng;
        private System.Windows.Forms.ListBox lbCommonLatLng;
        private System.Windows.Forms.Button btnLocDetails;
        private Bunifu.UI.WinForms.BunifuLoader bunifuLoader;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.UI.WinForms.BunifuDatePicker DatePickerStartDate;
        private System.Windows.Forms.TextBox txtDateLimit;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnExtract;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse;
    }
}