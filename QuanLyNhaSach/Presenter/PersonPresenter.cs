using QuanLyNhaSach.AppData;
using QuanLyNhaSach.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.Presenter
{
    public class PersonPresenter
    {

        IManagerPersonForm view;
        IPersonRepository repository;
        
        public  PersonPresenter(IManagerPersonForm view,IPersonRepository repository)
        {
            this.view=view;
            this.repository = repository;
            view.Presenter = this;
            updateListPerson();
        }
       
        public void updateListPerson() {
            var list = repository.getListPerson();
            if (list != null)
            {
                view.updateListPerson = list;
            }
            else
            {
                view.Log("sai roi");
            }


        }
        public void addPerson( ) {

            person p = new AppData.person();
            p = view.Person;
            repository.savePerson(p);
            view.Log("added successfull");
            updateListPerson();

        }



    }
}
