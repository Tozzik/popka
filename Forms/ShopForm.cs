using Microsoft.EntityFrameworkCore;
using popka.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace popka.Forms
{
    public partial class ShopForm : Form
    {
        public readonly Repos _repos = new Repos();


        public ShopForm()
        {
            InitializeComponent();
        }

        private void ShopForm_Load(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = repos.readsql<Product>("SELECT * FROM products");
            dataGridView1.DataSource = _repos.read<Product>();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            OrderForm orderform = new OrderForm();
            orderform.Show();
            this.Hide();
        }

        private void btnExitShop_Click(object sender, EventArgs e)
        {
            Form1 loginform = new Form1();
            loginform.Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Данный товар нельзя удалить так как он есть в заказе");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditForm editform = new EditForm();
            editform.Show();
            this.Hide();
        }



        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _repos.readsql<Product>($"SELECT * FROM products WHERE LOWER(name) LIKE '%{textBox1.Text.ToLower()}%'");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _repos.readsql<Product>($"SELECT * FROM products WHERE LOWER(category) LIKE '%{comboBox1.Text.ToLower()}%'");
        }
    }
}
