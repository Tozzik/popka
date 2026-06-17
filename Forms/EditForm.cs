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

    public partial class EditForm : Form
    {
        public readonly Repos repo = new Repos();
        public EditForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ShopForm shopform = new ShopForm();
            shopform.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadData()
        {
            dataGridView1.DataSource = repo.read<Product>();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var chel = repo.ExecuteSql($"INSERT INTO products (article, name, unit, price, supplier, manufacturer, category, discount, quantity, description, photo) VALUES ('{textBox1.Text}', '{textBox2.Text}', '{textBox3.Text}', {textBox4.Text}, '{textBox5.Text}', '{textBox6.Text}', '{textBox7.Text}', {textBox8.Text}, '{textBox9.Text}', '{textBox10.Text}', '{textBox11.Text}')");
                dataGridView1.DataSource = repo.read<Product>();
                MessageBox.Show("Добавлено");
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }

        }



        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                var chel = repo.ExecuteSql($"UPDATE products SET name = '{textBox2.Text}', unit = '{textBox3.Text}', price = {textBox4.Text}, supplier = '{textBox5.Text}', manufacturer = '{textBox6.Text}', category = '{textBox7.Text}', discount = {textBox8.Text}, quantity = {textBox9.Text}, description = '{textBox10.Text}', photo = '{textBox11.Text}' Where article = '{textBox1.Text}'");
                dataGridView1.DataSource = repo.read<Product>();
                MessageBox.Show("Таблица обновлена");
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var chel = repo.ExecuteSql($"DELETE FROM products WHERE article = '{textBox1.Text}'");
                dataGridView1.DataSource = repo.read<Product>();
                MessageBox.Show("Данные удалены");
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }
    }
}
