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
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuProgressBar1 = new Bunifu.UI.WinForms.BunifuProgressBar();
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
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(90)))));
            this.label2.Location = new System.Drawing.Point(211, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "82%";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuProgressBar1
            // 
            this.bunifuProgressBar1.AllowAnimations = false;
            this.bunifuProgressBar1.Animation = 0;
            this.bunifuProgressBar1.AnimationSpeed = 220;
            this.bunifuProgressBar1.AnimationStep = 10;
            this.bunifuProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuProgressBar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuProgressBar1.BackgroundImage")));
            this.bunifuProgressBar1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuProgressBar1.BorderRadius = 1;
            this.bunifuProgressBar1.BorderThickness = 1;
            this.bunifuProgressBar1.Location = new System.Drawing.Point(-2, 266);
            this.bunifuProgressBar1.Maximum = 100;
            this.bunifuProgressBar1.MaximumValue = 100;
            this.bunifuProgressBar1.Minimum = 0;
            this.bunifuProgressBar1.MinimumValue = 0;
            this.bunifuProgressBar1.Name = "bunifuProgressBar1";
            this.bunifuProgressBar1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.bunifuProgressBar1.ProgressBackColor = System.Drawing.Color.Transparent;
            this.bunifuProgressBar1.ProgressColorLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(118)))));
            this.bunifuProgressBar1.ProgressColorRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(118)))));
            this.bunifuProgressBar1.Size = new System.Drawing.Size(468, 13);
            this.bunifuProgressBar1.TabIndex = 2;
            this.bunifuProgressBar1.Value = 82;
            this.bunifuProgressBar1.ValueByTransition = 82;
            // 
            // LoadingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(214)))), ((int)(((byte)(159)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(469, 278);
            this.Controls.Add(this.bunifuProgressBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuPictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoadingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private Bunifu.UI.WinForms.BunifuProgressBar bunifuProgressBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

