using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FreshGro
{
    public partial class AdminForm : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-V9SH1LB;Initial Catalog=FreshGro;Integrated Security=True");
        SqlCommand cmd;

        public AdminForm()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void adminHomeBtn_Cheanged(object sender, EventArgs e)
        {
            if (adminHomeBtn.Checked) { adminHome1.BringToFront(); headerTitle.Text = "Home"; }
        }

        private void adminCategoryBtn_Changed(object sender, EventArgs e)
        {
            if (adminCategoryBtn.Checked) { adminCategories1.BringToFront(); headerTitle.Text = "Categories"; }

        }

        private void AdminItemBtn_Changed(object sender, EventArgs e)
        {
            if (AdminItemBtn.Checked) { adminItems1.BringToFront(); headerTitle.Text = "Items"; }
        }

        private void adminCutomersBtn_Changed(object sender, EventArgs e)
        {
            if (adminCutomersBtn.Checked) { adminCustomers1.BringToFront(); headerTitle.Text = "Customers"; }
        }

        private void adminRecordsBtn_Changed(object sender, EventArgs e)
        {
            if (adminRecordsBtn.Checked) { adminRecords1.BringToFront(); headerTitle.Text = "Records"; }
        }

        private void adminCashiersBtn_Changed(object sender, EventArgs e)
        {
            if (adminCashiersBtn.Checked) { adminCashiers1.BringToFront(); headerTitle.Text = "Cashiers"; }
        }

        private void AdminForm_Shown(object sender, EventArgs e)
        {
            
        }

        private void siticoneCircleButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Settings stn = new Settings();
            stn.Show();
        }

        private void siticoneCircleButton1_Click(object sender, EventArgs e)
        {
            LoginForm logf = new LoginForm();
            this.Hide();
            logf.Show();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            profileName.Text = Program.User + " (Admin)";

            try
            {
                if (Program.User != "")
                {
                    cmd = new SqlCommand("SELECT ProPic FROM Admin WHERE Username=@username",con);
                    cmd.Parameters.AddWithValue("username","Sadaruwan");
                    con.Open();                 
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        if(dr.GetValue(0).ToString() != ""){
                        MemoryStream ms = new MemoryStream((byte[]) dr.GetValue(0));
                        AdminProImg.Image = Image.FromStream(ms);
                        }

                    }
                    else {
                        Console.WriteLine("Data Not Found");
                        
                    }
                    con.Close();
                }
                else
                {
                    Console.WriteLine("==================================================================");
                    Console.WriteLine("User Not Found");
                    Console.WriteLine("==================================================================");
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }



        }











    }
}
