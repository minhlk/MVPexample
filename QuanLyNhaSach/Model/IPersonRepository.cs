using QuanLyNhaSach.AppData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.Model
{
    public interface IPersonRepository
    {

        IList<person> getListPerson();
        person getPerson(int id);
        void savePerson(person p);
        void delPerson(int id);
       

    }
}
