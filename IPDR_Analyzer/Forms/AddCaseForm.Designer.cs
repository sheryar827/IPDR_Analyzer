namespace IPDR_Analyzer.Forms
{
    partial class AddCaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCaseForm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.gvShowCaseProject = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.viewCasesProjects = new System.Windows.Forms.GroupBox();
            this.cmbBoxProject = new System.Windows.Forms.ComboBox();
            this.btnSaveProjectCase = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.panelProject = new Bunifu.UI.WinForms.BunifuShadowPanel();
            this.gbPrject = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvShowCaseProject)).BeginInit();
            this.viewCasesProjects.SuspendLayout();
            this.panelProject.SuspendLayout();
            this.gbPrject.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this.gvShowCaseProject;
            // 
            // gvShowCaseProject
            // 
            this.gvShowCaseProject.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(242)))), ((int)(((byte)(203)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.gvShowCaseProject.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gvShowCaseProject.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvShowCaseProject.BackgroundColor = System.Drawing.Color.White;
            this.gvShowCaseProject.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvShowCaseProject.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.gvShowCaseProject.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(164)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvShowCaseProject.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gvShowCaseProject.ColumnHeadersHeight = 40;
            this.gvShowCaseProject.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(242)))), ((int)(((byte)(203)))));
            this.gvShowCaseProject.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.gvShowCaseProject.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gvShowCaseProject.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(225)))), ((int)(((byte)(132)))));
            this.gvShowCaseProject.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.gvShowCaseProject.CurrentTheme.BackColor = System.Drawing.Color.LimeGreen;
            this.gvShowCaseProject.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(240)))), ((int)(((byte)(193)))));
            this.gvShowCaseProject.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.LimeGreen;
            this.gvShowCaseProject.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.gvShowCaseProject.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gvShowCaseProject.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(164)))), ((int)(((byte)(40)))));
            this.gvShowCaseProject.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.gvShowCaseProject.CurrentTheme.Name = null;
            this.gvShowCaseProject.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(245)))), ((int)(((byte)(214)))));
            this.gvShowCaseProject.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.gvShowCaseProject.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gvShowCaseProject.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(225)))), ((int)(((byte)(132)))));
            this.gvShowCaseProject.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.gvShowCaseProject.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(245)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(225)))), ((int)(((byte)(132)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvShowCaseProject.DefaultCellStyle = dataGridViewCellStyle3;
            this.gvShowCaseProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvShowCaseProject.EnableHeadersVisualStyles = false;
            this.gvShowCaseProject.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(240)))), ((int)(((byte)(193)))));
            this.gvShowCaseProject.HeaderBackColor = System.Drawing.Color.LimeGreen;
            this.gvShowCaseProject.HeaderBgColor = System.Drawing.Color.Empty;
            this.gvShowCaseProject.HeaderForeColor = System.Drawing.Color.White;
            this.gvShowCaseProject.Location = new System.Drawing.Point(8, 39);
            this.gvShowCaseProject.Name = "gvShowCaseProject";
            this.gvShowCaseProject.RowHeadersVisible = false;
            this.gvShowCaseProject.RowTemplate.Height = 40;
            this.gvShowCaseProject.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gvShowCaseProject.Size = new System.Drawing.Size(828, 762);
            this.gvShowCaseProject.TabIndex = 0;
            this.gvShowCaseProject.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.LimeGreen;
            // 
            // viewCasesProjects
            // 
            this.viewCasesProjects.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.viewCasesProjects.Controls.Add(this.gvShowCaseProject);
            this.viewCasesProjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewCasesProjects.Font = new System.Drawing.Font("Segoe UI Semibold", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewCasesProjects.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.viewCasesProjects.Location = new System.Drawing.Point(583, 0);
            this.viewCasesProjects.Margin = new System.Windows.Forms.Padding(2);
            this.viewCasesProjects.Name = "viewCasesProjects";
            this.viewCasesProjects.Padding = new System.Windows.Forms.Padding(8);
            this.viewCasesProjects.Size = new System.Drawing.Size(844, 809);
            this.viewCasesProjects.TabIndex = 39;
            this.viewCasesProjects.TabStop = false;
            this.viewCasesProjects.Text = "Cases / Projects";
            // 
            // cmbBoxProject
            // 
            this.cmbBoxProject.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbBoxProject.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbBoxProject.BackColor = System.Drawing.Color.White;
            this.cmbBoxProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbBoxProject.FormattingEnabled = true;
            this.cmbBoxProject.Items.AddRange(new object[] {
            "Hamlet",
            "Venom",
            "ThunderBird",
            "Safari",
            "Morgan",
            "Mike",
            "Bravo",
            "Gama",
            "Beta",
            "Colombus",
            "Saidu Sharif",
            "Mingora",
            "Rahimabad ",
            "Banr ",
            "Ghalegay ",
            "Shamozai ",
            "Kabal ",
            "Shah Dehrai",
            "Kanju ",
            "Matta ",
            "Shahedano Wenai (Chuprial)",
            "KKS ",
            "Manglor ",
            "Charbagh ",
            "Fatehpur",
            "Kalakot",
            "Madyan",
            "Bahrain ",
            "Kalam ",
            "Utrorr",
            "Kokarai ",
            "Women Police Station Swat"});
            this.cmbBoxProject.Location = new System.Drawing.Point(8, 39);
            this.cmbBoxProject.Name = "cmbBoxProject";
            this.cmbBoxProject.Size = new System.Drawing.Size(494, 39);
            this.cmbBoxProject.TabIndex = 0;
            // 
            // btnSaveProjectCase
            // 
            this.btnSaveProjectCase.AllowAnimations = true;
            this.btnSaveProjectCase.AllowMouseEffects = true;
            this.btnSaveProjectCase.AllowToggling = true;
            this.btnSaveProjectCase.AnimationSpeed = 200;
            this.btnSaveProjectCase.AutoGenerateColors = false;
            this.btnSaveProjectCase.AutoRoundBorders = true;
            this.btnSaveProjectCase.AutoSizeLeftIcon = true;
            this.btnSaveProjectCase.AutoSizeRightIcon = true;
            this.btnSaveProjectCase.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveProjectCase.BackColor1 = System.Drawing.Color.White;
            this.btnSaveProjectCase.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSaveProjectCase.BackgroundImage")));
            this.btnSaveProjectCase.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSaveProjectCase.ButtonText = "Save";
            this.btnSaveProjectCase.ButtonTextMarginLeft = 0;
            this.btnSaveProjectCase.ColorContrastOnClick = 45;
            this.btnSaveProjectCase.ColorContrastOnHover = 45;
            this.btnSaveProjectCase.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnSaveProjectCase.CustomizableEdges = borderEdges1;
            this.btnSaveProjectCase.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSaveProjectCase.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSaveProjectCase.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSaveProjectCase.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSaveProjectCase.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSaveProjectCase.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnSaveProjectCase.Font = new System.Drawing.Font("Segoe UI Semibold", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveProjectCase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSaveProjectCase.IconLeft = null;
            this.btnSaveProjectCase.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveProjectCase.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnSaveProjectCase.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnSaveProjectCase.IconMarginLeft = 11;
            this.btnSaveProjectCase.IconPadding = 10;
            this.btnSaveProjectCase.IconRight = null;
            this.btnSaveProjectCase.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveProjectCase.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnSaveProjectCase.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnSaveProjectCase.IconSize = 25;
            this.btnSaveProjectCase.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(74)))), ((int)(((byte)(86)))));
            this.btnSaveProjectCase.IdleBorderRadius = 49;
            this.btnSaveProjectCase.IdleBorderThickness = 1;
            this.btnSaveProjectCase.IdleFillColor = System.Drawing.Color.White;
            this.btnSaveProjectCase.IdleIconLeftImage = null;
            this.btnSaveProjectCase.IdleIconRightImage = null;
            this.btnSaveProjectCase.IndicateFocus = true;
            this.btnSaveProjectCase.Location = new System.Drawing.Point(8, 93);
            this.btnSaveProjectCase.Name = "btnSaveProjectCase";
            this.btnSaveProjectCase.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSaveProjectCase.OnDisabledState.BorderRadius = 51;
            this.btnSaveProjectCase.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSaveProjectCase.OnDisabledState.BorderThickness = 1;
            this.btnSaveProjectCase.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSaveProjectCase.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSaveProjectCase.OnDisabledState.IconLeftImage = null;
            this.btnSaveProjectCase.OnDisabledState.IconRightImage = null;
            this.btnSaveProjectCase.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSaveProjectCase.onHoverState.BorderRadius = 51;
            this.btnSaveProjectCase.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSaveProjectCase.onHoverState.BorderThickness = 1;
            this.btnSaveProjectCase.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSaveProjectCase.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnSaveProjectCase.onHoverState.IconLeftImage = null;
            this.btnSaveProjectCase.onHoverState.IconRightImage = null;
            this.btnSaveProjectCase.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSaveProjectCase.OnIdleState.BorderRadius = 51;
            this.btnSaveProjectCase.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSaveProjectCase.OnIdleState.BorderThickness = 1;
            this.btnSaveProjectCase.OnIdleState.FillColor = System.Drawing.Color.White;
            this.btnSaveProjectCase.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSaveProjectCase.OnIdleState.IconLeftImage = null;
            this.btnSaveProjectCase.OnIdleState.IconRightImage = null;
            this.btnSaveProjectCase.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSaveProjectCase.OnPressedState.BorderRadius = 51;
            this.btnSaveProjectCase.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSaveProjectCase.OnPressedState.BorderThickness = 1;
            this.btnSaveProjectCase.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSaveProjectCase.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnSaveProjectCase.OnPressedState.IconLeftImage = null;
            this.btnSaveProjectCase.OnPressedState.IconRightImage = null;
            this.btnSaveProjectCase.Size = new System.Drawing.Size(494, 51);
            this.btnSaveProjectCase.TabIndex = 1;
            this.btnSaveProjectCase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSaveProjectCase.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSaveProjectCase.TextMarginLeft = 0;
            this.btnSaveProjectCase.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnSaveProjectCase.UseDefaultRadiusAndThickness = true;
            this.btnSaveProjectCase.Click += new System.EventHandler(this.btnSaveProjectCase_Click);
            // 
            // panelProject
            // 
            this.panelProject.AutoScroll = true;
            this.panelProject.BackColor = System.Drawing.Color.White;
            this.panelProject.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.panelProject.BorderRadius = 20;
            this.panelProject.BorderThickness = 0;
            this.panelProject.Controls.Add(this.gbPrject);
            this.panelProject.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelProject.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Solid;
            this.panelProject.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.ForwardDiagonal;
            this.panelProject.Location = new System.Drawing.Point(0, 0);
            this.panelProject.Name = "panelProject";
            this.panelProject.PanelColor = System.Drawing.Color.White;
            this.panelProject.PanelColor2 = System.Drawing.Color.White;
            this.panelProject.ShadowColor = System.Drawing.Color.DarkGray;
            this.panelProject.ShadowDept = 2;
            this.panelProject.ShadowDepth = 7;
            this.panelProject.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.Surrounded;
            this.panelProject.ShadowTopLeftVisible = false;
            this.panelProject.Size = new System.Drawing.Size(583, 809);
            this.panelProject.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat;
            this.panelProject.TabIndex = 40;
            // 
            // gbPrject
            // 
            this.gbPrject.BackColor = System.Drawing.Color.White;
            this.gbPrject.Controls.Add(this.cmbBoxProject);
            this.gbPrject.Controls.Add(this.btnSaveProjectCase);
            this.gbPrject.Font = new System.Drawing.Font("Segoe UI Semibold", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPrject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gbPrject.Location = new System.Drawing.Point(35, 39);
            this.gbPrject.Name = "gbPrject";
            this.gbPrject.Padding = new System.Windows.Forms.Padding(8);
            this.gbPrject.Size = new System.Drawing.Size(510, 152);
            this.gbPrject.TabIndex = 35;
            this.gbPrject.TabStop = false;
            this.gbPrject.Text = "Project";
            // 
            // AddCaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1427, 809);
            this.Controls.Add(this.viewCasesProjects);
            this.Controls.Add(this.panelProject);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddCaseForm";
            this.Text = "Add Case";
            this.Load += new System.EventHandler(this.AddCaseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvShowCaseProject)).EndInit();
            this.viewCasesProjects.ResumeLayout(false);
            this.panelProject.ResumeLayout(false);
            this.gbPrject.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuDataGridView gvShowCaseProject;
        private System.Windows.Forms.GroupBox viewCasesProjects;
        private System.Windows.Forms.ComboBox cmbBoxProject;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSaveProjectCase;
        private Bunifu.UI.WinForms.BunifuShadowPanel panelProject;
        private System.Windows.Forms.GroupBox gbPrject;
    }
}