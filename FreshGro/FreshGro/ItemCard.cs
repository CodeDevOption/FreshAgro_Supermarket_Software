using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FreshGro
{
    public partial class ItemCard : UserControl
    {
        public ItemCard()
        {
            InitializeComponent();
        }

    //getter && Setter


        private Image itemImage;
        private string title;
        private string price;
        private string itemCode;
        private string stock;
        private string supplier;
        private string per;

        public Image ItemImage
        {
            get { return itemImage; }
            set { itemImage = value; itemPic.Image = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; itemPriceLab.Text =  value; }
        }

        public string Price
        {
            get { return price; }
            set { price = value; itemPrice.Text = "Price: " + value; }
        }

        public string ItemCode
        {
            get { return itemCode; }
            set { itemCode = value; itemCodelab.Text = "Item Code: " + value; }
        }
        public string Stock
        {
            get { return stock; }
            set { stock = value; itemStock.Text = "stock: " + value; }
        }
        public string Supplier
        {
            get { return supplier; }
            set { supplier = value; itemSuplier.Text = "Supplier: " + (value.Length > 9 ? value.Substring(0,9) : value ); }
        }
        public string Per
        {
            get { return per; }
            set { per = value; itemper.Text = value; }
        }

    }
}
