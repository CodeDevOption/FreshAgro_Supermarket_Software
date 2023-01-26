namespace FreshGro
{
    partial class AdminRecords
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminRecords));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.label8 = new System.Windows.Forms.Label();
            this.filerForm = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.RecordDataGridView = new Siticone.UI.WinForms.SiticoneDataGridView();
            this.siticoneButton2 = new Siticone.UI.WinForms.SiticoneButton();
            this.label6 = new System.Windows.Forms.Label();
            this.filterTo = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.searchBox = new Bunifu.UI.WinForms.BunifuTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SerchBydate = new Siticone.UI.WinForms.SiticoneCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.RecordDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(120)))), ((int)(((byte)(105)))));
            this.label8.Location = new System.Drawing.Point(30, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 18);
            this.label8.TabIndex = 34;
            this.label8.Text = "Filter Records";
            // 
            // filerForm
            // 
            this.filerForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(255)))), ((int)(((byte)(221)))));
            this.filerForm.BorderRadius = 4;
            this.filerForm.Color = System.Drawing.Color.Silver;
            this.filerForm.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.filerForm.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.filerForm.DisabledColor = System.Drawing.Color.Gray;
            this.filerForm.DisplayWeekNumbers = false;
            this.filerForm.DPHeight = 0;
            this.filerForm.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.filerForm.FillDatePicker = false;
            this.filerForm.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.filerForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(120)))), ((int)(((byte)(105)))));
            this.filerForm.Icon = ((System.Drawing.Image)(resources.GetObject("filerForm.Icon")));
            this.filerForm.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(120)))), ((int)(((byte)(105)))));
            this.filerForm.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.filerForm.LeftTextMargin = 5;
            this.filerForm.Location = new System.Drawing.Point(31, 55);
            this.filerForm.MinimumSize = new System.Drawing.Size(4, 32);
            this.filerForm.Name = "filerForm";
            this.filerForm.Size = new System.Drawing.Size(220, 32);
            this.filerForm.TabIndex = 33;
            this.filerForm.Value = new System.DateTime(2023, 1, 11, 10, 13, 0, 0);
            // 
            // RecordDataGridView
            // 
            this.RecordDataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(218)))));
            this.RecordDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.RecordDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RecordDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.RecordDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RecordDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.RecordDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RecordDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.RecordDataGridView.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(120)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(191)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.RecordDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.RecordDataGridView.EnableHeadersVisualStyles = false;
            this.RecordDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(224)))), ((int)(((byte)(216)))));
            this.RecordDataGridView.Location = new System.Drawing.Point(33, 102);
            this.RecordDataGridView.Name = "RecordDataGridView";
            this.RecordDataGridView.RowHeadersVisible = false;
            this.RecordDataGridView.RowTemplate.Height = 35;
            this.RecordDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RecordDataGridView.ShowCellErrors = false;
            this.RecordDataGridView.Size = new System.Drawing.Size(970, 509);
            this.RecordDataGridView.TabIndex = 31;
            this.RecordDataGridView.Theme = Siticone.UI.WinForms.Enums.DataGridViewPresetThemes.GreenSea;
            this.RecordDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(218)))));
            this.RecordDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.RecordDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.RecordDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.RecordDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.RecordDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.RecordDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(224)))), ((int)(((byte)(216)))));
            this.RecordDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.RecordDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.RecordDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.RecordDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.RecordDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.RecordDataGridView.ThemeStyle.HeaderStyle.Height = 30;
            this.RecordDataGridView.ThemeStyle.ReadOnly = false;
            this.RecordDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(230)))));
            this.RecordDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.RecordDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecordDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(120)))), ((int)(((byte)(105)))));
            this.RecordDataGridView.ThemeStyle.RowsStyle.Height = 35;
            this.RecordDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(191)))), ((int)(((byte)(173)))));
            this.RecordDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            // 
            // siticoneButton2
            // 
            this.siticoneButton2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(133)))), ((int)(((byte)(204)))));
            this.siticoneButton2.BorderRadius = 4;
            this.siticoneButton2.CheckedState.Parent = this.siticoneButton2;
            this.siticoneButton2.CustomImages.Parent = this.siticoneButton2;
            this.siticoneButton2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(133)))), ((int)(((byte)(204)))));
            this.siticoneButton2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.siticoneButton2.HoveredState.Parent = this.siticoneButton2;
            this.siticoneButton2.Image = ((System.Drawing.Image)(resources.GetObject("siticoneButton2.Image")));
            this.siticoneButton2.ImageOffset = new System.Drawing.Point(1, 1);
            this.siticoneButton2.Location = new System.Drawing.Point(909, 50);
            this.siticoneButton2.Name = "siticoneButton2";
            this.siticoneButton2.ShadowDecoration.Parent = this.siticoneButton2;
            this.siticoneButton2.Size = new System.Drawing.Size(37, 37);
            this.siticoneButton2.TabIndex = 30;
            this.siticoneButton2.Click += new System.EventHandler(this.siticoneButton2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(120)))), ((int)(((byte)(105)))));
            this.label6.Location = new System.Drawing.Point(630, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 14);
            this.label6.TabIndex = 29;
            this.label6.Text = "Search";
            // 
            // filterTo
            // 
            this.filterTo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(255)))), ((int)(((byte)(221)))));
            this.filterTo.BorderRadius = 4;
            this.filterTo.Color = System.Drawing.Color.Silver;
            this.filterTo.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.filterTo.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.filterTo.DisabledColor = System.Drawing.Color.Gray;
            this.filterTo.DisplayWeekNumbers = false;
            this.filterTo.DPHeight = 0;
            this.filterTo.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.filterTo.FillDatePicker = false;
            this.filterTo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.filterTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(120)))), ((int)(((byte)(105)))));
            this.filterTo.Icon = ((System.Drawing.Image)(resources.GetObject("filterTo.Icon")));
            this.filterTo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(120)))), ((int)(((byte)(105)))));
            this.filterTo.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.filterTo.LeftTextMargin = 5;
            this.filterTo.Location = new System.Drawing.Point(264, 55);
            this.filterTo.MinimumSize = new System.Drawing.Size(4, 32);
            this.filterTo.Name = "filterTo";
            this.filterTo.Size = new System.Drawing.Size(220, 32);
            this.filterTo.TabIndex = 33;
            this.filterTo.Value = new System.DateTime(2023, 1, 11, 10, 13, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(120)))), ((int)(((byte)(105)))));
            this.label1.Location = new System.Drawing.Point(268, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 14);
            this.label1.TabIndex = 34;
            this.label1.Text = "End Date";
            // 
            // searchBox
            // 
            this.searchBox.AcceptsReturn = false;
            this.searchBox.AcceptsTab = false;
            this.searchBox.AnimationSpeed = 200;
            this.searchBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.searchBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.searchBox.BackColor = System.Drawing.Color.Transparent;
            this.searchBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchBox.BackgroundImage")));
            this.searchBox.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(204)))), ((int)(((byte)(119)))));
            this.searchBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.searchBox.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(204)))), ((int)(((byte)(119)))));
            this.searchBox.BorderColorIdle = System.Drawing.Color.Silver;
            this.searchBox.BorderRadius = 10;
            this.searchBox.BorderThickness = 1;
            this.searchBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.searchBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchBox.DefaultFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.DefaultText = "";
            this.searchBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(255)))), ((int)(((byte)(221)))));
            this.searchBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(120)))), ((int)(((byte)(105)))));
            this.searchBox.HideSelection = true;
            this.searchBox.IconLeft = null;
            this.searchBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.searchBox.IconPadding = 10;
            this.searchBox.IconRight = null;
            this.searchBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.searchBox.Lines = new string[0];
            this.searchBox.Location = new System.Drawing.Point(625, 54);
            this.searchBox.MaxLength = 32767;
            this.searchBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.searchBox.Modified = false;
            this.searchBox.Multiline = false;
            this.searchBox.Name = "searchBox";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(204)))), ((int)(((byte)(119)))));
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.searchBox.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.searchBox.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(204)))), ((int)(((byte)(119)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.searchBox.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(255)))), ((int)(((byte)(221)))));
            stateProperties4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(120)))), ((int)(((byte)(105)))));
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.searchBox.OnIdleState = stateProperties4;
            this.searchBox.Padding = new System.Windows.Forms.Padding(3);
            this.searchBox.PasswordChar = '\0';
            this.searchBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(120)))), ((int)(((byte)(105)))));
            this.searchBox.PlaceholderText = "Search";
            this.searchBox.ReadOnly = false;
            this.searchBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.searchBox.SelectedText = "";
            this.searchBox.SelectionLength = 0;
            this.searchBox.SelectionStart = 0;
            this.searchBox.ShortcutsEnabled = false;
            this.searchBox.Size = new System.Drawing.Size(278, 33);
            this.searchBox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.searchBox.TabIndex = 35;
            this.searchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.searchBox.TextMarginBottom = 0;
            this.searchBox.TextMarginLeft = 3;
            this.searchBox.TextMarginTop = 0;
            this.searchBox.TextPlaceholder = "Search";
            this.searchBox.UseSystemPasswordChar = false;
            this.searchBox.WordWrap = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(120)))), ((int)(((byte)(105)))));
            this.label2.Location = new System.Drawing.Point(28, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 14);
            this.label2.TabIndex = 34;
            this.label2.Text = "Start Date";
            // 
            // SerchBydate
            // 
            this.SerchBydate.AutoSize = true;
            this.SerchBydate.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SerchBydate.CheckedState.BorderRadius = 2;
            this.SerchBydate.CheckedState.BorderThickness = 0;
            this.SerchBydate.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SerchBydate.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.SerchBydate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(120)))), ((int)(((byte)(105)))));
            this.SerchBydate.Location = new System.Drawing.Point(499, 66);
            this.SerchBydate.Name = "SerchBydate";
            this.SerchBydate.Size = new System.Drawing.Size(97, 18);
            this.SerchBydate.TabIndex = 36;
            this.SerchBydate.Text = "Filter By Date";
            this.SerchBydate.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(255)))), ((int)(((byte)(221)))));
            this.SerchBydate.UncheckedState.BorderRadius = 2;
            this.SerchBydate.UncheckedState.BorderThickness = 0;
            this.SerchBydate.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(255)))), ((int)(((byte)(221)))));
            this.SerchBydate.UseVisualStyleBackColor = true;
            // 
            // AdminRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SerchBydate);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.filterTo);
            this.Controls.Add(this.filerForm);
            this.Controls.Add(this.RecordDataGridView);
            this.Controls.Add(this.siticoneButton2);
            this.Controls.Add(this.label6);
            this.Name = "AdminRecords";
            this.Size = new System.Drawing.Size(1040, 628);
            this.Load += new System.EventHandler(this.AdminRecords_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RecordDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private Bunifu.UI.WinForms.BunifuDatePicker filerForm;
        private Siticone.UI.WinForms.SiticoneDataGridView RecordDataGridView;
        private Siticone.UI.WinForms.SiticoneButton siticoneButton2;
        private System.Windows.Forms.Label label6;
        private Bunifu.UI.WinForms.BunifuDatePicker filterTo;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuTextBox searchBox;
        private System.Windows.Forms.Label label2;
        private Siticone.UI.WinForms.SiticoneCheckBox SerchBydate;

    }
}
