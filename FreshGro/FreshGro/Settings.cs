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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminForm admf = new AdminForm();
            admf.Show();
        }
    }
}
