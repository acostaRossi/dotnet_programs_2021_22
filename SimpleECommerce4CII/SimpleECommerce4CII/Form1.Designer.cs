
namespace SimpleECommerce4CII
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonCatCreate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCatName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Price = new System.Windows.Forms.Label();
            this.textBoxPPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPName = new System.Windows.Forms.TextBox();
            this.buttonPCreate = new System.Windows.Forms.Button();
            this.comboBoxPCategory = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.listBoxProducts = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonCatCreate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxCatName);
            this.groupBox1.Location = new System.Drawing.Point(39, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Category";
            // 
            // buttonCatCreate
            // 
            this.buttonCatCreate.Location = new System.Drawing.Point(80, 57);
            this.buttonCatCreate.Name = "buttonCatCreate";
            this.buttonCatCreate.Size = new System.Drawing.Size(100, 23);
            this.buttonCatCreate.TabIndex = 4;
            this.buttonCatCreate.Text = "Create";
            this.buttonCatCreate.UseVisualStyleBackColor = true;
            this.buttonCatCreate.Click += new System.EventHandler(this.buttonCatCreate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // textBoxCatName
            // 
            this.textBoxCatName.Location = new System.Drawing.Point(80, 31);
            this.textBoxCatName.Name = "textBoxCatName";
            this.textBoxCatName.Size = new System.Drawing.Size(100, 20);
            this.textBoxCatName.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.comboBoxPCategory);
            this.groupBox2.Controls.Add(this.buttonPCreate);
            this.groupBox2.Controls.Add(this.Price);
            this.groupBox2.Controls.Add(this.textBoxPPrice);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBoxPName);
            this.groupBox2.Location = new System.Drawing.Point(271, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 157);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Product";
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Location = new System.Drawing.Point(30, 48);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(31, 13);
            this.Price.TabIndex = 10;
            this.Price.Text = "Price";
            // 
            // textBoxPPrice
            // 
            this.textBoxPPrice.Location = new System.Drawing.Point(71, 48);
            this.textBoxPPrice.Name = "textBoxPPrice";
            this.textBoxPPrice.Size = new System.Drawing.Size(100, 20);
            this.textBoxPPrice.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Name";
            // 
            // textBoxPName
            // 
            this.textBoxPName.Location = new System.Drawing.Point(71, 22);
            this.textBoxPName.Name = "textBoxPName";
            this.textBoxPName.Size = new System.Drawing.Size(100, 20);
            this.textBoxPName.TabIndex = 7;
            // 
            // buttonPCreate
            // 
            this.buttonPCreate.Location = new System.Drawing.Point(71, 112);
            this.buttonPCreate.Name = "buttonPCreate";
            this.buttonPCreate.Size = new System.Drawing.Size(100, 23);
            this.buttonPCreate.TabIndex = 11;
            this.buttonPCreate.Text = "Create";
            this.buttonPCreate.UseVisualStyleBackColor = true;
            this.buttonPCreate.Click += new System.EventHandler(this.buttonPCreate_Click);
            // 
            // comboBoxPCategory
            // 
            this.comboBoxPCategory.FormattingEnabled = true;
            this.comboBoxPCategory.Location = new System.Drawing.Point(71, 74);
            this.comboBoxPCategory.Name = "comboBoxPCategory";
            this.comboBoxPCategory.Size = new System.Drawing.Size(100, 21);
            this.comboBoxPCategory.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Category";
            // 
            // buttonPrint
            // 
            this.buttonPrint.Location = new System.Drawing.Point(66, 196);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(100, 69);
            this.buttonPrint.TabIndex = 12;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // listBoxProducts
            // 
            this.listBoxProducts.FormattingEnabled = true;
            this.listBoxProducts.Location = new System.Drawing.Point(488, 53);
            this.listBoxProducts.Name = "listBoxProducts";
            this.listBoxProducts.Size = new System.Drawing.Size(120, 95);
            this.listBoxProducts.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxProducts);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonCatCreate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCatName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.TextBox textBoxPPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPName;
        private System.Windows.Forms.Button buttonPCreate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxPCategory;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.ListBox listBoxProducts;
    }
}

