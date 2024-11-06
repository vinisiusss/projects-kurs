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
    public partial class projects : Form
    {
        public projects()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void projects_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "registerDataSet11.projecct". При необходимости она может быть перемещена или удалена.
            this.projecctTableAdapter1.Fill(this.registerDataSet11.projecct);

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

        }
    }
}
