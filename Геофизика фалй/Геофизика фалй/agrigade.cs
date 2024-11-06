using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Геофизика_фалй
{
    public partial class agrigade : Form
    {
        DataBase database = new DataBase();
        public agrigade()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void agrigade_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "registerDataSet1.agrigade". При необходимости она может быть перемещена или удалена.
            this.agrigadeTableAdapter.Fill(this.registerDataSet1.agrigade);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            this.Hide();
            frm2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            appagrigade appagr = new appagrigade();
            this.Hide();
            appagr.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            this.Hide();
            frm3.ShowDialog();
        }
    }
}
