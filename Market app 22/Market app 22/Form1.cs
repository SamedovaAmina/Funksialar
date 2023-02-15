using System.Windows.Forms;

namespace Market_app_22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {

                button1.BackColor = colorDialog1.Color;
            }
            else
            {
                MessageBox.Show("Deyismedi");
            }
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            string hobby = textBox1.Text;
            listBox1.Items.Add(hobby);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ad = textBox1.Text;
            string[] massiv = new string[1];
            massiv[0] = ad;
            listView1.Items.Add(ad);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.Red;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.BackColor = Color.Orange;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.BackColor = Color.Green;
        }
    }
}