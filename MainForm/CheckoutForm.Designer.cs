namespace MainForm
{
    partial class CheckoutForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckoutForm));
            this.checkBoxCash = new System.Windows.Forms.CheckBox();
            this.checkBoxCreditCard = new System.Windows.Forms.CheckBox();
            this.buttonPay = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxPostalCode = new System.Windows.Forms.TextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.textBoxCreditCardNumber = new System.Windows.Forms.TextBox();
            this.textBoxExpirationDate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkBoxCash
            // 
            this.checkBoxCash.AutoSize = true;
            this.checkBoxCash.Location = new System.Drawing.Point(672, 367);
            this.checkBoxCash.Name = "checkBoxCash";
            this.checkBoxCash.Size = new System.Drawing.Size(70, 17);
            this.checkBoxCash.TabIndex = 8;
            this.checkBoxCash.Text = "Pay cash";
            this.checkBoxCash.UseVisualStyleBackColor = true;
            // 
            // checkBoxCreditCard
            // 
            this.checkBoxCreditCard.AutoSize = true;
            this.checkBoxCreditCard.Checked = true;
            this.checkBoxCreditCard.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCreditCard.Location = new System.Drawing.Point(672, 409);
            this.checkBoxCreditCard.Name = "checkBoxCreditCard";
            this.checkBoxCreditCard.Size = new System.Drawing.Size(119, 17);
            this.checkBoxCreditCard.TabIndex = 9;
            this.checkBoxCreditCard.Text = "Pay with credit card";
            this.checkBoxCreditCard.UseVisualStyleBackColor = true;
            // 
            // buttonPay
            // 
            this.buttonPay.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonPay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonPay.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.buttonPay.FlatAppearance.BorderSize = 20;
            this.buttonPay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPay.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.buttonPay.Location = new System.Drawing.Point(12, 394);
            this.buttonPay.Name = "buttonPay";
            this.buttonPay.Size = new System.Drawing.Size(163, 44);
            this.buttonPay.TabIndex = 10;
            this.buttonPay.Text = "Pay";
            this.buttonPay.UseVisualStyleBackColor = false;
            this.buttonPay.Click += new System.EventHandler(this.buttonPay_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.Color.DodgerBlue;
            this.textBoxName.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.textBoxName.Location = new System.Drawing.Point(12, 25);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(201, 22);
            this.textBoxName.TabIndex = 11;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.BackColor = System.Drawing.Color.DodgerBlue;
            this.textBoxSurname.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.textBoxSurname.Location = new System.Drawing.Point(12, 62);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(201, 22);
            this.textBoxSurname.TabIndex = 12;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.BackColor = System.Drawing.Color.DodgerBlue;
            this.textBoxAddress.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.textBoxAddress.Location = new System.Drawing.Point(12, 99);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(201, 22);
            this.textBoxAddress.TabIndex = 13;
            // 
            // textBoxPostalCode
            // 
            this.textBoxPostalCode.BackColor = System.Drawing.Color.DodgerBlue;
            this.textBoxPostalCode.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.textBoxPostalCode.Location = new System.Drawing.Point(12, 136);
            this.textBoxPostalCode.Name = "textBoxPostalCode";
            this.textBoxPostalCode.Size = new System.Drawing.Size(201, 22);
            this.textBoxPostalCode.TabIndex = 14;
            // 
            // textBoxCity
            // 
            this.textBoxCity.BackColor = System.Drawing.Color.DodgerBlue;
            this.textBoxCity.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.textBoxCity.Location = new System.Drawing.Point(12, 173);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(201, 22);
            this.textBoxCity.TabIndex = 15;
            // 
            // textBoxCreditCardNumber
            // 
            this.textBoxCreditCardNumber.BackColor = System.Drawing.Color.DodgerBlue;
            this.textBoxCreditCardNumber.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.textBoxCreditCardNumber.Location = new System.Drawing.Point(587, 25);
            this.textBoxCreditCardNumber.Name = "textBoxCreditCardNumber";
            this.textBoxCreditCardNumber.Size = new System.Drawing.Size(201, 22);
            this.textBoxCreditCardNumber.TabIndex = 16;
            // 
            // textBoxExpirationDate
            // 
            this.textBoxExpirationDate.BackColor = System.Drawing.Color.DodgerBlue;
            this.textBoxExpirationDate.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.textBoxExpirationDate.Location = new System.Drawing.Point(587, 62);
            this.textBoxExpirationDate.Name = "textBoxExpirationDate";
            this.textBoxExpirationDate.Size = new System.Drawing.Size(201, 22);
            this.textBoxExpirationDate.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DodgerBlue;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DodgerBlue;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DodgerBlue;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DodgerBlue;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(12, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Postal code";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DodgerBlue;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 8F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(12, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "City";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DodgerBlue;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 8F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(12, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Phone number";
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.BackColor = System.Drawing.Color.DodgerBlue;
            this.textBoxPhoneNumber.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(12, 214);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(201, 22);
            this.textBoxPhoneNumber.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.DodgerBlue;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 8F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(584, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Credit Card Number";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.DodgerBlue;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 8F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(584, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Expiration Date";
            // 
            // CheckoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxPhoneNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxExpirationDate);
            this.Controls.Add(this.textBoxCreditCardNumber);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.textBoxPostalCode);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonPay);
            this.Controls.Add(this.checkBoxCreditCard);
            this.Controls.Add(this.checkBoxCash);
            this.Name = "CheckoutForm";
            this.Text = "CheckoutForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxCash;
        private System.Windows.Forms.CheckBox checkBoxCreditCard;
        private System.Windows.Forms.Button buttonPay;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxPostalCode;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.TextBox textBoxCreditCardNumber;
        private System.Windows.Forms.TextBox textBoxExpirationDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}