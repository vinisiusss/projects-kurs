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
    public partial class appagrigade : Form
    {
        DataBase database = new DataBase();
        public appagrigade()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void appagrigade_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var model = textBox1.Text;
            var number = textBox2.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string querystring = $"INSERT INTO agrigade (модель, серийный_номер)  VALUES ('{model}', '{number}' );";
            SqlCommand command = new SqlCommand(querystring, database.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);
            MessageBox.Show("Оборудование добавлено");




            agrigade agr = new agrigade();
            this.Hide();
            agr.ShowDialog();
        }
    }
}
