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
    public partial class AdminItems : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-V9SH1LB;Initial Catalog=FreshGro;Integrated Security=True");
        SqlCommand cmd;

        public static AdminItems instance;

        public AdminItems()
        {
            InitializeComponent();
            instance = this;
        }

        public void LoadData() {
            try
            {
                con.Open();
                cmd = new SqlCommand("SELECT ID,Name FROM Category", con);
                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                da.SelectCommand = cmd;
                da.Fill(ds);
                cmd.ExecuteNonQuery();
                con.Close();

                itemCategory.DataSource = ds.Tables[0];
                itemCategory.DisplayMember = "Name";
                itemCategory.ValueMember = "ID";
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                con.Open();
                cmd = new SqlCommand("SELECT NIC,Username FROM Supplier", con);
                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                da.SelectCommand = cmd;
                da.Fill(ds);
                cmd.ExecuteNonQuery();
                con.Close();

                itemSupplier.DataSource = ds.Tables[0];
                itemSupplier.DisplayMember = "Username";
                itemSupplier.ValueMember = "NIC";


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }


        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Select image(*.jpg; *.png; *.jpeg; *.gif) | *.jpg; *.png; *.jpeg; *.gif";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                itemImg.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void AdminItems_Load(object sender, EventArgs e)
        {
            LoadData();
            itemPer.SelectedIndex = 0;
            load_data();
        }

        private void itemExDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void siticoneButton5_Click(object sender, EventArgs e)
        {
            try
            {

                string itemname = itemName.Text;
                string categoryId = itemCategory.SelectedValue.ToString();
                string quentity = itemQuantity.Text;
                string price = itemPrice.Text;
                string per = itemPer.SelectedItem.ToString();
                string suplier = itemSupplier.SelectedValue.ToString();
                string desc = itemDescription.Text;

                if (itemname == "" || categoryId == "" || quentity == "" || price == "" || per == "" || suplier == "" || desc == "")
                {

                    MessageBox.Show("Missing One or More Values Please Check Your Data", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    con.Open();
                    cmd = new SqlCommand("INSERT INTO Items (Image,Name,Category,Quantity,Price,Per,Supplier,ExpirationDate,Description) VALUES (@image,@itname,@categoryId,@quantity,@price,@per,@supplierNic,@exDate,@desc)", con);
                    MemoryStream ms = new MemoryStream();
                    itemImg.Image.Save(ms, itemImg.Image.RawFormat);
                    cmd.Parameters.AddWithValue("image", ms.ToArray());
                    cmd.Parameters.AddWithValue("itname", itemname);
                    cmd.Parameters.AddWithValue("categoryId", Convert.ToInt32(categoryId));
                    cmd.Parameters.AddWithValue("quantity", Convert.ToDouble(quentity));
                    cmd.Parameters.AddWithValue("price", Convert.ToDouble(price));
                    cmd.Parameters.AddWithValue("per", per);
                    cmd.Parameters.AddWithValue("supplierNic", suplier);
                    cmd.Parameters.AddWithValue("exDate", itemExDate.Value.Date);
                    cmd.Parameters.AddWithValue("desc", desc);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Inserted Successfuly", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clerForm();
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


        private void clerForm() {

            itemName.Text = "";
            itemQuantity.Text = "";
            itemPrice.Text = "";
            itemDescription.Text = "";
            itemExDate.Value = DateTime.Today;
            itemImg.Image = null;
        }

        private void itemDataGridView_Click(object sender, EventArgs e)
        {

            try
            {

                ItemCode.Text = itemDataGridView.CurrentRow.Cells[0].Value.ToString();
                MemoryStream ms = new MemoryStream((byte[])itemDataGridView.CurrentRow.Cells[1].Value);
                itemImg.Image = Image.FromStream(ms);
                itemName.Text = itemDataGridView.CurrentRow.Cells[2].Value.ToString();
                itemCategory.SelectedValue = itemDataGridView.CurrentRow.Cells[3].Value.ToString();
                itemQuantity.Text = itemDataGridView.CurrentRow.Cells[4].Value.ToString();
                itemPrice.Text = itemDataGridView.CurrentRow.Cells[5].Value.ToString();
                itemPer.Text = itemDataGridView.CurrentRow.Cells[6].Value.ToString();
                itemSupplier.SelectedValue = itemDataGridView.CurrentRow.Cells[7].Value.ToString();
                itemExDate.Value = Convert.ToDateTime(itemDataGridView.CurrentRow.Cells[8].Value.ToString());
                itemDescription.Text = itemDataGridView.CurrentRow.Cells[9].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void load_data(string searTerm = "*")
        {
            if (searTerm == "*" || searTerm == "")
            {
                try
                {

                    cmd = new SqlCommand("SELECT * FROM Items", con);
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = cmd;
                    DataTable dt = new DataTable();
                    dt.Clear();
                    da.Fill(dt);
                    itemDataGridView.DataSource = dt;
                    ((DataGridViewImageColumn)itemDataGridView.Columns[1]).ImageLayout = DataGridViewImageCellLayout.Stretch;

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
                        cmd = new SqlCommand("SELECT * FROM Items WHERE ItemCode=@searchterm or Category=@searchterm", con);
                        cmd.Parameters.AddWithValue("searchterm", Convert.ToInt32(searTerm));
                        SqlDataAdapter da = new SqlDataAdapter();
                        da.SelectCommand = cmd;
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);
                        itemDataGridView.DataSource = dt;
                        ((DataGridViewImageColumn)itemDataGridView.Columns[1]).ImageLayout = DataGridViewImageCellLayout.Stretch;


                    }
                    catch (Exception ex) {

                        cmd = new SqlCommand("SELECT * FROM Items WHERE  Name LIKE '%" + searTerm + "%' or Supplier LIKE '%" + searTerm + "%'", con);
                        SqlDataAdapter da = new SqlDataAdapter();
                        da.SelectCommand = cmd;
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);
                        itemDataGridView.DataSource = dt;
                        ((DataGridViewImageColumn)itemDataGridView.Columns[1]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            load_data(itemSearch.Text);
        }

        private void cashClearBtn_Click(object sender, EventArgs e)
        {
            clerForm();
        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            try
            {
                string itemcode = ItemCode.Text;
                string itemname = itemName.Text;
                string categoryId = itemCategory.SelectedValue.ToString();
                string quentity = itemQuantity.Text;
                string price = itemPrice.Text;
                string per = itemPer.SelectedItem.ToString();
                string suplier = itemSupplier.SelectedValue.ToString();
                string desc = itemDescription.Text;

                if (itemname == "" || categoryId == "" || quentity == "" || price == "" || per == "" || suplier == "" || desc == "" || itemcode == "")
                {

                    MessageBox.Show("Missing One or More Values Please Check Your Data", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    con.Open();
                    cmd = new SqlCommand("UPDATE Items SET Image=@image, Name=@itname, Category=@categoryId, Quantity=@quantity, Price=@price, Per=@per, Supplier=@supplierNic, ExpirationDate=@exDate, Description=@desc WHERE ItemCode=@itemcode", con);
                    cmd.Parameters.AddWithValue("itemcode",Convert.ToInt32(itemcode));
                    MemoryStream ms = new MemoryStream();
                    itemImg.Image.Save(ms, itemImg.Image.RawFormat);
                    cmd.Parameters.AddWithValue("image", ms.ToArray());
                    cmd.Parameters.AddWithValue("itname", itemname);
                    cmd.Parameters.AddWithValue("categoryId", Convert.ToInt32(categoryId));
                    cmd.Parameters.AddWithValue("quantity", Convert.ToDouble(quentity));
                    cmd.Parameters.AddWithValue("price", Convert.ToDouble(price));
                    cmd.Parameters.AddWithValue("per", per);
                    cmd.Parameters.AddWithValue("supplierNic", suplier);
                    cmd.Parameters.AddWithValue("exDate", itemExDate.Value.Date);
                    cmd.Parameters.AddWithValue("desc", desc);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Updated Successfuly", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clerForm();
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
                string itemcode = ItemCode.Text;
                string itemname = itemName.Text;
                string categoryId = itemCategory.SelectedValue.ToString();
                string quentity = itemQuantity.Text;
                string price = itemPrice.Text;
                string per = itemPer.SelectedItem.ToString();
                string suplier = itemSupplier.SelectedValue.ToString();
                string desc = itemDescription.Text;

                if (itemname == "" || categoryId == "" || quentity == "" || price == "" || per == "" || suplier == "" || desc == "" || itemcode == "")
                {

                    MessageBox.Show("Missing One or More Values Please Check Your Data", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    DialogResult result = MessageBox.Show("Do you want to Delete this record?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        con.Open();
                        cmd = new SqlCommand("DELETE FROM Items WHERE ItemCode=@itemcode", con);
                        cmd.Parameters.AddWithValue("itemcode", Convert.ToInt32(itemcode));
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data has been deleted!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clerForm();
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

    }
}
