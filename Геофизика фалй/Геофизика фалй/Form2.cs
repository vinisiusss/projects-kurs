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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            projeccts frmpr = new projeccts();
            this.Hide();
            frmpr.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            @operator frmoper = new @operator();
            this.Hide();
            frmoper.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            agrigade frmagrigade = new agrigade();
            this.Hide();
            frmagrigade.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            newprojects frmpr = new newprojects();
            this.Hide();
            frmpr.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Создание и отображение окна GraphWindowProfile
            var testGraf = new testGraf();
            testGraf.Show();

            // Закрытие текущего окна
            this.Close();
        }
    }
}
