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
    public partial class Form1 : Form
    {

        DataBase database = new DataBase();

        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.PasswordChar = '*';
            textBox1.MaxLength = 50;
            textBox2.MaxLength = 50;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var login = textBox1.Text;
            var password = textBox2.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"select id_user, login_user, password_user from register where login_user = '{login}' and password_user = '{password}'";

            SqlCommand command = new SqlCommand(querystring, database.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                Form2 frm2 = new Form2();
                this.Hide();
                frm2.ShowDialog();
            }
            else
                MessageBox.Show("Такого аккаунта нет, создайте его" );
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            register frm_register = new register();
            frm_register.Show();
            this.Hide();
        }
    }
}
