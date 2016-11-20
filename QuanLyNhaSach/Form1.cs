using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhaSach.Model;
using QuanLyNhaSach.AppData;
using QuanLyNhaSach.Presenter;

namespace QuanLyNhaSach
{
    public partial class Form1 : Form,IManagerPersonForm
    {
        private person _Person=new person();
        public Form1()
        {
            InitializeComponent();
        }

        public person Person
        {
            get
            {
                _Person.firstName = textBox1.Text;
                _Person.lastName = textBox2.Text;
                return _Person;
            }

            set
            {
                _Person = value;
                textBox1.Text = _Person.firstName;
                textBox2.Text = _Person.lastName;
            }
        }

        public PersonPresenter Presenter
        {
            get; set;
        }

        public IList<person> updateListPerson
        {
            get
            {
                
                return (IList<person>)dataGridView1.DataSource;
            }

            set
            {
                dataGridView1.DataSource = value;
                dataGridView1.Columns[0].Visible = false;  //to hide column 1 and 4 ,column that doesn't need
                dataGridView1.Columns[3].Visible = false;
            }
        }

        public int selectedPerson
        {
            get
            {
                int row = dataGridView1.CurrentCell.RowIndex;
                //int col = dataGridView1.CurrentCell.ColumnIndex;
                
                return int.Parse((dataGridView1.Rows[row].Cells[0].Value.ToString()));  //get current row index


            }

          
        }

        public void Log(string mes)
        {
            MessageBox.Show(mes);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Presenter.updateListPerson();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Presenter.addPerson();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Presenter.delPerson();
        }
    }
}
