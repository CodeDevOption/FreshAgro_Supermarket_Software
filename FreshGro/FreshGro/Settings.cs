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
    public partial class Settings : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-V9SH1LB;Initial Catalog=FreshGro;Integrated Security=True");
        SqlCommand cmd;

        public Settings()
        {
            InitializeComponent();
            AdmUpPass.UseSystemPasswordChar = true;
            AdmUpComPass.UseSystemPasswordChar = true;
        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminForm admf = new AdminForm();
            admf.Show();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            try {
                cmd = new SqlCommand("SELECT * FROM Admin WHERE Username=@username",con);
                cmd.Parameters.AddWithValue("username","Sadaruwan");
                con.Open();
                SqlDataReader rd = cmd.ExecuteReader();

                if (rd.Read()) {
                    AdmUpNic.Text = rd["NIC"].ToString();
                    AdmUpName.Text = rd["FullName"].ToString();
                    AdmUpEmail.Text = rd["Email"].ToString();
                    AdmUpUsername.Text = rd["Username"].ToString();
                    AdmUpPass.Text = rd["Password"].ToString();
                    AdmUpComPass.Text = rd["Password"].ToString();
                    AdmUpPNo.Text = rd["PhoneNo"].ToString();
                    AdmUpAddress.Text = rd["Address"].ToString();
                    if (rd["ProPic"].ToString() != "")
                    {
                        MemoryStream ms = new MemoryStream((byte[])rd["ProPic"]);
                        adminChangPic.Image = Image.FromStream(ms);
                    }

                }
                con.Close();
                rd.Close();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);            
            }
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Select image(*.jpg; *.png; *.jpeg; *.gif) | *.jpg; *.png; *.jpeg; *.gif";
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                adminChangPic.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void siticoneButton5_Click(object sender, EventArgs e)
        {
            try { 

                   string nic = AdmUpNic.Text;
                   string name = AdmUpName.Text;
                   string email = AdmUpEmail.Text;
                   string username = AdmUpUsername.Text;
                   string adpass = AdmUpPass.Text;
                   string admcompass = AdmUpComPass.Text; 
                   string phoneno = AdmUpPNo.Text;
                   string admadr = AdmUpAddress.Text;


                   if (nic == "" || name == "" || email == "" || username == "" || adpass == "" || admcompass == "" || phoneno == "" || admadr == "" || adpass != admcompass)
                   {

                       MessageBox.Show("Invalid data or password not matching Please check your Details againg", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                   }
                   else {
                       cmd = new SqlCommand("UPDATE Admin SET NIC=@nic, FullName=@name, Email=@email, Username=@username, Password=@password, PhoneNo=@phoneNo, Address=@address, ProPic=@proPic  WHERE NIC=@nic", con);
                       cmd.Parameters.AddWithValue("nic", nic);
                       cmd.Parameters.AddWithValue("name", name);
                       cmd.Parameters.AddWithValue("email", email);
                       cmd.Parameters.AddWithValue("username", username);
                       cmd.Parameters.AddWithValue("password", adpass);
                       cmd.Parameters.AddWithValue("phoneNo", phoneno);
                       cmd.Parameters.AddWithValue("address",admadr);

                       MemoryStream ms = new MemoryStream();
                       adminChangPic.Image.Save(ms,adminChangPic.Image.RawFormat);
                       cmd.Parameters.AddWithValue("proPic", ms.ToArray());

                       con.Open();
                       cmd.ExecuteNonQuery();
                       con.Close();

                       MessageBox.Show("Updated Successfully","Alert",MessageBoxButtons.OK,MessageBoxIcon.Information);
                   }


            }catch(Exception ex){

                MessageBox.Show(ex.Message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
