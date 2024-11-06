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
using System.Reflection;

namespace Геофизика_фалй
{
    public partial class appoper : Form
    {

        DataBase database = new DataBase();
        public appoper()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var fio = textBox1.Text;
            var number = textBox2.Text;
            var location = textBox3.Text;
            var age = textBox4.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string querystring = $"INSERT INTO operator (ФИО, Контактный_номер, Адрес, Возраст)  VALUES ('{fio}', '{number}', '{location}', '{age}' )";
            SqlCommand command = new SqlCommand(querystring, database.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);
            MessageBox.Show("Оператор добавлен");




            @operator frmoper = new @operator();
            this.Hide();
            frmoper.ShowDialog();
        }
    }
}
