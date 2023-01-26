using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace FreshGro
{

    public partial class AdminCategories : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-V9SH1LB;Initial Catalog=FreshGro;Integrated Security=True");
        SqlCommand cmd;

        public AdminCategories()
        {
            InitializeComponent();
            categoryDataGridView.AllowUserToAddRows = false;
            
                    
        }


        private void siticoneMaterialTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Select image(*.jpg; *.png; *.jpeg; *.gif) | *.jpg; *.png; *.jpeg; *.gif";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                admCategoryImg.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            try {
                string name = admCategoryName.Text;
                string desc = admCategoryDesc.Text;

                if (name == "" || desc == "")
                {

                    MessageBox.Show("Missing One or More Values Please Enter Again", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else {
                    MemoryStream ms = new MemoryStream();
                    admCategoryImg.Image.Save(ms,admCategoryImg.Image.RawFormat);
                    cmd = new SqlCommand("INSERT INTO Category (Image,Name,Description) VALUES (@image,@name,@desc)", con);
                    cmd.Parameters.AddWithValue("image",ms.ToArray());
                    cmd.Parameters.AddWithValue("name", name);
                    cmd.Parameters.AddWithValue("desc", desc);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Inserted Successfuly", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    load_data();
                    AdminItems.instance.LoadData();
                    clearForm();
                    con.Close();
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);            
            }
        }

        private void AdminCategories_Load(object sender, EventArgs e)
        {
            load_data();
        }

        //Laod Data to DataGridView
        private void load_data(string searTerm = "*")
        {
            if (searTerm == "*" || searTerm == "")
            {
                try
                {

                    cmd = new SqlCommand("SELECT * FROM Category", con);
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = cmd;
                    DataTable dt = new DataTable();
                    dt.Clear();
                    da.Fill(dt);
                    categoryDataGridView.DataSource = dt;
                    ((DataGridViewImageColumn)categoryDataGridView.Columns[1]).ImageLayout = DataGridViewImageCellLayout.Stretch;

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

                    try {
                        int sercht = Convert.ToInt32(searTerm);
                        cmd = new SqlCommand("SELECT * FROM Category WHERE ID=@searchterm", con);
                        cmd.Parameters.AddWithValue("searchterm", sercht);
                        SqlDataAdapter da = new SqlDataAdapter();
                        da.SelectCommand = cmd;
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);
                        categoryDataGridView.DataSource = dt;
                        ((DataGridViewImageColumn)categoryDataGridView.Columns[1]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                    }
                    catch (Exception) {

                        cmd = new SqlCommand("SELECT * FROM Category WHERE Name=@searchterm", con);
                        cmd.Parameters.AddWithValue("searchterm", searTerm);
                        SqlDataAdapter da = new SqlDataAdapter();
                        da.SelectCommand = cmd;
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);
                        categoryDataGridView.DataSource = dt;
                        ((DataGridViewImageColumn)categoryDataGridView.Columns[1]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                    
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);            

                }
            }

        }

        private void categoryDataGridView_Click(object sender, EventArgs e)
        {
            try
            {

                categoryID.Text = categoryDataGridView.CurrentRow.Cells[0].Value.ToString();
                MemoryStream ms = new MemoryStream((byte[])categoryDataGridView.CurrentRow.Cells[1].Value);
                admCategoryImg.Image = Image.FromStream(ms);
                admCategoryName.Text = categoryDataGridView.CurrentRow.Cells[2].Value.ToString();
                admCategoryDesc.Text = categoryDataGridView.CurrentRow.Cells[3].Value.ToString();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);            
            
            }
        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {

            try
            {
                string name = admCategoryName.Text;
                string desc = admCategoryDesc.Text;
                string id = categoryID.Text;

                if (name == "" || desc == "" || id == "")
                {

                    MessageBox.Show("Missing One or More Values Please Enter Again", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    MemoryStream ms = new MemoryStream();
                    admCategoryImg.Image.Save(ms, admCategoryImg.Image.RawFormat);
                    cmd = new SqlCommand("UPDATE Category SET Image=@image, Name=@name, Description=@desc WHERE ID=@id", con);
                    cmd.Parameters.AddWithValue("image", ms.ToArray());
                    cmd.Parameters.AddWithValue("name", name);
                    cmd.Parameters.AddWithValue("desc", desc);
                    cmd.Parameters.AddWithValue("id", id);


                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Updated Successfuly", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    load_data();
                    AdminItems.instance.LoadData();
                    clearForm();
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void clearForm() {
            admCategoryName.Text = "";
            admCategoryDesc.Text = "";
            categoryID.Text = "";
            admCategoryImg.Image = null;
        }

        private void siticoneButton5_Click(object sender, EventArgs e)
        {
            load_data(categorySearch.Text);
        }

        private void cashClearBtn_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        private void siticoneButton4_Click(object sender, EventArgs e)
        {
            try
            {
                string name = admCategoryName.Text;
                string desc = admCategoryDesc.Text;
                string id = categoryID.Text;

                if (name == "" || desc == "" || id == "")
                {

                    MessageBox.Show("Missing One or More Values Please Enter Again", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                } 
            else {

                    DialogResult result = MessageBox.Show("Do you want to Delete this record?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        cmd = new SqlCommand("DELETE FROM Category WHERE ID=@id", con);
                        cmd.Parameters.AddWithValue("id", id);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        load_data();
                        AdminItems.instance.LoadData();
                        con.Close();
                    }
                
                }

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);            
            }
        }

    }
}
