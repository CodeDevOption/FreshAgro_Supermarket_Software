using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FreshGro
{
    public partial class AdminHome : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-V9SH1LB;Initial Catalog=FreshGro;Integrated Security=True");
        SqlCommand cmd;

        public static AdminHome instance;

        public AdminHome()
        {
            InitializeComponent();
            instance = this;
        }

        private void AdminHome_Load(object sender, EventArgs e)
        {
            RefreshAdminHomeData();
        }

        public void RefreshAdminHomeData() {

            try
            {
                con.Open();
                cmd = new SqlCommand("SELECT COUNT(*) FROM Items WHERE Quantity > 0 ", con);
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable dt = new DataTable();
                sda.Fill(dt);
                totalItems.Text = dt.Rows[0][0].ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally {
                con.Close();
            }

            try
            {
                con.Open();
                cmd = new SqlCommand("SELECT COUNT(*) FROM Customer", con);
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable dt = new DataTable();
                sda.Fill(dt);
                totalCus.Text = dt.Rows[0][0].ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }finally {
                con.Close();
            }

            try
            {
                con.Open();
                cmd = new SqlCommand("SELECT COUNT(*) FROM Supplier", con);
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable dt = new DataTable();
                sda.Fill(dt);
                totSup.Text = dt.Rows[0][0].ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }

            try
            {
                con.Open();
                cmd = new SqlCommand("SELECT COUNT(*) FROM Records WHERE PlacedTime = @date; ", con);
                cmd.Parameters.AddWithValue("date",DateTime.Today);
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable dt = new DataTable();
                sda.Fill(dt);
                tdSales.Text = dt.Rows[0][0].ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }

                        try
            {
                con.Open();
                cmd = new SqlCommand("SELECT COUNT(*) FROM Items WHERE Quantity <= 0 ", con);
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable dt = new DataTable();
                sda.Fill(dt);
                soldoutitem.Text = dt.Rows[0][0].ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally {
                con.Close();
            }
        }
    }
}
