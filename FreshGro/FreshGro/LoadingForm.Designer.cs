namespace FreshGro
{
    partial class LoadingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadingForm));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.percentage = new System.Windows.Forms.Label();
            this.LoadingProgressBar = new Bunifu.UI.WinForms.BunifuProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox1.AutoSizeHeight = true;
            this.bunifuPictureBox1.BorderRadius = 0;
            this.bunifuPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuPictureBox1.Image")));
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(197, 30);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(81, 81);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 0;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(57)))), ((int)(((byte)(34)))));
            this.label1.Location = new System.Drawing.Point(62, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome to Grocery Shop, the ultimate tool for managing your grocery list and kee" +
    "ping track of your pantry items.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // percentage
            // 
            this.percentage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.percentage.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percentage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(90)))));
            this.percentage.Location = new System.Drawing.Point(211, 229);
            this.percentage.Name = "percentage";
            this.percentage.Size = new System.Drawing.Size(52, 33);
            this.percentage.TabIndex = 1;
            this.percentage.Text = "0%";
            this.percentage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoadingProgressBar
            // 
            this.LoadingProgressBar.AllowAnimations = false;
            this.LoadingProgressBar.Animation = 0;
            this.LoadingProgressBar.AnimationSpeed = 220;
            this.LoadingProgressBar.AnimationStep = 10;
            this.LoadingProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.LoadingProgressBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LoadingProgressBar.BackgroundImage")));
            this.LoadingProgressBar.BorderColor = System.Drawing.Color.Transparent;
            this.LoadingProgressBar.BorderRadius = 1;
            this.LoadingProgressBar.BorderThickness = 1;
            this.LoadingProgressBar.Location = new System.Drawing.Point(-2, 266);
            this.LoadingProgressBar.Maximum = 100;
            this.LoadingProgressBar.MaximumValue = 100;
            this.LoadingProgressBar.Minimum = 0;
            this.LoadingProgressBar.MinimumValue = 0;
            this.LoadingProgressBar.Name = "LoadingProgressBar";
            this.LoadingProgressBar.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LoadingProgressBar.ProgressBackColor = System.Drawing.Color.Transparent;
            this.LoadingProgressBar.ProgressColorLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(118)))));
            this.LoadingProgressBar.ProgressColorRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(118)))));
            this.LoadingProgressBar.Size = new System.Drawing.Size(475, 13);
            this.LoadingProgressBar.TabIndex = 2;
            this.LoadingProgressBar.Value = 0;
            this.LoadingProgressBar.ValueByTransition = 0;
            // 
            // LoadingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(214)))), ((int)(((byte)(159)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(469, 278);
            this.Controls.Add(this.LoadingProgressBar);
            this.Controls.Add(this.percentage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuPictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoadingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoadingForm";
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private Bunifu.UI.WinForms.BunifuProgressBar LoadingProgressBar;
        private System.Windows.Forms.Label percentage;
        private System.Windows.Forms.Label label1;
    }
}

