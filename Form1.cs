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

namespace TODOLİST
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Tick += Tm_zamanla_Tick;
            timer1.Start();

            ButtonAcKapa(false);
            SisetmGiris kullanicikontrol = new SisetmGiris();
            kullanicikontrol.MdiParent = this;
            kullanicikontrol.StartPosition = FormStartPosition.CenterScreen;
            kullanicikontrol.Show();

        }

        private void ButtonAcKapa(bool kontrol)
        {
            foreach (Control item in groupBoxislem.Controls)
            {
                if (item is Button)
                {
                    item.Enabled = kontrol;

                }
            }
        }

        private void Tm_zamanla_Tick(object sender, EventArgs e)
        {
            labelzaman.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm");
        }
        Form T;
        private void buttonyrnikayit_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["YeniKayit"]!=null)
            {
                T = Application.OpenForms["YeniKayit"];
                T.Focus();
            }
            else
            {
                T = new YeniKayit();
                T.MdiParent = this;
                T.Show(); 
            }


            
        }

        private void buttonuygulamayıkapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonkayitliste_Click(object sender, EventArgs e)
        {
            ToDoServices todoservis = new ToDoServices();
            if (todoservis.kayitkontrol()>0)
            {
                KayitListe kayitlistesi = new KayitListe();
                kayitlistesi.MdiParent = this;
                kayitlistesi.Show();
                if (Application.OpenForms["KayitListe"] != null)
                {
                    T = Application.OpenForms["KayitListe"];
                    T.Focus();
                }
                else
                {
                    KayitListe kayitlistesii = new KayitListe();
                    kayitlistesii.MdiParent = this;
                    kayitlistesii.Show();
                }
            }
            else
            {
                MessageBox.Show("Listelenecek kayıt bulunamadı","bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
    }
}
