﻿using System;
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
    public partial class AdminCategories : UserControl
    {
        public AdminCategories()
        {
            InitializeComponent();
            siticoneDataGridView1.AllowUserToAddRows = false;
            
                    
        }


        private void siticoneMaterialTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void AdminCategories_Load(object sender, EventArgs e)
        {
            siticoneDataGridView1.Rows.Add(

                new object[]{
                1234,
                      null ,
                "Apple",
                "New Apples",
                }

                );
            siticoneDataGridView1.Rows.Add(

            new object[]{
                1234,
                null,
                "Apple",
                "New Apples",
                }

                );
        }
    }
}
