namespace TODOLİST
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxislem = new System.Windows.Forms.GroupBox();
            this.buttonyrnikayit = new System.Windows.Forms.Button();
            this.buttonkayitliste = new System.Windows.Forms.Button();
            this.buttonuygulamayıkapat = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelzaman = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.groupBoxislem.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBoxislem);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(172, 520);
            this.panel1.TabIndex = 0;
            // 
            // groupBoxislem
            // 
            this.groupBoxislem.Controls.Add(this.buttonuygulamayıkapat);
            this.groupBoxislem.Controls.Add(this.buttonkayitliste);
            this.groupBoxislem.Controls.Add(this.buttonyrnikayit);
            this.groupBoxislem.Location = new System.Drawing.Point(16, 174);
            this.groupBoxislem.Name = "groupBoxislem";
            this.groupBoxislem.Size = new System.Drawing.Size(128, 220);
            this.groupBoxislem.TabIndex = 1;
            this.groupBoxislem.TabStop = false;
            this.groupBoxislem.Text = "İşlem Listesi";
            // 
            // buttonyrnikayit
            // 
            this.buttonyrnikayit.Location = new System.Drawing.Point(27, 32);
            this.buttonyrnikayit.Name = "buttonyrnikayit";
            this.buttonyrnikayit.Size = new System.Drawing.Size(75, 23);
            this.buttonyrnikayit.TabIndex = 0;
            this.buttonyrnikayit.Text = "Yeni Kayıt";
            this.buttonyrnikayit.UseVisualStyleBackColor = true;
            this.buttonyrnikayit.Click += new System.EventHandler(this.buttonyrnikayit_Click);
            // 
            // buttonkayitliste
            // 
            this.buttonkayitliste.Location = new System.Drawing.Point(27, 91);
            this.buttonkayitliste.Name = "buttonkayitliste";
            this.buttonkayitliste.Size = new System.Drawing.Size(75, 23);
            this.buttonkayitliste.TabIndex = 1;
            this.buttonkayitliste.Text = "Kayıt Liste";
            this.buttonkayitliste.UseVisualStyleBackColor = true;
            this.buttonkayitliste.Click += new System.EventHandler(this.buttonkayitliste_Click);
            // 
            // buttonuygulamayıkapat
            // 
            this.buttonuygulamayıkapat.Location = new System.Drawing.Point(17, 148);
            this.buttonuygulamayıkapat.Name = "buttonuygulamayıkapat";
            this.buttonuygulamayıkapat.Size = new System.Drawing.Size(95, 38);
            this.buttonuygulamayıkapat.TabIndex = 2;
            this.buttonuygulamayıkapat.Text = "Uygulamayı Kapat";
            this.buttonuygulamayıkapat.UseVisualStyleBackColor = true;
            this.buttonuygulamayıkapat.Click += new System.EventHandler(this.buttonuygulamayıkapat_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelzaman);
            this.panel2.Location = new System.Drawing.Point(593, 424);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 76);
            this.panel2.TabIndex = 1;
            // 
            // labelzaman
            // 
            this.labelzaman.AutoSize = true;
            this.labelzaman.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelzaman.Location = new System.Drawing.Point(31, 27);
            this.labelzaman.Name = "labelzaman";
            this.labelzaman.Size = new System.Drawing.Size(182, 25);
            this.labelzaman.TabIndex = 0;
            this.labelzaman.Text = "16/06/2022 09.13";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TODOLİST.Properties.Resources.Checklist_icon;
            this.pictureBox1.Location = new System.Drawing.Point(16, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 146);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(831, 500);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "TODO UYGULAMASI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.groupBoxislem.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBoxislem;
        private System.Windows.Forms.Button buttonuygulamayıkapat;
        private System.Windows.Forms.Button buttonkayitliste;
        private System.Windows.Forms.Button buttonyrnikayit;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelzaman;
    }
}

