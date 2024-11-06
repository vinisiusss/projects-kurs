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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Геофизика_фалй
{
    public partial class Form3 : Form
    {
        DataBase database = new DataBase();
        public Form3()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            agrigade agr = new agrigade();
            this.Hide();
            agr.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var id = textBox1.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string querystring = $"delete from agrigade\r\nwhere id = '{id}'";
            SqlCommand command = new SqlCommand(querystring, database.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);
            MessageBox.Show("Оборудование удалено");

            agrigade agr = new agrigade();
            this.Hide();
            agr.ShowDialog();
        }
    }
}
