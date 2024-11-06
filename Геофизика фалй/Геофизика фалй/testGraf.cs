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
    public partial class testGraf : Form
    {
        public testGraf()
        {
            InitializeComponent();
            
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            this.Hide();
            frm2.ShowDialog();
        }

        private void testGraf_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var rnd = new Random();
            double a = rnd.NextDouble() * -10;
            double b = rnd.NextDouble() * 10;
            double h = rnd.NextDouble() * 2;
            double x = rnd.NextDouble() * 10;
            double y = rnd.NextDouble() * 10;
            this.chart1.Series[0].Points.Clear();
            x = a;
            while (x <= b)
            {
                y = Math.Sin(x);
                this.chart1.Series[0].Points.AddXY(x, y);
                x += h;
            }
        }
    }
}
