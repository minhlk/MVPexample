using QuanLyNhaSach.AppData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.Model
{
    class PersonRepository : IPersonRepository
    {
        dbtestEntities entity=new dbtestEntities();

        public void delPerson(int id)
        {
            person p = (from c in entity.people where c.id == id select c).FirstOrDefault();
            if(p!=null)
            entity.people.Remove(p);
            entity.SaveChanges();
        }

        public IList<person> getListPerson()
        {
            return entity.people.ToList();
        }

        public person getPerson(int id)
        {
            return (from c in entity.people where c.id == id select c).FirstOrDefault();
        }

        public void savePerson(person p)
        {
            entity.people.Add(p);
            entity.SaveChanges();
        }
    }
}
