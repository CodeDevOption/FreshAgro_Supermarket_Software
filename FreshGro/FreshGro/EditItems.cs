using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FreshGro
{
    public partial class EditItems : Form
    {
        public static Image itemimg;
        public static string title;
        public static string quant;
        public static string per;
        public static int rowIndex;
        public static string unitPrice;
        public EditItems()
        {
            InitializeComponent();
        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            RegisterSale.instance.Enabled = true;
            this.Close();
        }

        private void EditItems_Load(object sender, EventArgs e)
        {
            editItemImg.Image = itemimg;
            editItemQuantity.Text = quant;
            editItemTitle.Text = title;
            editper.Text = per;
        }

        private void siticoneButton5_Click(object sender, EventArgs e)
        {
            RegisterSale.instance.EditItemsfuc(rowIndex,editItemQuantity.Text, (double.Parse(unitPrice)  * double.Parse(editItemQuantity.Text)).ToString());
            RegisterSale.instance.Enabled = true;
            this.Close();
            
        }
    }
}
