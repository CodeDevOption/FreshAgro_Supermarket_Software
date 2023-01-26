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
    public partial class Customers : UserControl
    {

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-V9SH1LB;Initial Catalog=FreshGro;Integrated Security=True");
        SqlCommand cmd;
        public Customers()
        {
            InitializeComponent();
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            try
            {
                string nic = cusNic.Text;
                string name = cusName.Text;
                string phoneno = cusPNum.Text;
                string email = cusEmail.Text;

                if (nic == "" || name == "" || phoneno == "" || email == "")
                {
                    MessageBox.Show("Missing One or More Values Please Enter Again", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    con.Open();
                    cmd = new SqlCommand("INSERT INTO Customer (NIC,Name,PhoneNo,Email) VALUES (@nic,@name,@phoneNo,@email)", con);
                    cmd.Parameters.AddWithValue("nic", nic);
                    cmd.Parameters.AddWithValue("name", name);
                    cmd.Parameters.AddWithValue("phoneNo", Convert.ToInt32(phoneno));
                    cmd.Parameters.AddWithValue("email", email);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Inserted Successfuly", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearForm();
                    load_data();
                    AdminHome.instance.RefreshAdminHomeData();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally {
                con.Close();
            }
        }

        private void clearForm() {

            cusNic.Text = "";
            cusName.Text = "";
            cusPNum.Text = "";
            cusEmail.Text = "";
        
        }

        private void load_data(string searTerm = "*")
        {
            if (searTerm == "*" || searTerm == "")
            {
                try
                {

                    cmd = new SqlCommand("SELECT * FROM Customer", con);
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = cmd;
                    DataTable dt = new DataTable();
                    dt.Clear();
                    da.Fill(dt);
                    cusDataGridView.DataSource = dt;

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

                        cmd = new SqlCommand("SELECT * FROM Customer WHERE  Name LIKE '%" + searTerm + "%' or NIC LIKE '%" + searTerm + "%' or Email LIKE '%"+ searTerm+"%'", con);
                        SqlDataAdapter da = new SqlDataAdapter();
                        da.SelectCommand = cmd;
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);
                        cusDataGridView.DataSource = dt;
                }


                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void Customers_Load(object sender, EventArgs e)
        {
            load_data();
        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            try
            {
                string nic = cusNic.Text;
                string name = cusName.Text;
                string phoneno = cusPNum.Text;
                string email = cusEmail.Text;

                if (nic == "" || name == "" || phoneno == "" || email == "")
                {
                    MessageBox.Show("Missing One or More Values Please Enter Again", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    con.Open();
                    cmd = new SqlCommand("UPDATE Customer Name=@name, PhoneNo=@phoneNo, Email=@email WHERE NIC=@nic", con);
                    cmd.Parameters.AddWithValue("nic", nic);
                    cmd.Parameters.AddWithValue("name", name);
                    cmd.Parameters.AddWithValue("phoneNo", Convert.ToInt32(phoneno));
                    cmd.Parameters.AddWithValue("email", email);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Updated Successfuly", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearForm();
                    load_data();
                    AdminHome.instance.RefreshAdminHomeData();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void siticoneButton4_Click(object sender, EventArgs e)
        {
            try
            {
                string nic = cusNic.Text;
                string name = cusName.Text;
                string phoneno = cusPNum.Text;
                string email = cusEmail.Text;

                if (nic == "" || name == "" || phoneno == "" || email == "")
                {
                    MessageBox.Show("Missing One or More Values Please Enter Again", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DialogResult result = MessageBox.Show("Do you want to Delete this record?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        con.Open();
                        cmd = new SqlCommand("DELETE Customer WHERE NIC=@nic", con);
                        cmd.Parameters.AddWithValue("nic", nic);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Deleted Successfuly", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearForm();
                        load_data();
                        AdminHome.instance.RefreshAdminHomeData();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void cusDataGridView_Click(object sender, EventArgs e)
        {
            try
            {

                cusNic.Text = cusDataGridView.CurrentRow.Cells[0].Value.ToString();
                cusName.Text = cusDataGridView.CurrentRow.Cells[1].Value.ToString();
                cusPNum.Text = cusDataGridView.CurrentRow.Cells[2].Value.ToString();
                cusEmail.Text = cusDataGridView.CurrentRow.Cells[3].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cashClearBtn_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        private void siticoneButton5_Click(object sender, EventArgs e)
        {
            load_data(cusSearch.Text);
        }

    }
}
