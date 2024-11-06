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
    public partial class projeccts : Form
    {
        public projeccts()
        {
            InitializeComponent();
        }

        private void projeccts_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "registerDataSet12.projecct". При необходимости она может быть перемещена или удалена.
            this.projecctTableAdapter.Fill(this.registerDataSet12.projecct);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            this.Hide();
            frm2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            newprojects frmpr = new newprojects();
            this.Hide();
            frmpr.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            deleteproject deleteoper = new deleteproject();
            this.Hide();
            deleteoper.ShowDialog();
        }
    }
}
