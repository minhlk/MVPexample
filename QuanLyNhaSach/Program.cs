using QuanLyNhaSach.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaSach
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 v = new Form1();
            IPersonRepository repository = new PersonRepository();
            Presenter.PersonPresenter presenter = new Presenter.PersonPresenter(v,repository);

            Application.Run(v);
        }
    }
}
