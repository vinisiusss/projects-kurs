using System.IO;
namespace main
{
    public partial class Form1 : Form
    {
        Form2 frm2;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2(this);
            frm2.Show();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int ind = dataGridView1.SelectedCells[0].RowIndex;
            dataGridView1.Rows.RemoveAt(ind);
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void îòêðûòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream mystr = null;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((mystr = openFileDialog1.OpenFile()) != null){
                    StreamReader myread = new StreamReader(mystr);
                    string[] str;
                    int num = 0;
                    try
                    {
                        string[] str1 = myread.ReadToEnd().Split('\n');
                        num = str1.Count();
                        dataGridView1.RowCount = num;
                        for(int i = 0; i < num; i++)
                        {
                            str = str1[i].Split(' ');
                            for(int j = 0; j < dataGridView1.ColumnCount; j++)
                            {
                                try
                                {
                                    dataGridView1.Rows[i].Cells[j].Value = str[j];
                                }
                                catch { }
                            }
                        }
                    }
                    catch (Exception ex) {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        myread.Close();
                    }
                }
            }
        }

        private void ñîõðàíèòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream myStream;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    StreamWriter myWritet = new StreamWriter(myStream);
                    try
                    {
                        for(int i =0; i < dataGridView1.RowCount - 1; i++)
                        {
                            for (int j = 0; j < dataGridView1.ColumnCount; j++)
                            {
                                myWritet.Write(dataGridView1.Rows[i].Cells[j].Value.ToString() + " ");

                            }
                            myWritet.WriteLine();
                        }
                    }
                    catch (Exception ex){
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        myWritet.Close();
                    }
                    myStream.Close();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int sum = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Ëåò"].Value != null)
                {
                    sum += Convert.ToInt32(row.Cells["Ëåò"].Value);
                } 
            }
            textBox1.Text = sum.ToString();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            int rowCount = dataGridView1.Rows.Count;
            textBox1.Text = rowCount.ToString();

           
        }
    }
}