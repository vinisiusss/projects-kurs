using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Геофизика_фалй
{
    public partial class deleteproject : Form
    {
        DataBase database = new DataBase();
        public deleteproject()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var id = textBox1.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string querystring = $"delete from projecct where id = '{id}'";
            SqlCommand command = new SqlCommand(querystring, database.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);
            MessageBox.Show("Проект удален");

            projeccts frmoper = new projeccts();
            this.Hide();
            frmoper.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            projeccts frmoper = new projeccts();
            this.Hide();
            frmoper.ShowDialog();
        }
    }
}
