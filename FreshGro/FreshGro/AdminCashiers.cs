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
    public partial class AdminCashiers : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-V9SH1LB;Initial Catalog=FreshGro;Integrated Security=True");
        SqlCommand cmd;

        public AdminCashiers()
        {
            InitializeComponent();
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Select image(*.jpg; *.png; *.jpeg; *.gif) | *.jpg; *.png; *.jpeg; *.gif";
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                cashierProImg.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void siticoneButton5_Click(object sender, EventArgs e)
        {

            try {
                string nic = cashNic.Text;
                string name = cashName.Text;
                string email = cashEmail.Text;
                string username = cashUsername.Text;
                string password = cashPassword.Text;
                string pNo = cashPhoneNo.Text;
                string address = cashAddres.Text;


                if (nic == "" || name == "" || email == "" || username == "" || password == "" || address == "" || pNo == "")
                {

                    MessageBox.Show("Missing One or More Values Please Enter Again", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else {

                    try
                    {
                        int phoneNo = Convert.ToInt32(pNo);
                        cmd = new SqlCommand("INSERT INTO Cashier (NIC,Image,Name,Email,Username,Password,PhoneNo,Address,DateOfHire) VALUES (@nic,@image,@name,@email,@username,@password,@phoneno,@address,@date)", con);

                        cmd.Parameters.AddWithValue("nic", nic);
                        //memory Streame
                        MemoryStream mstr = new MemoryStream();
                        cashierProImg.Image.Save(mstr, cashierProImg.Image.RawFormat);
                        cmd.Parameters.AddWithValue("image", mstr.ToArray());
                        cmd.Parameters.AddWithValue("name", name);
                        cmd.Parameters.AddWithValue("email", email);
                        cmd.Parameters.AddWithValue("username", username);
                        cmd.Parameters.AddWithValue("password", password);
                        cmd.Parameters.AddWithValue("phoneno", phoneNo);
                        cmd.Parameters.AddWithValue("address", address);
                        cmd.Parameters.AddWithValue("date", cashDateOfHire.Value.Date);

                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Inserted Successfuly", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearForm();
                        load_data();
                        con.Close();

                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }

            }catch(Exception ex){
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void clearForm() {
            cashNic.Text = "";
            cashName.Text = "";
            cashEmail.Text = "";
            cashUsername.Text = "";
            cashPassword.Text = "";
            cashPhoneNo.Text = "";
            cashAddres.Text = "";
            cashDateOfHire.Value = DateTime.Now;
            cashierProImg.Image = null;
        }

        private void cashClearBtn_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        private void load_data(string searTerm = "*")
        {
            if (searTerm == "*" || searTerm == "")
            {
                try
                {

                    cmd = new SqlCommand("SELECT * FROM Cashier", con);
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = cmd;
                    DataTable dt = new DataTable();
                    dt.Clear();
                    da.Fill(dt);
                    cashDataGrid.DataSource = dt;
                    ((DataGridViewImageColumn)cashDataGrid.Columns[1]).ImageLayout = DataGridViewImageCellLayout.Stretch;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);            
                }
            }
            else {
                try
                {

                    cmd = new SqlCommand("SELECT * FROM Cashier WHERE NIC=@searchterm or Username=@searchterm or Email=@searchterm", con);
                    cmd.Parameters.AddWithValue("searchterm",searTerm);
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = cmd;
                    DataTable dt = new DataTable();
                    dt.Clear();
                    da.Fill(dt);
                    cashDataGrid.DataSource = dt;
                    ((DataGridViewImageColumn)cashDataGrid.Columns[1]).ImageLayout = DataGridViewImageCellLayout.Stretch;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);            
                }
            }

        }

        private void AdminCashiers_Load(object sender, EventArgs e)
        {
            load_data();
        }

        private void cashDataGrid_Click(object sender, EventArgs e)
        {
            try
            {
                niclabel.Text = cashDataGrid.CurrentRow.Cells[0].Value.ToString();
                cashNic.Text = cashDataGrid.CurrentRow.Cells[0].Value.ToString();
                MemoryStream ms = new MemoryStream((byte[])cashDataGrid.CurrentRow.Cells[1].Value);
                cashierProImg.Image = Image.FromStream(ms);
                cashName.Text = cashDataGrid.CurrentRow.Cells[2].Value.ToString();
                cashEmail.Text = cashDataGrid.CurrentRow.Cells[3].Value.ToString();
                cashUsername.Text = cashDataGrid.CurrentRow.Cells[4].Value.ToString();
                cashPassword.Text = cashDataGrid.CurrentRow.Cells[5].Value.ToString();
                cashPhoneNo.Text = cashDataGrid.CurrentRow.Cells[6].Value.ToString();
                cashAddres.Text = cashDataGrid.CurrentRow.Cells[7].Value.ToString();
                cashDateOfHire.Value = Convert.ToDateTime(cashDataGrid.CurrentRow.Cells[8].Value.ToString());

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                                    
            }
        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {

            try
            {
                string nic = cashNic.Text;
                string name = cashName.Text;
                string email = cashEmail.Text;
                string username = cashUsername.Text;
                string password = cashPassword.Text;
                string pNo = cashPhoneNo.Text;
                string address = cashAddres.Text;


                if (nic == "" || name == "" || email == "" || username == "" || password == "" || address == "" || pNo == "")
                {

                    MessageBox.Show("Missing One or More Values Please Enter Again", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {

                    try
                    {
                        int phoneNo = Convert.ToInt32(pNo);
                        cmd = new SqlCommand("UPDATE Cashier SET NIC=@nic, Image=@image, Name=@name, Email=@email, Username=@username, Password=@password, PhoneNo=@phoneno, Address=@address, DateOfHire=@date  WHERE NIC=@niclab", con);

                        cmd.Parameters.AddWithValue("nic", nic);
                        cmd.Parameters.AddWithValue("niclab", niclabel.Text);

                        //memory Streame
                        MemoryStream mstr = new MemoryStream();
                        cashierProImg.Image.Save(mstr, cashierProImg.Image.RawFormat);
                        cmd.Parameters.AddWithValue("image", mstr.ToArray());
                        cmd.Parameters.AddWithValue("name", name);
                        cmd.Parameters.AddWithValue("email", email);
                        cmd.Parameters.AddWithValue("username", username);
                        cmd.Parameters.AddWithValue("password", password);
                        cmd.Parameters.AddWithValue("phoneno", phoneNo);
                        cmd.Parameters.AddWithValue("address", address);
                        cmd.Parameters.AddWithValue("date", cashDateOfHire.Value.Date);

                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Updated Successfuly", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        load_data();


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void siticoneButton4_Click(object sender, EventArgs e)
        {
            try
            {
                string nic = cashNic.Text;
                string name = cashName.Text;
                string email = cashEmail.Text;
                string username = cashUsername.Text;
                string password = cashPassword.Text;
                string pNo = cashPhoneNo.Text;
                string address = cashAddres.Text;


                if (nic == "" || name == "" || email == "" || username == "" || password == "" || address == "" || pNo == "")
                {

                    MessageBox.Show("Please Select Record Before Deleting", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {

                    DialogResult result = MessageBox.Show("Do you want to Delete this record?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        cmd = new SqlCommand("DELETE FROM Cashier WHERE NIC=@nic", con);
                        cmd.Parameters.AddWithValue("nic", nic);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        load_data();
                        clearForm();

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

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            try {
                load_data(cashSearch.Text);
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);            
            
            }
        }
    }
}
