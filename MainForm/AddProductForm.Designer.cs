namespace MainForm
{
    partial class AddProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProductForm));
            this.pictureBoxProductImage = new System.Windows.Forms.PictureBox();
            this.labelProductName = new System.Windows.Forms.Label();
            this.richTextBoxProductDescription = new System.Windows.Forms.RichTextBox();
            this.buttonAddToShoppingCart = new System.Windows.Forms.Button();
            this.labelPrice = new System.Windows.Forms.Label();
            this.numericUpDownQuantityProduct = new System.Windows.Forms.NumericUpDown();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.buttonCloseForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProductImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantityProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxProductImage
            // 
            this.pictureBoxProductImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxProductImage.Location = new System.Drawing.Point(572, 189);
            this.pictureBoxProductImage.Name = "pictureBoxProductImage";
            this.pictureBoxProductImage.Size = new System.Drawing.Size(216, 192);
            this.pictureBoxProductImage.TabIndex = 0;
            this.pictureBoxProductImage.TabStop = false;
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.BackColor = System.Drawing.Color.DodgerBlue;
            this.labelProductName.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductName.Location = new System.Drawing.Point(12, 9);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(195, 37);
            this.labelProductName.TabIndex = 1;
            this.labelProductName.Text = "ProductName";
            this.labelProductName.Click += new System.EventHandler(this.label1_Click);
            // 
            // richTextBoxProductDescription
            // 
            this.richTextBoxProductDescription.BackColor = System.Drawing.Color.DodgerBlue;
            this.richTextBoxProductDescription.Cursor = System.Windows.Forms.Cursors.Default;
            this.richTextBoxProductDescription.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxProductDescription.Location = new System.Drawing.Point(12, 189);
            this.richTextBoxProductDescription.Name = "richTextBoxProductDescription";
            this.richTextBoxProductDescription.ReadOnly = true;
            this.richTextBoxProductDescription.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBoxProductDescription.Size = new System.Drawing.Size(553, 192);
            this.richTextBoxProductDescription.TabIndex = 2;
            this.richTextBoxProductDescription.Text = "";
            // 
            // buttonAddToShoppingCart
            // 
            this.buttonAddToShoppingCart.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonAddToShoppingCart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddToShoppingCart.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddToShoppingCart.Location = new System.Drawing.Point(344, 416);
            this.buttonAddToShoppingCart.Name = "buttonAddToShoppingCart";
            this.buttonAddToShoppingCart.Size = new System.Drawing.Size(138, 23);
            this.buttonAddToShoppingCart.TabIndex = 3;
            this.buttonAddToShoppingCart.Text = "Add to Shopping cart";
            this.buttonAddToShoppingCart.UseVisualStyleBackColor = false;
            this.buttonAddToShoppingCart.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.BackColor = System.Drawing.Color.DodgerBlue;
            this.labelPrice.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.Location = new System.Drawing.Point(12, 132);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(81, 37);
            this.labelPrice.TabIndex = 4;
            this.labelPrice.Text = "Price";
            // 
            // numericUpDownQuantityProduct
            // 
            this.numericUpDownQuantityProduct.BackColor = System.Drawing.Color.DodgerBlue;
            this.numericUpDownQuantityProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numericUpDownQuantityProduct.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownQuantityProduct.Location = new System.Drawing.Point(12, 416);
            this.numericUpDownQuantityProduct.Name = "numericUpDownQuantityProduct";
            this.numericUpDownQuantityProduct.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownQuantityProduct.TabIndex = 5;
            this.numericUpDownQuantityProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownQuantityProduct.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.BackColor = System.Drawing.Color.DodgerBlue;
            this.labelQuantity.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantity.Location = new System.Drawing.Point(41, 400);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(52, 13);
            this.labelQuantity.TabIndex = 6;
            this.labelQuantity.Text = "Quantity";
            // 
            // buttonCloseForm
            // 
            this.buttonCloseForm.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonCloseForm.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCloseForm.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCloseForm.Location = new System.Drawing.Point(650, 415);
            this.buttonCloseForm.Name = "buttonCloseForm";
            this.buttonCloseForm.Size = new System.Drawing.Size(138, 23);
            this.buttonCloseForm.TabIndex = 7;
            this.buttonCloseForm.Text = "Close";
            this.buttonCloseForm.UseVisualStyleBackColor = false;
            this.buttonCloseForm.Click += new System.EventHandler(this.buttonCloseForm_Click);
            // 
            // AddProductForm
            // 
            this.AcceptButton = this.buttonAddToShoppingCart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.buttonCloseForm;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCloseForm);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.numericUpDownQuantityProduct);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.buttonAddToShoppingCart);
            this.Controls.Add(this.richTextBoxProductDescription);
            this.Controls.Add(this.labelProductName);
            this.Controls.Add(this.pictureBoxProductImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddProductForm";
            this.Text = "Product details";
            this.Load += new System.EventHandler(this.AddProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProductImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantityProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxProductImage;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.RichTextBox richTextBoxProductDescription;
        private System.Windows.Forms.Button buttonAddToShoppingCart;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantityProduct;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Button buttonCloseForm;
    }
}