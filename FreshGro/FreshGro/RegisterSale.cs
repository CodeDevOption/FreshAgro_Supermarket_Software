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
    public partial class RegisterSale : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-V9SH1LB;Initial Catalog=FreshGro;Integrated Security=True");
        SqlCommand cmd;
        public static RegisterSale instance;
        double totalPrice = 0;
        DataTable dt;
        public RegisterSale()
        {
            InitializeComponent();
            instance = this;
            dt = new DataTable();
            dt.Columns.Add("ItemCode");
            dt.Columns.Add("Image",typeof(Image));
            dt.Columns.Add("Name");
            dt.Columns.Add("Quantity");
            dt.Columns.Add("Unit Price");
            dt.Columns.Add("Per");
            dt.Columns.Add("Total");
            


            adItemDataGridView.DataSource = dt;
            ((DataGridViewImageColumn)adItemDataGridView.Columns[1]).ImageLayout = DataGridViewImageCellLayout.Stretch;
            adItemDataGridView.Columns[1].Visible = false;
            var editBtn = new DataGridViewButtonColumn();
            editBtn.Name = "dataGridEditBtn";
            editBtn.HeaderText = "Edit";
            editBtn.Text = "Edit";
            editBtn.UseColumnTextForButtonValue = true;
            adItemDataGridView.Columns.Add(editBtn);

            var deleteBtn = new DataGridViewButtonColumn();
            deleteBtn.Name = "dataGridDeleteBtn";
            deleteBtn.HeaderText = "Remove";
            deleteBtn.Text = "Remove";
            deleteBtn.UseColumnTextForButtonValue = true;
            adItemDataGridView.Columns.Add(deleteBtn);



        }

        private void GenarateDynamicUserControl(string searchterm) {

            flowLayoutPanel1.Controls.Clear();
            ItemCard itemCard;
            try
            {
            con.Open();

            if (searchterm == "")
            {
                cmd = new SqlCommand("SELECT Items.Image,Items.Name,Items.Price,Items.ItemCode,Items.Quantity,Items.Per,Supplier.Name as 'SupName'  FROM Items INNER JOIN Supplier ON Items.Supplier = Supplier.NIC", con);

            }
            else {
                cmd = new SqlCommand("SELECT Items.Image,Items.Name,Items.Price,Items.ItemCode,Items.Quantity,Items.Per,Supplier.Name as 'SupName'  FROM Items INNER JOIN Supplier ON Items.Supplier = Supplier.NIC WHERE  Items.Name LIKE '%" + searchterm + "%' OR Supplier.Name LIKE '%" + searchterm +"%'", con);
            }

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    itemCard = new ItemCard();
                    MemoryStream ms = new MemoryStream((byte[])dr["Image"]);
                    itemCard.ItemImage = Image.FromStream(ms);
                    itemCard.Title = dr["Name"].ToString();
                    itemCard.Price = dr["Price"].ToString();
                    itemCard.ItemCode = dr["ItemCode"].ToString();
                    itemCard.Stock = dr["Quantity"].ToString();
                    itemCard.Supplier = dr["SupName"].ToString();
                    itemCard.Per = dr["Per"].ToString();
                    flowLayoutPanel1.Controls.Add(itemCard);

                    itemCard.Click += new System.EventHandler(this.UserControl_Click);
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

        
        void UserControl_Click(object sender, EventArgs e)
        {
            ItemCard obj = (ItemCard)sender;
            AddItemsForm adif = new AddItemsForm();
            AddItemsForm.instance.Adname = obj.Title;
            AddItemsForm.instance.AdPic = obj.ItemImage;
            AddItemsForm.instance.itmper = obj.Per;
            AddItemsForm.instance.price = obj.Price;
            this.Enabled = false;
            adif.Show();
            
        
        }

        private void RegisterSale_Load(object sender, EventArgs e)
        {
            GenarateDynamicUserControl(ItemsSearch.Text);
            
        }

        public void DataValues(object[] obj)
        {
            try
            {

                dt.Rows.Add(obj);
                itemChanged();
            }
            catch (Exception ex) { 
            
            }

        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            dt.Clear();
            itemChanged();
        }

        private void ItemsCash_TextChanged(object sender, EventArgs e)
        {
            itemCashChange();
        }

        private void itemChanged() {


            foreach (DataRow row in dt.Rows)
            {

                string upri = row["Unit Price"].ToString();
                string qun = row["Quantity"].ToString();
                totalPrice += Convert.ToDouble(upri) * Convert.ToDouble(qun);
            }
            totalPay.Text = "Total Payable: " + Convert.ToString(totalPrice);
            adItemQuan.Text = "Item Quantity: " + Convert.ToString(dt.Rows.Count);
            itemCashChange();
        
        }

        private void itemCashChange(){

            if (ItemsCash.Text == "" || totalPay.Text.Substring(15) == "")
            {
                itemChange.Text = "Change : ";
            }
            else
            {

                try
                {
                    itemChange.Text = "Change : " + (Convert.ToDouble(ItemsCash.Text) - Convert.ToDouble(totalPay.Text.Substring(15))).ToString();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void adItemDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex == adItemDataGridView.NewRowIndex || e.RowIndex < 0){
                return;
            }
            if (e.ColumnIndex == adItemDataGridView.Columns["dataGridDeleteBtn"].Index)
            {
                adItemDataGridView.Rows.RemoveAt(e.RowIndex);
                itemChanged();
            }

            else if (e.ColumnIndex == adItemDataGridView.Columns["dataGridEditBtn"].Index)
            {
                EditItems edif = new EditItems();
                EditItems.rowIndex = e.RowIndex;
                EditItems.quant = adItemDataGridView.Rows[e.RowIndex].Cells["Quantity"].Value.ToString();
                Image newImage = (Image)adItemDataGridView.Rows[e.RowIndex].Cells["Image"].Value;
                EditItems.itemimg = newImage;
                EditItems.title = adItemDataGridView.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                EditItems.per = adItemDataGridView.Rows[e.RowIndex].Cells["Per"].Value.ToString();
                EditItems.unitPrice = adItemDataGridView.Rows[e.RowIndex].Cells["Unit Price"].Value.ToString();
                this.Enabled = false;
                edif.Show();
            }
        }

        private void bunifuTextBox2_TextChanged(object sender, EventArgs e)
        {
            GenarateDynamicUserControl(ItemsSearch.Text);            
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            if (dt.Rows.Count > 0)
            {
                try
                {
                    cmd = new SqlCommand("INSERT INTO Records (Cashier_NIC,Customer_NIC,Customer_Name,Total_Price,PlacedTime) VALUES (@cashnic,@cusnic,@cusname,@totalprice,@placetime)", con);
                    cmd.Parameters.AddWithValue("cashnic", Program.casNic);
                    cmd.Parameters.AddWithValue("cusnic", cusNic.Text);
                    cmd.Parameters.AddWithValue("cusname", cusName.Text);
                    cmd.Parameters.AddWithValue("totalprice", totalPrice);
                    cmd.Parameters.AddWithValue("placetime", DateTime.Now);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    Clear();
                    itemChanged();

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
            else {
                MessageBox.Show("Items Not found");
            }
        }

        private void siticoneButton5_Click(object sender, EventArgs e)
        {
            CashierForm.instance.cashierCutomersBtnCheck();
        }


        public void EditItemsfuc(int Rowinx, string value,string total) {
            adItemDataGridView.Rows[Rowinx].Cells["Quantity"].Value = value;
            adItemDataGridView.Rows[Rowinx].Cells["Total"].Value = total;
            itemChanged();
        }

        private void Clear() {
            cusNic.Clear();
            dt.Clear();
            cusNic.Clear();
            ItemsCash.Clear();
            adItemQuan.Text = "Item Quantity :";
            totalPay.Text = "Total Payable:";
        }
    }
}
