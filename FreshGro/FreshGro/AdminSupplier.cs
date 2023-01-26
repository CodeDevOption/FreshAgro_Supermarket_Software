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
using System.IO;

namespace FreshGro
{
    public partial class AdminSupplier : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-V9SH1LB;Initial Catalog=FreshGro;Integrated Security=True");
        SqlCommand cmd;

        public AdminSupplier()
        {
            InitializeComponent();
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Select image(*.jpg; *.png; *.jpeg; *.gif) | *.jpg; *.png; *.jpeg; *.gif";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                supProImg.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void siticoneButton5_Click(object sender, EventArgs e)
        {
            try
            {
                string nic = supNic.Text;
                string name = supName.Text;
                string email = supEmail.Text;
                string username = supUsername.Text;
                string pNo = supPhoneNo.Text;
                string address = supAddres.Text;


                if (nic == "" || name == "" || email == "" || username == "" ||  address == "" || pNo == "")
                {

                    MessageBox.Show("Missing One or More Values Please Enter Again", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {

                    try
                    {
                        int phoneNo = Convert.ToInt32(pNo);
                        cmd = new SqlCommand("INSERT INTO Supplier (NIC,Image,Name,Email,Username,PhoneNo,Address) VALUES (@nic,@image,@name,@email,@username,@phoneno,@address)", con);

                        cmd.Parameters.AddWithValue("nic", nic);
                        //memory Streame
                        MemoryStream mstr = new MemoryStream();
                        supProImg.Image.Save(mstr, supProImg.Image.RawFormat);
                        cmd.Parameters.AddWithValue("image", mstr.ToArray());
                        cmd.Parameters.AddWithValue("name", name);
                        cmd.Parameters.AddWithValue("email", email);
                        cmd.Parameters.AddWithValue("username", username);
                        cmd.Parameters.AddWithValue("phoneno", phoneNo);
                        cmd.Parameters.AddWithValue("address", address);

                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Inserted Successfuly", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearForm();
                        load_data();
                        AdminItems.instance.LoadData();
                        AdminHome.instance.RefreshAdminHomeData();

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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine();
                Console.ReadKey();

            }
        }


        private void clearForm()
        {
            supNic.Text = "";
            supName.Text = "";
            supEmail.Text = "";
            supUsername.Text = "";
            supPhoneNo.Text = "";
            supAddres.Text = "";
            supProImg.Image = null;
        }


        private void load_data(string searTerm = "*")
        {
            if (searTerm == "*" || searTerm == "")
            {
                try
                {

                    cmd = new SqlCommand("SELECT * FROM Supplier", con);
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = cmd;
                    DataTable dt = new DataTable();
                    dt.Clear();
                    da.Fill(dt);
                    supDataGrid.DataSource = dt;
                    ((DataGridViewImageColumn)supDataGrid.Columns[1]).ImageLayout = DataGridViewImageCellLayout.Stretch;

                }
                catch (Exception ex)
                {
                }
            }
            else
            {
                try
                {

                    cmd = new SqlCommand("SELECT * FROM Supplier WHERE NIC=@searchterm or Username=@searchterm or Email=@searchterm", con);
                    cmd.Parameters.AddWithValue("searchterm", searTerm);
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = cmd;
                    DataTable dt = new DataTable();
                    dt.Clear();
                    da.Fill(dt);
                    supDataGrid.DataSource = dt;
                    ((DataGridViewImageColumn)supDataGrid.Columns[1]).ImageLayout = DataGridViewImageCellLayout.Stretch;

                }
                catch (Exception ex)
                {
                }
            }

        }

        private void AdminSupplier_Load(object sender, EventArgs e)
        {
            load_data();
        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            try
            {
                string nic = supNic.Text;
                string name = supName.Text;
                string email = supEmail.Text;
                string username = supUsername.Text;
                string pNo = supPhoneNo.Text;
                string address = supAddres.Text;


                if (nic == "" || name == "" || email == "" || username == "" ||  address == "" || pNo == "")
                {

                    MessageBox.Show("Missing One or More Values Please Enter Again", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {

                    try
                    {
                        int phoneNo = Convert.ToInt32(pNo);
                        cmd = new SqlCommand("UPDATE Supplier SET NIC=@nic, Image=@image, Name=@name, Email=@email, Username=@username, PhoneNo=@phoneno, Address=@address WHERE NIC=@nic", con);

                        cmd.Parameters.AddWithValue("nic", nic);
                        //memory Streame
                        MemoryStream mstr = new MemoryStream();
                        supProImg.Image.Save(mstr, supProImg.Image.RawFormat);
                        cmd.Parameters.AddWithValue("image", mstr.ToArray());
                        cmd.Parameters.AddWithValue("name", name);
                        cmd.Parameters.AddWithValue("email", email);
                        cmd.Parameters.AddWithValue("username", username);
                        cmd.Parameters.AddWithValue("phoneno", phoneNo);
                        cmd.Parameters.AddWithValue("address", address);

                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Updated Successfuly", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        load_data();
                        AdminItems.instance.LoadData();
                        AdminHome.instance.RefreshAdminHomeData();

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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void siticoneButton4_Click(object sender, EventArgs e)
        {
            try
            {
                string nic = supNic.Text;
                string name = supName.Text;
                string email = supEmail.Text;
                string username = supUsername.Text;
                string pNo = supPhoneNo.Text;
                string address = supAddres.Text;


                if (nic == "" || name == "" || email == "" || username == "" || address == "" || pNo == "")
                {

                    MessageBox.Show("Missing One or More Values Please Enter Again", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    DialogResult result = MessageBox.Show("Do you want to Delete this record?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        cmd = new SqlCommand("DELETE FROM Supplier WHERE NIC=@nic", con);
                        cmd.Parameters.AddWithValue("nic", nic);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        load_data();
                        AdminItems.instance.LoadData();
                        AdminHome.instance.RefreshAdminHomeData();

                    }
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

        private void cashClearBtn_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        private void supDataGrid_Click(object sender, EventArgs e)
        {
            try
            {

                supNic.Text = supDataGrid.CurrentRow.Cells[0].Value.ToString();
                MemoryStream ms = new MemoryStream((byte[])supDataGrid.CurrentRow.Cells[1].Value);
                supProImg.Image = Image.FromStream(ms);
                supName.Text = supDataGrid.CurrentRow.Cells[2].Value.ToString();
                supEmail.Text = supDataGrid.CurrentRow.Cells[3].Value.ToString();
                supUsername.Text = supDataGrid.CurrentRow.Cells[4].Value.ToString();
                supPhoneNo.Text = supDataGrid.CurrentRow.Cells[5].Value.ToString();
                supAddres.Text = supDataGrid.CurrentRow.Cells[6].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            load_data(supSearch.Text);
        }
    }
}
