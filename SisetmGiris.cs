using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TODOLİST.BusinessService;
using TODOLİST.Entities;

namespace TODOLİST
{
    public partial class SisetmGiris : Form
    {
        public SisetmGiris()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void SisetmGiris_Enter(object sender, EventArgs e)
        {//Texboxa giriş yaptığında sarı olcak
            //TextBox t =(TextBox)sender;
            //t.BackColor = Color.Yellow;

        }

        private void textBoxkullanici_Leave(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            t.BackColor = Color.White;
        }

        private void textBoxkullanici_Enter(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            t.BackColor = Color.Yellow;

        }

        private void textBoxsifre_Enter(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            t.BackColor = Color.Yellow;

        }

        private void textBoxsifre_Leave(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            t.BackColor = Color.White;

        }

        private void buttongiris_Click(object sender, EventArgs e)
        {
            if (!string .IsNullOrEmpty(textBoxkullanici.Text)&& !string.IsNullOrEmpty(textBoxsifre.Text))
            {
                KullaniciService kullaniciService = new KullaniciService();
                Kullanici kullanici = kullaniciService.kullaniciKontrol(textBoxkullanici.Text, textBoxsifre.Text);

                if (kullanici!=null)
                {
                    Form anaform = Application.OpenForms["Form1"];
                    Panel solpanel = (Panel)anaform.Controls["panel1"];

                    GroupBox grbislemliste = (GroupBox)solpanel.Controls["groupBoxislem"];

                    foreach (Control item in grbislemliste.Controls)
                    {
                        if (item is Button)
                        {
                            item.Enabled = true;
                        }
                    }

                    MessageBox.Show("Merhaba "+kullanici.KullaniciAdi,"Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre","hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen giriş bilgilerinizi eksiksiz giriniz","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void SisetmGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
