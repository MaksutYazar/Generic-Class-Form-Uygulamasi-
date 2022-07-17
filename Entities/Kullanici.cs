using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TODOLİST.Entities
{
    public class Kullanici
    {
        internal object kullaniciTablo;

        public Guid id { get; set; }
        public string KullaniciAdi { get; set; }
        public string sifre { get; set; }
    }
}
