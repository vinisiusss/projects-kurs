using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace main
{
    public partial class Form2 : Form
    {
        Form1 frm1;
        public Form2(Form1 frm)
        {
            InitializeComponent();
            this.frm1 = frm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm1.dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
