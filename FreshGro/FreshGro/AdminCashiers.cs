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
                
                 try{
                    int phoneNo = Convert.ToInt32(pNo);
                    cmd = new SqlCommand("INSERT INTO Cashier (Image,Name,Email,Username,Password,PhoneNo,Address,DateOfHire) VALUES (@image,@name,@email,@username,@password,@phoneno,@address,@date)",con);
                    //memory Streame
                     MemoryStream mstr = new MemoryStream();
                     cashierProImg.Image.Save(mstr,cashierProImg.Image.RawFormat);
                     cmd.Parameters.AddWithValue("image",mstr.ToArray());
                     cmd.Parameters.AddWithValue("name", name);
                     cmd.Parameters.AddWithValue("email", email);
                     cmd.Parameters.AddWithValue("username", username);
                     cmd.Parameters.AddWithValue("password", password);
                     cmd.Parameters.AddWithValue("phoneno", phoneNo);
                     cmd.Parameters.AddWithValue("address", address);
                     cmd.Parameters.AddWithValue("date",cashDateOfHire.Value.Date);

                     con.Open();
                     cmd.ExecuteNonQuery();
                     MessageBox.Show("Data Inserted Successfuly", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     clearForm();
                     load_data();
                     con.Close();

                 }catch(Exception ex){
                     MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }
                }

            }catch(Exception ex){
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine();
                Console.ReadKey();
            
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

        private void load_data()
        {
            cmd = new SqlCommand("SELECT * FROM Cashier", con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            cashDataGrid.DataSource = dt;
            DataGridViewImageColumn pic1 = new DataGridViewImageColumn();
            pic1.ImageLayout = DataGridViewImageCellLayout.Stretch;
        }

        private void AdminCashiers_Load(object sender, EventArgs e)
        {
            load_data();
        }
    }
}
