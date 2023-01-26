using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FreshGro
{
    public partial class AddItemsForm : Form
    {

        public static AddItemsForm instance;
        public string Adname;
        public Image AdPic;
        public string itmper;
        public string price;

       
        public AddItemsForm()
        {
            InitializeComponent();
            instance = this;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void AddItemsForm_Load(object sender, EventArgs e)
        {
            adItemTitle.Text = Adname;
            adItemImg.Image = AdPic;
        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            RegisterSale.instance.Enabled = true;
            this.Close();
        }

        private void siticoneButton5_Click(object sender, EventArgs e)
        {
            object[] o = { 0001, AdPic, Adname, addItemQuantity.Text, price, itmper, Convert.ToDouble(addItemQuantity.Text) * Convert.ToDouble(price) };
            RegisterSale.instance.DataValues(o);
            RegisterSale.instance.Enabled = true;
            this.Close();
        }
    }
}
