using popka.Forms;
using popka.Models;

namespace popka
{
    public partial class Form1 : Form
    {
        public readonly Repos _repos = new Repos();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuest_Click(object sender, EventArgs e)
        {
            ShopForm shopForm = new ShopForm();
            shopForm.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVxod_Click(object sender, EventArgs e)
        {
            try
            {
                var chel = _repos.readsql<User>($"SELECT * FROM users WHERE login = '{txtLogin.Text}' AND password = '{txtPassword.Text}' ")[0];
                MessageBox.Show("Успех ёпта");
                ShopForm shopform = new ShopForm();
                shopform.Show();
                this.Hide();

            }
            catch
            {
                MessageBox.Show("Нвеврный логин или пароль");

            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Вы уверены что хотите выйти из программы ? ",
                "Подтверждение выхода",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }
    }
}
