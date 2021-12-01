
namespace SimpleECommerce
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPInsert = new System.Windows.Forms.Button();
            this.textBoxPSKU = new System.Windows.Forms.TextBox();
            this.textBoxPPrice = new System.Windows.Forms.TextBox();
            this.textBoxPBrand = new System.Windows.Forms.TextBox();
            this.textBoxPName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxCategoryName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonCategoryCreate = new System.Windows.Forms.Button();
            this.comboBoxPCategory = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.listBoxScaffal = new System.Windows.Forms.ListBox();
            this.buttonStampa = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.comboBoxPCategory);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonPInsert);
            this.groupBox1.Controls.Add(this.textBoxPSKU);
            this.groupBox1.Controls.Add(this.textBoxPPrice);
            this.groupBox1.Controls.Add(this.textBoxPBrand);
            this.groupBox1.Controls.Add(this.textBoxPName);
            this.groupBox1.Location = new System.Drawing.Point(219, 28);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(241, 267);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(10, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "SKU";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(10, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Price";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(7, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Brand";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(7, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonPInsert
            // 
            this.buttonPInsert.Location = new System.Drawing.Point(80, 210);
            this.buttonPInsert.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPInsert.Name = "buttonPInsert";
            this.buttonPInsert.Size = new System.Drawing.Size(132, 28);
            this.buttonPInsert.TabIndex = 6;
            this.buttonPInsert.Text = "Create";
            this.buttonPInsert.UseVisualStyleBackColor = true;
            this.buttonPInsert.Click += new System.EventHandler(this.buttonPInsert_Click);
            // 
            // textBoxPSKU
            // 
            this.textBoxPSKU.Location = new System.Drawing.Point(80, 132);
            this.textBoxPSKU.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPSKU.Name = "textBoxPSKU";
            this.textBoxPSKU.Size = new System.Drawing.Size(132, 22);
            this.textBoxPSKU.TabIndex = 4;
            // 
            // textBoxPPrice
            // 
            this.textBoxPPrice.Location = new System.Drawing.Point(80, 100);
            this.textBoxPPrice.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPPrice.Name = "textBoxPPrice";
            this.textBoxPPrice.Size = new System.Drawing.Size(132, 22);
            this.textBoxPPrice.TabIndex = 3;
            // 
            // textBoxPBrand
            // 
            this.textBoxPBrand.Location = new System.Drawing.Point(80, 68);
            this.textBoxPBrand.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPBrand.Name = "textBoxPBrand";
            this.textBoxPBrand.Size = new System.Drawing.Size(132, 22);
            this.textBoxPBrand.TabIndex = 2;
            // 
            // textBoxPName
            // 
            this.textBoxPName.Location = new System.Drawing.Point(80, 36);
            this.textBoxPName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPName.Name = "textBoxPName";
            this.textBoxPName.Size = new System.Drawing.Size(132, 22);
            this.textBoxPName.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonCategoryCreate);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBoxCategoryName);
            this.groupBox2.Location = new System.Drawing.Point(12, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 117);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Category";
            // 
            // textBoxCategoryName
            // 
            this.textBoxCategoryName.Location = new System.Drawing.Point(61, 39);
            this.textBoxCategoryName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCategoryName.Name = "textBoxCategoryName";
            this.textBoxCategoryName.Size = new System.Drawing.Size(132, 22);
            this.textBoxCategoryName.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(6, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Name";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonCategoryCreate
            // 
            this.buttonCategoryCreate.Location = new System.Drawing.Point(61, 69);
            this.buttonCategoryCreate.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCategoryCreate.Name = "buttonCategoryCreate";
            this.buttonCategoryCreate.Size = new System.Drawing.Size(132, 28);
            this.buttonCategoryCreate.TabIndex = 13;
            this.buttonCategoryCreate.Text = "Create";
            this.buttonCategoryCreate.UseVisualStyleBackColor = true;
            this.buttonCategoryCreate.Click += new System.EventHandler(this.buttonCategoryCreate_Click);
            // 
            // comboBoxPCategory
            // 
            this.comboBoxPCategory.FormattingEnabled = true;
            this.comboBoxPCategory.Location = new System.Drawing.Point(80, 161);
            this.comboBoxPCategory.Name = "comboBoxPCategory";
            this.comboBoxPCategory.Size = new System.Drawing.Size(132, 24);
            this.comboBoxPCategory.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(0, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Category";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // listBoxScaffal
            // 
            this.listBoxScaffal.FormattingEnabled = true;
            this.listBoxScaffal.ItemHeight = 16;
            this.listBoxScaffal.Location = new System.Drawing.Point(467, 34);
            this.listBoxScaffal.Name = "listBoxScaffal";
            this.listBoxScaffal.Size = new System.Drawing.Size(195, 260);
            this.listBoxScaffal.TabIndex = 3;
            // 
            // buttonStampa
            // 
            this.buttonStampa.Location = new System.Drawing.Point(55, 219);
            this.buttonStampa.Margin = new System.Windows.Forms.Padding(4);
            this.buttonStampa.Name = "buttonStampa";
            this.buttonStampa.Size = new System.Drawing.Size(132, 28);
            this.buttonStampa.TabIndex = 14;
            this.buttonStampa.Text = "Print";
            this.buttonStampa.UseVisualStyleBackColor = true;
            this.buttonStampa.Click += new System.EventHandler(this.buttonStampa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 554);
            this.Controls.Add(this.buttonStampa);
            this.Controls.Add(this.listBoxScaffal);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Button buttonPInsert;
        private System.Windows.Forms.TextBox textBoxPSKU;
        private System.Windows.Forms.TextBox textBoxPPrice;
        private System.Windows.Forms.TextBox textBoxPBrand;
        private System.Windows.Forms.TextBox textBoxPName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonCategoryCreate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxCategoryName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxPCategory;
        private System.Windows.Forms.ListBox listBoxScaffal;
        private System.Windows.Forms.Button buttonStampa;
    }
}

