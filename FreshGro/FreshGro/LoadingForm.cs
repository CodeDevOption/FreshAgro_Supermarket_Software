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
    public partial class LoadingForm : Form
    {
        public LoadingForm()
        {
            InitializeComponent();
            Delay();
           
        }

        async public void Delay() {

            LoginForm logform = new LoginForm();
            for (int i = 2; i <= 100; i++)
            {

                percentage.Text = i.ToString() + "%";
                LoadingProgressBar.Value = i;
                await Task.Delay(900 / i);

            };
            this.Hide();
            logform.Show();
        }
    }
}
