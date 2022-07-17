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
    public partial class YeniKayit : Form
    {
        private object ToDoService;
        private DialogResult result;

        public YeniKayit()
        {
            InitializeComponent();
        }

        private void textBoxonem_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxbaslik_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.Yellow;
        }

        private void textBoxbaslik_Leave(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.White;

        }

        private void buttonyenikayit_Click(object sender, EventArgs e)
        {
            ToDoServices todoservis = new ToDoServices();
            int sonuc = todoservis.yeniKayit(new ToDo()
            {
                 id = Guid.NewGuid(),
                Baslik = textBoxbaslik.Text,
                KisaAciklama=textBoxkisaaciklama.Text,
                Aciklama=textBoxaciklama.Text,
                Durum=comboBoxdurum.SelectedItem.ToString(),
                OnemDerece=int.Parse(textBoxonem.Text),
                OlusturmaTarihi=DateTime.Now
            });
            if (sonuc >0)
            {
                MessageBox.Show("Kayıt ekleme işlemi başarılı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = MessageBox.Show("Yeni kayıt ekleme işlemine devam etmek ister misiniz?","Soru",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

                if (result==DialogResult.Yes)
                {
                    foreach (Control item in this.Controls)
                    {
                        if (item is TextBox)
                        {
                            item.Text = string.Empty;
                        }
                    }
                }
                else
                {
                    Form kayitliste = Application.OpenForms["KayitListe"];

                    if (kayitliste==null)
                    {
                        kayitliste = new KayitListe();
                        kayitliste.MdiParent = Application.OpenForms["Form1"];
                        kayitliste.Show();
                        this.Close();
                    }
                   
                        GroupBox liste = (GroupBox)kayitliste.Controls["groupBoxListe"];
                        DataGridView grdlist = (DataGridView)liste.Controls["dataGridView1"];
                        List<ToDo> guncelliste = todoservis.KayitListe();
                        grdlist.DataSource = null;
                        grdlist.DataSource = guncelliste;
                        this.Close();
                    grdlist.Columns["id"].Visible = false;

                    


                }
            }
        }

        private void YeniKayit_Load(object sender, EventArgs e)
        {

        }
    }
}
