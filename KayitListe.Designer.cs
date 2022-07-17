namespace TODOLİST
{
    partial class KayitListe
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
            this.groupBoxİslemListe = new System.Windows.Forms.GroupBox();
            this.buttonİptalEdildi = new System.Windows.Forms.Button();
            this.buttonTamamlanmadi = new System.Windows.Forms.Button();
            this.buttonTamamlandi = new System.Windows.Forms.Button();
            this.buttonTümListe = new System.Windows.Forms.Button();
            this.groupBoxListe = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBoxİslemListe.SuspendLayout();
            this.groupBoxListe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxİslemListe
            // 
            this.groupBoxİslemListe.Controls.Add(this.buttonİptalEdildi);
            this.groupBoxİslemListe.Controls.Add(this.buttonTamamlanmadi);
            this.groupBoxİslemListe.Controls.Add(this.buttonTamamlandi);
            this.groupBoxİslemListe.Controls.Add(this.buttonTümListe);
            this.groupBoxİslemListe.Location = new System.Drawing.Point(0, 0);
            this.groupBoxİslemListe.Name = "groupBoxİslemListe";
            this.groupBoxİslemListe.Size = new System.Drawing.Size(185, 305);
            this.groupBoxİslemListe.TabIndex = 0;
            this.groupBoxİslemListe.TabStop = false;
            this.groupBoxİslemListe.Text = "İşlem Listesi";
            this.groupBoxİslemListe.Enter += new System.EventHandler(this.groupBoxİslemListe_Enter);
            // 
            // buttonİptalEdildi
            // 
            this.buttonİptalEdildi.Location = new System.Drawing.Point(39, 215);
            this.buttonİptalEdildi.Name = "buttonİptalEdildi";
            this.buttonİptalEdildi.Size = new System.Drawing.Size(104, 35);
            this.buttonİptalEdildi.TabIndex = 4;
            this.buttonİptalEdildi.Text = "İptal Edildi";
            this.buttonİptalEdildi.UseVisualStyleBackColor = true;
            // 
            // buttonTamamlanmadi
            // 
            this.buttonTamamlanmadi.Location = new System.Drawing.Point(39, 164);
            this.buttonTamamlanmadi.Name = "buttonTamamlanmadi";
            this.buttonTamamlanmadi.Size = new System.Drawing.Size(104, 35);
            this.buttonTamamlanmadi.TabIndex = 3;
            this.buttonTamamlanmadi.Text = "Tamamlanmadı";
            this.buttonTamamlanmadi.UseVisualStyleBackColor = true;
            // 
            // buttonTamamlandi
            // 
            this.buttonTamamlandi.Location = new System.Drawing.Point(39, 111);
            this.buttonTamamlandi.Name = "buttonTamamlandi";
            this.buttonTamamlandi.Size = new System.Drawing.Size(104, 35);
            this.buttonTamamlandi.TabIndex = 2;
            this.buttonTamamlandi.Text = "Tamamlandı";
            this.buttonTamamlandi.UseVisualStyleBackColor = true;
            // 
            // buttonTümListe
            // 
            this.buttonTümListe.Location = new System.Drawing.Point(39, 53);
            this.buttonTümListe.Name = "buttonTümListe";
            this.buttonTümListe.Size = new System.Drawing.Size(104, 35);
            this.buttonTümListe.TabIndex = 1;
            this.buttonTümListe.Text = "Tüm Liste";
            this.buttonTümListe.UseVisualStyleBackColor = true;
            // 
            // groupBoxListe
            // 
            this.groupBoxListe.Controls.Add(this.dataGridView1);
            this.groupBoxListe.Location = new System.Drawing.Point(191, 0);
            this.groupBoxListe.Name = "groupBoxListe";
            this.groupBoxListe.Size = new System.Drawing.Size(634, 497);
            this.groupBoxListe.TabIndex = 1;
            this.groupBoxListe.TabStop = false;
            this.groupBoxListe.Text = "Liste";
            this.groupBoxListe.Enter += new System.EventHandler(this.groupBoxListe_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(628, 478);
            this.dataGridView1.TabIndex = 0;
            // 
            // KayitListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 509);
            this.Controls.Add(this.groupBoxListe);
            this.Controls.Add(this.groupBoxİslemListe);
            this.Name = "KayitListe";
            this.Text = "KayitListe";
            this.groupBoxİslemListe.ResumeLayout(false);
            this.groupBoxListe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxİslemListe;
        private System.Windows.Forms.Button buttonİptalEdildi;
        private System.Windows.Forms.Button buttonTamamlanmadi;
        private System.Windows.Forms.Button buttonTamamlandi;
        private System.Windows.Forms.Button buttonTümListe;
        private System.Windows.Forms.GroupBox groupBoxListe;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}