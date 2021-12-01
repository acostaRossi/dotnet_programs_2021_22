
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
            this.textBoxPName = new System.Windows.Forms.TextBox();
            this.textBoxPBrand = new System.Windows.Forms.TextBox();
            this.textBoxPPrice = new System.Windows.Forms.TextBox();
            this.textBoxPSKU = new System.Windows.Forms.TextBox();
            this.buttonPInsert = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonPInsert);
            this.groupBox1.Controls.Add(this.textBoxPSKU);
            this.groupBox1.Controls.Add(this.textBoxPPrice);
            this.groupBox1.Controls.Add(this.textBoxPBrand);
            this.groupBox1.Controls.Add(this.textBoxPName);
            this.groupBox1.Location = new System.Drawing.Point(49, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(181, 179);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Prodotto";
            // 
            // textBoxPName
            // 
            this.textBoxPName.Location = new System.Drawing.Point(60, 29);
            this.textBoxPName.Name = "textBoxPName";
            this.textBoxPName.Size = new System.Drawing.Size(100, 20);
            this.textBoxPName.TabIndex = 1;
            // 
            // textBoxPBrand
            // 
            this.textBoxPBrand.Location = new System.Drawing.Point(60, 55);
            this.textBoxPBrand.Name = "textBoxPBrand";
            this.textBoxPBrand.Size = new System.Drawing.Size(100, 20);
            this.textBoxPBrand.TabIndex = 2;
            // 
            // textBoxPPrice
            // 
            this.textBoxPPrice.Location = new System.Drawing.Point(60, 81);
            this.textBoxPPrice.Name = "textBoxPPrice";
            this.textBoxPPrice.Size = new System.Drawing.Size(100, 20);
            this.textBoxPPrice.TabIndex = 3;
            // 
            // textBoxPSKU
            // 
            this.textBoxPSKU.Location = new System.Drawing.Point(60, 107);
            this.textBoxPSKU.Name = "textBoxPSKU";
            this.textBoxPSKU.Size = new System.Drawing.Size(100, 20);
            this.textBoxPSKU.TabIndex = 4;
            // 
            // buttonPInsert
            // 
            this.buttonPInsert.Location = new System.Drawing.Point(74, 133);
            this.buttonPInsert.Name = "buttonPInsert";
            this.buttonPInsert.Size = new System.Drawing.Size(75, 23);
            this.buttonPInsert.TabIndex = 6;
            this.buttonPInsert.Text = "Crea";
            this.buttonPInsert.UseVisualStyleBackColor = true;
            this.buttonPInsert.Click += new System.EventHandler(this.buttonPInsert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonPInsert;
        private System.Windows.Forms.TextBox textBoxPSKU;
        private System.Windows.Forms.TextBox textBoxPPrice;
        private System.Windows.Forms.TextBox textBoxPBrand;
        private System.Windows.Forms.TextBox textBoxPName;
    }
}

