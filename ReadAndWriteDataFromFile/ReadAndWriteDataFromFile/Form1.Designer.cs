
namespace ReadAndWriteDataFromFile
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
            this.listBoxPeople = new System.Windows.Forms.ListBox();
            this.listBoxSelected = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonWriteIntoFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxPeople
            // 
            this.listBoxPeople.FormattingEnabled = true;
            this.listBoxPeople.Location = new System.Drawing.Point(22, 103);
            this.listBoxPeople.Name = "listBoxPeople";
            this.listBoxPeople.Size = new System.Drawing.Size(315, 381);
            this.listBoxPeople.TabIndex = 1;
            this.listBoxPeople.SelectedIndexChanged += new System.EventHandler(this.listBoxPeople_SelectedIndexChanged);
            // 
            // listBoxSelected
            // 
            this.listBoxSelected.FormattingEnabled = true;
            this.listBoxSelected.Location = new System.Drawing.Point(354, 103);
            this.listBoxSelected.Name = "listBoxSelected";
            this.listBoxSelected.Size = new System.Drawing.Size(318, 381);
            this.listBoxSelected.TabIndex = 2;
            this.listBoxSelected.SelectedIndexChanged += new System.EventHandler(this.listBoxSelected_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(154, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(417, 48);
            this.label1.TabIndex = 3;
            this.label1.Text = "Read data from file and load records into ListBox.\r\nMove data beetween 2 listbox\r" +
    "\n";
            // 
            // buttonWriteIntoFile
            // 
            this.buttonWriteIntoFile.Location = new System.Drawing.Point(217, 517);
            this.buttonWriteIntoFile.Name = "buttonWriteIntoFile";
            this.buttonWriteIntoFile.Size = new System.Drawing.Size(256, 23);
            this.buttonWriteIntoFile.TabIndex = 4;
            this.buttonWriteIntoFile.Text = "Write selected into file";
            this.buttonWriteIntoFile.UseVisualStyleBackColor = true;
            this.buttonWriteIntoFile.Click += new System.EventHandler(this.buttonWriteIntoFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 638);
            this.Controls.Add(this.buttonWriteIntoFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxSelected);
            this.Controls.Add(this.listBoxPeople);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxPeople;
        private System.Windows.Forms.ListBox listBoxSelected;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonWriteIntoFile;
    }
}

