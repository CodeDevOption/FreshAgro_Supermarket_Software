namespace FreshGro
{
    partial class ItemCard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemCard));
            this.itemPic = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.itemPriceLab = new System.Windows.Forms.Label();
            this.itemPrice = new System.Windows.Forms.Label();
            this.itemStock = new System.Windows.Forms.Label();
            this.itemSuplier = new System.Windows.Forms.Label();
            this.itemCodelab = new System.Windows.Forms.Label();
            this.itemper = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.itemPic)).BeginInit();
            this.SuspendLayout();
            // 
            // itemPic
            // 
            this.itemPic.AllowFocused = false;
            this.itemPic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.itemPic.AutoSizeHeight = true;
            this.itemPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.itemPic.BorderRadius = 0;
            this.itemPic.Image = ((System.Drawing.Image)(resources.GetObject("itemPic.Image")));
            this.itemPic.IsCircle = true;
            this.itemPic.Location = new System.Drawing.Point(9, 12);
            this.itemPic.Name = "itemPic";
            this.itemPic.Size = new System.Drawing.Size(83, 83);
            this.itemPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.itemPic.TabIndex = 0;
            this.itemPic.TabStop = false;
            this.itemPic.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // itemPriceLab
            // 
            this.itemPriceLab.AutoSize = true;
            this.itemPriceLab.BackColor = System.Drawing.Color.Transparent;
            this.itemPriceLab.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemPriceLab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(120)))), ((int)(((byte)(105)))));
            this.itemPriceLab.Location = new System.Drawing.Point(99, 14);
            this.itemPriceLab.Name = "itemPriceLab";
            this.itemPriceLab.Size = new System.Drawing.Size(87, 19);
            this.itemPriceLab.TabIndex = 37;
            this.itemPriceLab.Text = "Red Apple";
            // 
            // itemPrice
            // 
            this.itemPrice.AutoSize = true;
            this.itemPrice.BackColor = System.Drawing.Color.Transparent;
            this.itemPrice.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(120)))), ((int)(((byte)(105)))));
            this.itemPrice.Location = new System.Drawing.Point(99, 43);
            this.itemPrice.Name = "itemPrice";
            this.itemPrice.Size = new System.Drawing.Size(67, 15);
            this.itemPrice.TabIndex = 39;
            this.itemPrice.Text = "Price: 1.00";
            // 
            // itemStock
            // 
            this.itemStock.AutoSize = true;
            this.itemStock.BackColor = System.Drawing.Color.Transparent;
            this.itemStock.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(120)))), ((int)(((byte)(105)))));
            this.itemStock.Location = new System.Drawing.Point(100, 73);
            this.itemStock.Name = "itemStock";
            this.itemStock.Size = new System.Drawing.Size(94, 15);
            this.itemStock.TabIndex = 39;
            this.itemStock.Text = "stock: 50 Items";
            // 
            // itemSuplier
            // 
            this.itemSuplier.AutoSize = true;
            this.itemSuplier.BackColor = System.Drawing.Color.Transparent;
            this.itemSuplier.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemSuplier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(120)))), ((int)(((byte)(105)))));
            this.itemSuplier.Location = new System.Drawing.Point(200, 73);
            this.itemSuplier.Name = "itemSuplier";
            this.itemSuplier.Size = new System.Drawing.Size(95, 15);
            this.itemSuplier.TabIndex = 39;
            this.itemSuplier.Text = "Supplier: Johon";
            // 
            // itemCodelab
            // 
            this.itemCodelab.AutoSize = true;
            this.itemCodelab.BackColor = System.Drawing.Color.Transparent;
            this.itemCodelab.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemCodelab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(120)))), ((int)(((byte)(105)))));
            this.itemCodelab.Location = new System.Drawing.Point(202, 43);
            this.itemCodelab.Name = "itemCodelab";
            this.itemCodelab.Size = new System.Drawing.Size(111, 15);
            this.itemCodelab.TabIndex = 39;
            this.itemCodelab.Text = "item code: 000001";
            // 
            // itemper
            // 
            this.itemper.AutoSize = true;
            this.itemper.Location = new System.Drawing.Point(300, 0);
            this.itemper.Name = "itemper";
            this.itemper.Size = new System.Drawing.Size(0, 13);
            this.itemper.TabIndex = 40;
            this.itemper.Visible = false;
            // 
            // ItemCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.Controls.Add(this.itemper);
            this.Controls.Add(this.itemSuplier);
            this.Controls.Add(this.itemStock);
            this.Controls.Add(this.itemCodelab);
            this.Controls.Add(this.itemPrice);
            this.Controls.Add(this.itemPriceLab);
            this.Controls.Add(this.itemPic);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "ItemCard";
            this.Size = new System.Drawing.Size(335, 107);
            ((System.ComponentModel.ISupportInitialize)(this.itemPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPictureBox itemPic;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label itemPriceLab;
        private System.Windows.Forms.Label itemSuplier;
        private System.Windows.Forms.Label itemStock;
        private System.Windows.Forms.Label itemCodelab;
        private System.Windows.Forms.Label itemPrice;
        private System.Windows.Forms.Label itemper;
    }
}
