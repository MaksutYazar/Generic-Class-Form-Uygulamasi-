namespace TODOLİST
{
    partial class YeniKayit
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxbaslik = new System.Windows.Forms.TextBox();
            this.textBoxkisaaciklama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxaciklama = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxonem = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxdurum = new System.Windows.Forms.ComboBox();
            this.buttonyenikayit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(353, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Başlık :";
            // 
            // textBoxbaslik
            // 
            this.textBoxbaslik.Location = new System.Drawing.Point(402, 34);
            this.textBoxbaslik.Name = "textBoxbaslik";
            this.textBoxbaslik.Size = new System.Drawing.Size(100, 20);
            this.textBoxbaslik.TabIndex = 1;
            this.textBoxbaslik.Enter += new System.EventHandler(this.textBoxbaslik_Enter);
            this.textBoxbaslik.Leave += new System.EventHandler(this.textBoxbaslik_Leave);
            // 
            // textBoxkisaaciklama
            // 
            this.textBoxkisaaciklama.Location = new System.Drawing.Point(402, 87);
            this.textBoxkisaaciklama.Multiline = true;
            this.textBoxkisaaciklama.Name = "textBoxkisaaciklama";
            this.textBoxkisaaciklama.Size = new System.Drawing.Size(100, 75);
            this.textBoxkisaaciklama.TabIndex = 3;
            this.textBoxkisaaciklama.Enter += new System.EventHandler(this.textBoxbaslik_Enter);
            this.textBoxkisaaciklama.Leave += new System.EventHandler(this.textBoxbaslik_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kısa Açıklama :";
            // 
            // textBoxaciklama
            // 
            this.textBoxaciklama.Location = new System.Drawing.Point(402, 192);
            this.textBoxaciklama.Multiline = true;
            this.textBoxaciklama.Name = "textBoxaciklama";
            this.textBoxaciklama.Size = new System.Drawing.Size(100, 118);
            this.textBoxaciklama.TabIndex = 5;
            this.textBoxaciklama.Enter += new System.EventHandler(this.textBoxbaslik_Enter);
            this.textBoxaciklama.Leave += new System.EventHandler(this.textBoxbaslik_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(338, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Açıklama :";
            // 
            // textBoxonem
            // 
            this.textBoxonem.Location = new System.Drawing.Point(402, 328);
            this.textBoxonem.Name = "textBoxonem";
            this.textBoxonem.Size = new System.Drawing.Size(100, 20);
            this.textBoxonem.TabIndex = 7;
            this.textBoxonem.TextChanged += new System.EventHandler(this.textBoxonem_TextChanged);
            this.textBoxonem.Enter += new System.EventHandler(this.textBoxbaslik_Enter);
            this.textBoxonem.Leave += new System.EventHandler(this.textBoxbaslik_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(308, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Önem Derecesi :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(353, 367);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Durum :";
            // 
            // comboBoxdurum
            // 
            this.comboBoxdurum.FormattingEnabled = true;
            this.comboBoxdurum.Items.AddRange(new object[] {
            "Beklemede",
            "Tamamlandı",
            "Tamamlanmadı",
            "İptal Edildi",
            "Ertelendi"});
            this.comboBoxdurum.Location = new System.Drawing.Point(402, 364);
            this.comboBoxdurum.Name = "comboBoxdurum";
            this.comboBoxdurum.Size = new System.Drawing.Size(100, 21);
            this.comboBoxdurum.TabIndex = 9;
            // 
            // buttonyenikayit
            // 
            this.buttonyenikayit.Location = new System.Drawing.Point(413, 417);
            this.buttonyenikayit.Name = "buttonyenikayit";
            this.buttonyenikayit.Size = new System.Drawing.Size(75, 23);
            this.buttonyenikayit.TabIndex = 10;
            this.buttonyenikayit.Text = "Yeni Kayit";
            this.buttonyenikayit.UseVisualStyleBackColor = true;
            this.buttonyenikayit.Click += new System.EventHandler(this.buttonyenikayit_Click);
            // 
            // YeniKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 519);
            this.Controls.Add(this.buttonyenikayit);
            this.Controls.Add(this.comboBoxdurum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxonem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxaciklama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxkisaaciklama);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxbaslik);
            this.Controls.Add(this.label1);
            this.Name = "YeniKayit";
            this.Text = "TODO-YeniKayit";
            this.Load += new System.EventHandler(this.YeniKayit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxbaslik;
        private System.Windows.Forms.TextBox textBoxkisaaciklama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxaciklama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxonem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxdurum;
        private System.Windows.Forms.Button buttonyenikayit;
    }
}