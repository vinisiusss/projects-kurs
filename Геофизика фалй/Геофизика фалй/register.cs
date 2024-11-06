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
    public partial class register : Form
    {
        DataBase database = new DataBase();
        public register()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            var login = textBox1.Text;
            var password = textBox2.Text;

            string querystring = $"insert into register (login_user, password_user) values('{login}', '{password}')";

            SqlCommand command = new SqlCommand(querystring, database.getConnection());

            database.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт создан");
                Form1 frm1 = new Form1();
                this.Hide();
                frm1.ShowDialog();
            }
            else
            {
                MessageBox.Show("gg");
            }
            database.closeConnection();
        }

        

        private void register_Load(object sender, EventArgs e)
        {
            textBox1.MaxLength = 50;
            textBox2.MaxLength = 50;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            this.Hide();
            frm1.ShowDialog();
        }
    }
}
