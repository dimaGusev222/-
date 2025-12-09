using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace FoodDeliveryApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Введите логин и пароль.");
                return;
            }

            try
            {
                using (OleDbConnection conn = new OleDbConnection(Program.ConnStr))
                {
                    conn.Open();

                    string query = "SELECT COUNT(*) FROM Users WHERE [Login] = ? AND [Password] = ?";
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("?", login);
                        cmd.Parameters.AddWithValue("?", password);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        if (count > 0)
                        {
                            Form2 f2 = new Form2(login);
                            f2.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Неверный логин или пароль.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка БД: " + ex.Message);
            }
        }
    }
}
