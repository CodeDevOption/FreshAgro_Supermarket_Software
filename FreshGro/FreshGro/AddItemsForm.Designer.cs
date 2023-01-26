namespace FreshGro
{
    partial class AddItemsForm
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
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddItemsForm));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.adItemImg = new Siticone.UI.WinForms.SiticonePictureBox();
            this.adItemTitle = new System.Windows.Forms.Label();
            this.siticoneButton5 = new Siticone.UI.WinForms.SiticoneButton();
            this.siticoneButton3 = new Siticone.UI.WinForms.SiticoneButton();
            this.label2 = new System.Windows.Forms.Label();
            this.addItemQuantity = new Bunifu.UI.WinForms.BunifuTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.adItemImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // adItemImg
            // 
            this.adItemImg.BorderRadius = 10;
            this.adItemImg.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(255)))), ((int)(((byte)(221)))));
            this.adItemImg.Location = new System.Drawing.Point(35, 40);
            this.adItemImg.Name = "adItemImg";
            this.adItemImg.ShadowDecoration.Parent = this.adItemImg;
            this.adItemImg.Size = new System.Drawing.Size(150, 150);
            this.adItemImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.adItemImg.TabIndex = 18;
            this.adItemImg.TabStop = false;
            // 
            // adItemTitle
            // 
            this.adItemTitle.AutoSize = true;
            this.adItemTitle.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adItemTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(95)))));
            this.adItemTitle.Location = new System.Drawing.Point(208, 41);
            this.adItemTitle.Name = "adItemTitle";
            this.adItemTitle.Size = new System.Drawing.Size(150, 32);
            this.adItemTitle.TabIndex = 19;
            this.adItemTitle.Text = "Red Apple";
            // 
            // siticoneButton5
            // 
            this.siticoneButton5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(204)))), ((int)(((byte)(119)))));
            this.siticoneButton5.BorderRadius = 4;
            this.siticoneButton5.CheckedState.Parent = this.siticoneButton5;
            this.siticoneButton5.CustomImages.Parent = this.siticoneButton5;
            this.siticoneButton5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(204)))), ((int)(((byte)(119)))));
            this.siticoneButton5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneButton5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.siticoneButton5.HoveredState.Parent = this.siticoneButton5;
            this.siticoneButton5.Image = ((System.Drawing.Image)(resources.GetObject("siticoneButton5.Image")));
            this.siticoneButton5.Location = new System.Drawing.Point(337, 258);
            this.siticoneButton5.Name = "siticoneButton5";
            this.siticoneButton5.ShadowDecoration.Parent = this.siticoneButton5;
            this.siticoneButton5.Size = new System.Drawing.Size(110, 40);
            this.siticoneButton5.TabIndex = 28;
            this.siticoneButton5.Text = "Add";
            this.siticoneButton5.Click += new System.EventHandler(this.siticoneButton5_Click);
            // 
            // siticoneButton3
            // 
            this.siticoneButton3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(180)))), ((int)(((byte)(204)))));
            this.siticoneButton3.BorderRadius = 4;
            this.siticoneButton3.CheckedState.Parent = this.siticoneButton3;
            this.siticoneButton3.CustomImages.Parent = this.siticoneButton3;
            this.siticoneButton3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(180)))), ((int)(((byte)(204)))));
            this.siticoneButton3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.siticoneButton3.HoveredState.Parent = this.siticoneButton3;
            this.siticoneButton3.Location = new System.Drawing.Point(454, 258);
            this.siticoneButton3.Name = "siticoneButton3";
            this.siticoneButton3.ShadowDecoration.Parent = this.siticoneButton3;
            this.siticoneButton3.Size = new System.Drawing.Size(110, 40);
            this.siticoneButton3.TabIndex = 27;
            this.siticoneButton3.Text = "Cancel";
            this.siticoneButton3.Click += new System.EventHandler(this.siticoneButton3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(120)))), ((int)(((byte)(105)))));
            this.label2.Location = new System.Drawing.Point(211, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 14);
            this.label2.TabIndex = 33;
            this.label2.Text = "Quantity";
            // 
            // addItemQuantity
            // 
            this.addItemQuantity.AcceptsReturn = false;
            this.addItemQuantity.AcceptsTab = false;
            this.addItemQuantity.AnimationSpeed = 200;
            this.addItemQuantity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.addItemQuantity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.addItemQuantity.BackColor = System.Drawing.Color.Transparent;
            this.addItemQuantity.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addItemQuantity.BackgroundImage")));
            this.addItemQuantity.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(204)))), ((int)(((byte)(119)))));
            this.addItemQuantity.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.addItemQuantity.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(204)))), ((int)(((byte)(119)))));
            this.addItemQuantity.BorderColorIdle = System.Drawing.Color.Silver;
            this.addItemQuantity.BorderRadius = 10;
            this.addItemQuantity.BorderThickness = 1;
            this.addItemQuantity.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.addItemQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addItemQuantity.DefaultFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addItemQuantity.DefaultText = "";
            this.addItemQuantity.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(255)))), ((int)(((byte)(221)))));
            this.addItemQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(120)))), ((int)(((byte)(105)))));
            this.addItemQuantity.HideSelection = true;
            this.addItemQuantity.IconLeft = null;
            this.addItemQuantity.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.addItemQuantity.IconPadding = 10;
            this.addItemQuantity.IconRight = null;
            this.addItemQuantity.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.addItemQuantity.Lines = new string[0];
            this.addItemQuantity.Location = new System.Drawing.Point(207, 153);
            this.addItemQuantity.MaxLength = 32767;
            this.addItemQuantity.MinimumSize = new System.Drawing.Size(1, 1);
            this.addItemQuantity.Modified = false;
            this.addItemQuantity.Multiline = false;
            this.addItemQuantity.Name = "addItemQuantity";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(204)))), ((int)(((byte)(119)))));
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.addItemQuantity.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.addItemQuantity.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(204)))), ((int)(((byte)(119)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.addItemQuantity.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(255)))), ((int)(((byte)(221)))));
            stateProperties4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(120)))), ((int)(((byte)(105)))));
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.addItemQuantity.OnIdleState = stateProperties4;
            this.addItemQuantity.Padding = new System.Windows.Forms.Padding(3);
            this.addItemQuantity.PasswordChar = '\0';
            this.addItemQuantity.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(120)))), ((int)(((byte)(105)))));
            this.addItemQuantity.PlaceholderText = "Quantity";
            this.addItemQuantity.ReadOnly = false;
            this.addItemQuantity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.addItemQuantity.SelectedText = "";
            this.addItemQuantity.SelectionLength = 0;
            this.addItemQuantity.SelectionStart = 0;
            this.addItemQuantity.ShortcutsEnabled = false;
            this.addItemQuantity.Size = new System.Drawing.Size(287, 37);
            this.addItemQuantity.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.addItemQuantity.TabIndex = 29;
            this.addItemQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.addItemQuantity.TextMarginBottom = 0;
            this.addItemQuantity.TextMarginLeft = 3;
            this.addItemQuantity.TextMarginTop = 0;
            this.addItemQuantity.TextPlaceholder = "Quantity";
            this.addItemQuantity.UseSystemPasswordChar = false;
            this.addItemQuantity.WordWrap = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(120)))), ((int)(((byte)(105)))));
            this.label1.Location = new System.Drawing.Point(500, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 18);
            this.label1.TabIndex = 33;
            this.label1.Text = "Items";
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox1.AutoSizeHeight = true;
            this.bunifuPictureBox1.BorderRadius = 0;
            this.bunifuPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuPictureBox1.Image")));
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(522, 12);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(61, 61);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 34;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            // 
            // AddItemsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(214)))), ((int)(((byte)(159)))));
            this.ClientSize = new System.Drawing.Size(595, 324);
            this.Controls.Add(this.bunifuPictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addItemQuantity);
            this.Controls.Add(this.siticoneButton5);
            this.Controls.Add(this.siticoneButton3);
            this.Controls.Add(this.adItemTitle);
            this.Controls.Add(this.adItemImg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddItemsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddItemsForm";
            this.Load += new System.EventHandler(this.AddItemsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adItemImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Siticone.UI.WinForms.SiticonePictureBox adItemImg;
        private System.Windows.Forms.Label adItemTitle;
        private Siticone.UI.WinForms.SiticoneButton siticoneButton5;
        private Siticone.UI.WinForms.SiticoneButton siticoneButton3;
        private System.Windows.Forms.Label label2;
        private Bunifu.UI.WinForms.BunifuTextBox addItemQuantity;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
    }
}