namespace FoodDeliveryApp
{
    partial class Form3
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblInfo;

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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(360, 23);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Служба доставки еды \"FoodExpress\"";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInfo
            // 
            this.lblInfo.Location = new System.Drawing.Point(12, 40);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(360, 120);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Text = "Мы доставляем горячую и свежую еду по городу.\r\n" +
                "Время работы: 10:00 – 23:00.\r\n" +
                "Телефон службы поддержки: +7 (999) 123-45-67.\r\n\r\n" +
                "Спасибо, что выбираете нас!";
            // 
            // Form3
            // 
            this.ClientSize = new System.Drawing.Size(384, 181);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "О компании";
            this.ResumeLayout(false);
        }
    }
}
