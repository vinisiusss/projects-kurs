namespace mainform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2(this);
            frm2.Show();
            Hide();
        }

     

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }
    }
}