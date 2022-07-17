using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TODOLİST.DataBase;
using TODOLİST.Entities;

namespace TODOLİST.BusinessService
{
    public class KullaniciService
    {
      

        public Kullanici kullaniciKontrol(string kullaniciadi, string sifre)
        {
            return SanalDataBase.kullaniciTablo.Where(x => x.KullaniciAdi == kullaniciadi && x.sifre == sifre).FirstOrDefault();
            //First default :bulduğu ilk değeri al getir
}
    }
}
