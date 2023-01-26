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
    public partial class AdminRecords : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-V9SH1LB;Initial Catalog=FreshGro;Integrated Security=True");
        SqlCommand cmd;
        public AdminRecords()
        {
            InitializeComponent();
        }

        private void AdminRecords_Load(object sender, EventArgs e)
        {
            DataLoad(filerForm.Value.Date, filterTo.Value.Date, "All", searchBox.Text);
        }

        private void DataLoad(DateTime from, DateTime To, string searchType, string searchTerm) {

            if (searchType == "All" && searchBox.Text == "")
            {
                try
                {

                    cmd = new SqlCommand("SELECT * FROM Records", con);
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = cmd;
                    DataTable dt = new DataTable();
                    dt.Clear();
                    da.Fill(dt);
                    RecordDataGridView.DataSource = dt;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (searchType == "All" && searchBox.Text != "")
            {
                try
                {

                    cmd = new SqlCommand("SELECT * FROM Records WHERE Cashier_NIC=@searchterm OR Customer_NIC=@searchterm", con);
                    cmd.Parameters.AddWithValue("searchterm",searchBox.Text);
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = cmd;
                    DataTable dt = new DataTable();
                    dt.Clear();
                    da.Fill(dt);
                    RecordDataGridView.DataSource = dt;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (searchType != "All" && searchBox.Text != "")
            {
                try
                {

                    cmd = new SqlCommand("SELECT * FROM Records WHERE Cashier_NIC=@searchterm OR Customer_NIC=@searchterm AND PlacedTime >= @fromdate AND PlacedTime <= @toDate", con);
                    cmd.Parameters.AddWithValue("searchterm", searchTerm);
                    cmd.Parameters.AddWithValue("fromdate", from);
                    cmd.Parameters.AddWithValue("toDate", To);
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = cmd;
                    DataTable dt = new DataTable();
                    dt.Clear();
                    da.Fill(dt);
                    RecordDataGridView.DataSource = dt;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {

                        cmd = new SqlCommand("SELECT * FROM Records WHERE Cashier_NIC=@searchterm or PlacedTime >= @fromdate AND PlacedTime <= @toDate", con);
                        cmd.Parameters.AddWithValue("searchterm", searchTerm);
                        cmd.Parameters.AddWithValue("fromdate",from);
                        cmd.Parameters.AddWithValue("toDate",To);
                        SqlDataAdapter da = new SqlDataAdapter();
                        da.SelectCommand = cmd;
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);
                        RecordDataGridView.DataSource = dt;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            if (SerchBydate.Checked)
            {
                DataLoad(filerForm.Value.Date, filterTo.Value.Date, "date", searchBox.Text);

            }
            else
            {
                DataLoad(filerForm.Value.Date, filterTo.Value.Date, "All", searchBox.Text);
            }
        }


    }
}
