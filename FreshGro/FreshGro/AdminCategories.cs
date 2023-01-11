using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FreshGro
{
    public partial class AdminCategories : UserControl
    {
        public AdminCategories()
        {
            InitializeComponent();
            siticoneDataGridView1.AllowUserToAddRows = false;
            
                    
        }


        private void siticoneMaterialTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }


    }
}
