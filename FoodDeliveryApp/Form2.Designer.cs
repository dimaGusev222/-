namespace FoodDeliveryApp
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.ListBox listMenu;
        private System.Windows.Forms.ListBox listCart;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Button btnRemoveFromCart;
        private System.Windows.Forms.Label lblTotal;

        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblHouse;
        private System.Windows.Forms.Label lblApartment;

        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.TextBox txtHouse;
        private System.Windows.Forms.TextBox txtApartment;

        private System.Windows.Forms.Button btnSubmitOrder;
        private System.Windows.Forms.Button btnInfo;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblUser = new System.Windows.Forms.Label();
            this.listMenu = new System.Windows.Forms.ListBox();
            this.listCart = new System.Windows.Forms.ListBox();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.btnRemoveFromCart = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblHouse = new System.Windows.Forms.Label();
            this.lblApartment = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtHouse = new System.Windows.Forms.TextBox();
            this.txtApartment = new System.Windows.Forms.TextBox();
            this.btnSubmitOrder = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(12, 9);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(82, 13);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "Пользователь:";
            // 
            // listMenu
            // 
            this.listMenu.FormattingEnabled = true;
            this.listMenu.Location = new System.Drawing.Point(15, 35);
            this.listMenu.Name = "listMenu";
            this.listMenu.Size = new System.Drawing.Size(220, 173);
            this.listMenu.TabIndex = 1;
            // 
            // listCart
            // 
            this.listCart.FormattingEnabled = true;
            this.listCart.Location = new System.Drawing.Point(320, 35);
            this.listCart.Name = "listCart";
            this.listCart.Size = new System.Drawing.Size(220, 173);
            this.listCart.TabIndex = 2;
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Location = new System.Drawing.Point(241, 80);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(73, 30);
            this.btnAddToCart.TabIndex = 3;
            this.btnAddToCart.Text = "→";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // btnRemoveFromCart
            // 
            this.btnRemoveFromCart.Location = new System.Drawing.Point(241, 130);
            this.btnRemoveFromCart.Name = "btnRemoveFromCart";
            this.btnRemoveFromCart.Size = new System.Drawing.Size(73, 30);
            this.btnRemoveFromCart.TabIndex = 4;
            this.btnRemoveFromCart.Text = "←";
            this.btnRemoveFromCart.UseVisualStyleBackColor = true;
            this.btnRemoveFromCart.Click += new System.EventHandler(this.btnRemoveFromCart_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(317, 215);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(43, 13);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "Итого: ";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(15, 230);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(77, 13);
            this.lblCustomerName.TabIndex = 6;
            this.lblCustomerName.Text = "Имя клиента:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(15, 260);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(55, 13);
            this.lblPhone.TabIndex = 7;
            this.lblPhone.Text = "Телефон:";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(15, 290);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(42, 13);
            this.lblStreet.TabIndex = 8;
            this.lblStreet.Text = "Улица:";
            // 
            // lblHouse
            // 
            this.lblHouse.AutoSize = true;
            this.lblHouse.Location = new System.Drawing.Point(15, 320);
            this.lblHouse.Name = "lblHouse";
            this.lblHouse.Size = new System.Drawing.Size(33, 13);
            this.lblHouse.TabIndex = 9;
            this.lblHouse.Text = "Дом:";
            // 
            // lblApartment
            // 
            this.lblApartment.AutoSize = true;
            this.lblApartment.Location = new System.Drawing.Point(15, 350);
            this.lblApartment.Name = "lblApartment";
            this.lblApartment.Size = new System.Drawing.Size(59, 13);
            this.lblApartment.TabIndex = 10;
            this.lblApartment.Text = "Квартира:";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(105, 227);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(180, 20);
            this.txtCustomerName.TabIndex = 11;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(105, 257);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(180, 20);
            this.txtPhone.TabIndex = 12;
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(105, 287);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(180, 20);
            this.txtStreet.TabIndex = 13;
            // 
            // txtHouse
            // 
            this.txtHouse.Location = new System.Drawing.Point(105, 317);
            this.txtHouse.Name = "txtHouse";
            this.txtHouse.Size = new System.Drawing.Size(60, 20);
            this.txtHouse.TabIndex = 14;
            // 
            // txtApartment
            // 
            this.txtApartment.Location = new System.Drawing.Point(105, 347);
            this.txtApartment.Name = "txtApartment";
            this.txtApartment.Size = new System.Drawing.Size(60, 20);
            this.txtApartment.TabIndex = 15;
            // 
            // btnSubmitOrder
            // 
            this.btnSubmitOrder.Location = new System.Drawing.Point(320, 245);
            this.btnSubmitOrder.Name = "btnSubmitOrder";
            this.btnSubmitOrder.Size = new System.Drawing.Size(220, 35);
            this.btnSubmitOrder.TabIndex = 16;
            this.btnSubmitOrder.Text = "Оформить заказ";
            this.btnSubmitOrder.UseVisualStyleBackColor = true;
            this.btnSubmitOrder.Click += new System.EventHandler(this.btnSubmitOrder_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(320, 290);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(220, 30);
            this.btnInfo.TabIndex = 17;
            this.btnInfo.Text = "О компании";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(560, 390);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnSubmitOrder);
            this.Controls.Add(this.txtApartment);
            this.Controls.Add(this.txtHouse);
            this.Controls.Add(this.txtStreet);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.lblApartment);
            this.Controls.Add(this.lblHouse);
            this.Controls.Add(this.lblStreet);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnRemoveFromCart);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.listCart);
            this.Controls.Add(this.listMenu);
            this.Controls.Add(this.lblUser);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Оформление заказа";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
