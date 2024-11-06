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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Геофизика_фалй
{
    public partial class newprojects : Form
    {
        DataBase database = new DataBase();
        public newprojects()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            this.Hide();
            frm2.ShowDialog();
        }

        private void newprojects_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var name = textBox1.Text;
            var zakaz = textBox2.Text;
            var daten = textBox3.Text;
            var pl = textBox4.Text;
            var cor = textBox5.Text;
            var gl = textBox6.Text;
            var kol = textBox7.Text;
            var idap = textBox8.Text;
            var idop = textBox9.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string querystring = $"  INSERT INTO projecct (name_project, Заказчик, Дата_начала, Площадь,КоординатыТочекИзлома, ГлубинаИзмерения,КоличествоПикетов,id_Аппаратуры,id_Оператора)  \r\n  VALUES ('{name}', '{zakaz}', '{daten}', '{pl}', '{cor}', {gl}, {kol} , {idap},{idop})";
            SqlCommand command = new SqlCommand(querystring, database.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);
            MessageBox.Show("Проект добавлен");

            projeccts frmpr = new projeccts();
            this.Hide();
            frmpr.ShowDialog();

        }
    }
}
