using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TODOLİST.Entities
{
    public class ToDo
    {
        public Guid id { get; set; }
        [DisplayName("Başlık")]
        public string Baslik { get; set; }
        [DisplayName("Kısa Açıklama")]
        public string KisaAciklama { get; set; }
        [DisplayName("Açıklama")]
        public string Aciklama { get; set; }
        [DisplayName("Onem Derecesi")]
        public int OnemDerece { get; set; }
        [DisplayName("Durum")]
        public string Durum { get; set; }
        [DisplayName("Oluşturma Tarihi")]
        public DateTime OlusturmaTarihi { get; set; }




    }
}
