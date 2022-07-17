namespace TODOLİST
{
    partial class SisetmGiris
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
            this.textBoxkullanici = new System.Windows.Forms.TextBox();
            this.textBoxsifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttongiris = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(328, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // textBoxkullanici
            // 
            this.textBoxkullanici.Location = new System.Drawing.Point(404, 33);
            this.textBoxkullanici.Name = "textBoxkullanici";
            this.textBoxkullanici.Size = new System.Drawing.Size(100, 20);
            this.textBoxkullanici.TabIndex = 2;
            this.textBoxkullanici.Enter += new System.EventHandler(this.textBoxkullanici_Enter);
            this.textBoxkullanici.Leave += new System.EventHandler(this.textBoxkullanici_Leave);
            // 
            // textBoxsifre
            // 
            this.textBoxsifre.Location = new System.Drawing.Point(404, 84);
            this.textBoxsifre.Name = "textBoxsifre";
            this.textBoxsifre.Size = new System.Drawing.Size(100, 20);
            this.textBoxsifre.TabIndex = 4;
            this.textBoxsifre.Enter += new System.EventHandler(this.textBoxsifre_Enter);
            this.textBoxsifre.Leave += new System.EventHandler(this.textBoxsifre_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(328, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şifre :";
            // 
            // buttongiris
            // 
            this.buttongiris.Location = new System.Drawing.Point(414, 119);
            this.buttongiris.Name = "buttongiris";
            this.buttongiris.Size = new System.Drawing.Size(75, 23);
            this.buttongiris.TabIndex = 5;
            this.buttongiris.Text = "GİRİŞ";
            this.buttongiris.UseVisualStyleBackColor = true;
            this.buttongiris.Click += new System.EventHandler(this.buttongiris_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TODOLİST.Properties.Resources.Places_user_identity_icon;
            this.pictureBox1.Location = new System.Drawing.Point(175, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 136);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // SisetmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 167);
            this.Controls.Add(this.buttongiris);
            this.Controls.Add(this.textBoxsifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxkullanici);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SisetmGiris";
            this.Text = "SisetmGiris";
            this.Load += new System.EventHandler(this.SisetmGiris_Load);
            this.Enter += new System.EventHandler(this.SisetmGiris_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxkullanici;
        private System.Windows.Forms.TextBox textBoxsifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttongiris;
    }
}