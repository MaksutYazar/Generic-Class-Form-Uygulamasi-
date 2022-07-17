using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TODOLİST.DataBase;
using TODOLİST.Entities;

namespace TODOLİST.BusinessService
{
    public class ToDoServices
    {
        public int kayitkontrol()
        {
            return SanalDataBase.toDoTablo.Count();
        }
        public List<ToDo> KayitListe()
        {
            return SanalDataBase.toDoTablo;
        }

        public int yeniKayit(ToDo data)
        {
            try
            {
                SanalDataBase.toDoTablo.Add(data);
                return 1;
            }
            catch (Exception)
            {

                return 0;
            }
        }


    }
}
