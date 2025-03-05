namespace TP3ANAN
{
    public partial class Form1 : Form
    {
        string hasilString = "";
        int hasilint = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)// button angka1
        {
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)// button angka2
        {
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)// button angka3
        {
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)// button angka4
        {
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)// button angka5
        {
            textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)// button angka6
        {
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)// button angka7
        {
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)// button angka8
        {
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)// button angka9
        {
            textBox1.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)// button angka+
        {
            hasilint += Convert.ToInt16(textBox1.Text);// menkorversi dari textBox yang berupa string ke int
            textBox1.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)// button angka0
        {
            textBox1.Text += "0";
        }

        private void button11_Click(object sender, EventArgs e)// button angka=
        {
            hasilint += Convert.ToInt16(textBox1.Text);
            textBox1.Text = hasilint.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
