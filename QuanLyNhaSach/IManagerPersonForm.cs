using QuanLyNhaSach.AppData;
using QuanLyNhaSach.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach
{
    public interface IManagerPersonForm
    {
        person Person { get; set; }
        IList<person> updateListPerson { get; set; }
         Presenter.PersonPresenter Presenter {  set; }
        void Log(string mes);
    }
}
