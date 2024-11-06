using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Геофизика_фалй
{
    public partial class @operator : Form
    {
        public @operator()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void operator_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "registerDataSet8._operator". При необходимости она может быть перемещена или удалена.
            this.operatorTableAdapter.Fill(this.registerDataSet8._operator);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "registerDataSet7.agrigade". При необходимости она может быть перемещена или удалена.
            this.agrigadeTableAdapter.Fill(this.registerDataSet7.agrigade);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            this.Hide();
            frm2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            deleteopercs deleteoper = new deleteopercs();
            this.Hide();
            deleteoper.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            appoper appop = new appoper();
            this.Hide();
            appop.ShowDialog();
        }
    }
}
