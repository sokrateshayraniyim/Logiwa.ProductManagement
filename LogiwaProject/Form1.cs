﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogiwaProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public string ProductName { get; set; }
        public int ProductId { get; set; }
        public int ProductCategoryId { get; set; }
        public int ProductInStock { get; set; }


        


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void btnAddDeleteCategories_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();  
            form3.ShowDialog();

        }

        private void btnListProducts_Click(object sender, EventArgs e)
        {
            Form4 form4form4 = new Form4(); 
            form4form4.ShowDialog();
        }

        private void btnListCategories_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.ShowDialog();
        }
    }
}
