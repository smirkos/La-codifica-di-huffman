namespace La_codifica_di_huffman
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Liberare le risorse in uso.
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
            this.txtParola = new System.Windows.Forms.TextBox();
            this.btnAnalizza = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTab = new System.Windows.Forms.DataGridView();
            this.car = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.occor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.occ_car = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grp1 = new System.Windows.Forms.GroupBox();
            this.lstRis = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTab)).BeginInit();
            this.grp1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtParola
            // 
            this.txtParola.Location = new System.Drawing.Point(109, 18);
            this.txtParola.Name = "txtParola";
            this.txtParola.Size = new System.Drawing.Size(149, 20);
            this.txtParola.TabIndex = 0;
            // 
            // btnAnalizza
            // 
            this.btnAnalizza.Location = new System.Drawing.Point(264, 18);
            this.btnAnalizza.Name = "btnAnalizza";
            this.btnAnalizza.Size = new System.Drawing.Size(75, 23);
            this.btnAnalizza.TabIndex = 1;
            this.btnAnalizza.Text = "Codifica";
            this.btnAnalizza.UseVisualStyleBackColor = true;
            this.btnAnalizza.Click += new System.EventHandler(this.btnAnalizza_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Inserisci la parola \r\nda codificare";
            // 
            // dgvTab
            // 
            this.dgvTab.AllowUserToAddRows = false;
            this.dgvTab.AllowUserToDeleteRows = false;
            this.dgvTab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTab.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.car,
            this.occor,
            this.occ_car});
            this.dgvTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTab.Location = new System.Drawing.Point(3, 16);
            this.dgvTab.Name = "dgvTab";
            this.dgvTab.ReadOnly = true;
            this.dgvTab.Size = new System.Drawing.Size(330, 175);
            this.dgvTab.TabIndex = 3;
            // 
            // car
            // 
            this.car.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.car.HeaderText = "Carattere";
            this.car.Name = "car";
            this.car.ReadOnly = true;
            // 
            // occor
            // 
            this.occor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.occor.HeaderText = "Occorrenze";
            this.occor.Name = "occor";
            this.occor.ReadOnly = true;
            // 
            // occ_car
            // 
            this.occ_car.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.occ_car.HeaderText = "Occorrenze/carattere";
            this.occ_car.Name = "occ_car";
            this.occ_car.ReadOnly = true;
            // 
            // grp1
            // 
            this.grp1.Controls.Add(this.dgvTab);
            this.grp1.Location = new System.Drawing.Point(15, 47);
            this.grp1.Name = "grp1";
            this.grp1.Size = new System.Drawing.Size(336, 194);
            this.grp1.TabIndex = 4;
            this.grp1.TabStop = false;
            this.grp1.Text = "Tabella";
            // 
            // lstRis
            // 
            this.lstRis.FormattingEnabled = true;
            this.lstRis.Location = new System.Drawing.Point(354, 18);
            this.lstRis.Name = "lstRis";
            this.lstRis.Size = new System.Drawing.Size(181, 225);
            this.lstRis.TabIndex = 5;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnAnalizza;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 257);
            this.Controls.Add(this.lstRis);
            this.Controls.Add(this.grp1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAnalizza);
            this.Controls.Add(this.txtParola);
            this.Name = "Form1";
            this.Text = "La codifica di hufman";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTab)).EndInit();
            this.grp1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.Button btnAnalizza;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTab;
        private System.Windows.Forms.GroupBox grp1;
        private System.Windows.Forms.DataGridViewTextBoxColumn car;
        private System.Windows.Forms.DataGridViewTextBoxColumn occor;
        private System.Windows.Forms.DataGridViewTextBoxColumn occ_car;
        private System.Windows.Forms.ListBox lstRis;
    }
}

