using System;
using System.Data.OleDb;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace FoodDeliveryApp
{
    public partial class Form2 : Form
    {
        private readonly string _username;

        public Form2(string username)
        {
            _username = username;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lblUser.Text = "Пользователь: " + _username;

            // Простейшее меню (можно потом заменить на своё)
            listMenu.Items.Add("Пицца Маргарита - 10.0");
            listMenu.Items.Add("Пицца Пепперони - 12.5");
            listMenu.Items.Add("Суши сет - 15.0");
            listMenu.Items.Add("Бургер классический - 8.0");
            listMenu.Items.Add("Картофель фри - 3.0");
            listMenu.Items.Add("Кола 0.5л - 2.0");

            UpdateTotal();
        }

        // ===================== КОРЗИНА =====================

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (listMenu.SelectedItem != null)
            {
                listCart.Items.Add(listMenu.SelectedItem);
                UpdateTotal();
            }
            else
            {
                MessageBox.Show("Выберите блюдо в меню.", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRemoveFromCart_Click(object sender, EventArgs e)
        {
            if (listCart.SelectedItem != null)
            {
                listCart.Items.Remove(listCart.SelectedItem);
                UpdateTotal();
            }
            else
            {
                MessageBox.Show("Выберите позицию в корзине для удаления.", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void UpdateTotal()
        {
            double total = 0.0;

            foreach (var item in listCart.Items)
            {
                string s = item.ToString();
                int dashIndex = s.LastIndexOf('-');
                if (dashIndex >= 0 && dashIndex + 1 < s.Length)
                {
                    string priceStr = s.Substring(dashIndex + 1).Trim();
                    if (double.TryParse(priceStr, NumberStyles.Any,
                        CultureInfo.InvariantCulture, out double price))
                    {
                        total += price;
                    }
                }
            }

            lblTotal.Text = "Итого: " + total.ToString("0.00") + " у.е.";
        }

        // ===================== ОФОРМЛЕНИЕ ЗАКАЗА =====================

        private void btnSubmitOrder_Click(object sender, EventArgs e)
        {
            // Проверка обязательных полей
            if (string.IsNullOrWhiteSpace(txtCustomerName.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text) ||
                string.IsNullOrWhiteSpace(txtStreet.Text) ||
                string.IsNullOrWhiteSpace(txtHouse.Text))
            {
                MessageBox.Show("Заполните имя, телефон и адрес (улица и дом).",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (listCart.Items.Count == 0)
            {
                MessageBox.Show("Корзина пуста.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Собираем список позиций
            StringBuilder itemsBuilder = new StringBuilder();
            foreach (var item in listCart.Items)
            {
                itemsBuilder.AppendLine(item.ToString());
            }
            string items = itemsBuilder.ToString();

            // Считаем сумму
            double total = 0.0;
            foreach (var item in listCart.Items)
            {
                string s = item.ToString();
                int dashIndex = s.LastIndexOf('-');
                if (dashIndex >= 0 && dashIndex + 1 < s.Length)
                {
                    string priceStr = s.Substring(dashIndex + 1).Trim();
                    if (double.TryParse(priceStr, NumberStyles.Any,
                        CultureInfo.InvariantCulture, out double price))
                    {
                        total += price;
                    }
                }
            }

            try
            {
                using (OleDbConnection conn = new OleDbConnection(Program.ConnStr))
                {
                    conn.Open();

                    string query = @"INSERT INTO Orders
                        (CustomerName, Phone, Street, House, Apartment, Items, Total, CreatedAt)
                        VALUES (?, ?, ?, ?, ?, ?, ?, ?)";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        // ВАЖНО: типы и порядок должны совпадать с полями таблицы Orders
                        // в Access: CustomerName, Phone, Street, House, Apartment, Items, Total, CreatedAt

                        cmd.Parameters.Add("?", OleDbType.VarWChar, 100).Value = txtCustomerName.Text.Trim();
                        cmd.Parameters.Add("?", OleDbType.VarWChar, 20).Value = txtPhone.Text.Trim();
                        cmd.Parameters.Add("?", OleDbType.VarWChar, 100).Value = txtStreet.Text.Trim();
                        cmd.Parameters.Add("?", OleDbType.VarWChar, 20).Value = txtHouse.Text.Trim();
                        cmd.Parameters.Add("?", OleDbType.VarWChar, 20).Value = txtApartment.Text.Trim();
                        cmd.Parameters.Add("?", OleDbType.LongVarWChar).Value = items;
                        cmd.Parameters.Add("?", OleDbType.Currency).Value = total;  // поле Total: Число/Денежный
                        cmd.Parameters.Add("?", OleDbType.Date).Value = DateTime.Now; // поле CreatedAt: Дата/время

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Заказ успешно сохранён в базе данных.",
                    "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                listCart.Items.Clear();
                UpdateTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении заказа: " + ex.Message,
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ===================== О КОМПАНИИ =====================

        private void btnInfo_Click(object sender, EventArgs e)
        {
            Form3 infoForm = new Form3();
            infoForm.ShowDialog();
        }
    }
}
