using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FreshGro
{
    public partial class LoginForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-V9SH1LB;Initial Catalog=FreshGro;Integrated Security=True");
        SqlCommand cmd;

        public LoginForm()
        {
            InitializeComponent();

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            if (!bunifuCheckBox1.Checked) {
                password.UseSystemPasswordChar = true;
            }

            loginType.SelectedIndex = 0;
        }

        private void bunifuCheckBox1_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (!bunifuCheckBox1.Checked) { password.UseSystemPasswordChar = true; } else { password.UseSystemPasswordChar = false; }
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            if (username.Text == "" || password.Text == "")
            {

                MessageBox.Show("Please Enter Username and Password", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else {
                if (loginType.SelectedIndex == 0)
                {

                    try {
                        cmd = new SqlCommand("SELECT COUNT(*) FROM Admin WHERE Username=@username AND Password=@password", con);
                        cmd.Parameters.AddWithValue("username", username.Text);
                        cmd.Parameters.AddWithValue("password", password.Text);
                        con.Open();
                        SqlDataAdapter sda = new SqlDataAdapter();
                        sda.SelectCommand = cmd;
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        if (dt.Rows[0][0].ToString() == "1")
                        {
                            AdminForm admf = new AdminForm();
                            Program.User = username.Text;
                            admf.Show();
                            this.Hide();

                        }
                        else
                        {
                            MessageBox.Show("User not Found Please try again", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }

                        con.Close();
                    }catch(Exception ex){

                        MessageBox.Show(ex.Message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }






                }
                else {

                    try
                    {
                        cmd = new SqlCommand("SELECT COUNT(*) FROM Cashier WHERE Username=@username AND Password=@password", con);
                        cmd.Parameters.AddWithValue("username", username.Text);
                        cmd.Parameters.AddWithValue("password", password.Text);
                        con.Open();
                        SqlDataAdapter sda = new SqlDataAdapter();
                        sda.SelectCommand = cmd;
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        if (dt.Rows[0][0].ToString() == "1")
                        {
                            CashierForm cashf = new CashierForm();
                            cashf.Show();
                            this.Hide();

                        }
                        else
                        {
                            MessageBox.Show("User not Found Please try again", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }

                        con.Close();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


    }
}
