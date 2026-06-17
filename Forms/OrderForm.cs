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
    public partial class OrderForm : Form
    {
        public readonly Repos _repos = new Repos();
        public OrderForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            ShopForm shopform = new ShopForm();
            shopform.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
       
        }

        private void LoadData()
        {
            dgvOrder.DataSource = _repos.read<Order>();
        }
         
    }
}
