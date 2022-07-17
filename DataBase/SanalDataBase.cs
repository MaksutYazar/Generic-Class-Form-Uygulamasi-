using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TODOLİST.Entities;

namespace TODOLİST.DataBase
{
    public static class SanalDataBase
    {
        public static List<Kullanici> kullaniciTablo;
        public static List<ToDo> toDoTablo;
        static SanalDataBase()
        {
            kullaniciTablo = new List<Kullanici>();
            kullaniciTablo.Add(new Kullanici
            {
                id = Guid.NewGuid(),
                KullaniciAdi="Test1",
                sifre="1"

            });
            kullaniciTablo.Add(new Kullanici()
            {
                id = Guid.NewGuid(),
                KullaniciAdi = "ömer",
                sifre = "1"
            });
            toDoTablo = new List<ToDo>();
        }


    }
}
