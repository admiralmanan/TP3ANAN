namespace TP3ANAN
{
    public partial class Form1 : Form
    {
        string hasilString = ""; // inisialisasi hasil string
        int hasilint = 0; //inisialisasi hasil int
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)// button angka1
        {
            textBox1.Text += "1";//textbox akan terisi angka 1 jika button ditekan
        }

        private void button2_Click(object sender, EventArgs e)// button angka2
        {
            textBox1.Text += "2";//textbox akan terisi angka 2 jika button ditekan
        }

        private void button3_Click(object sender, EventArgs e)// button angka3
        {
            textBox1.Text += "3";//textbox akan terisi angka 3 jika button ditekan
        }

        private void button4_Click(object sender, EventArgs e)// button angka4
        {
            textBox1.Text += "4";//textbox akan terisi angka 4 jika button ditekan
        }

        private void button5_Click(object sender, EventArgs e)// button angka5
        {
            textBox1.Text += "5";//textbox akan terisi angka 5 jika button ditekan
        }

        private void button6_Click(object sender, EventArgs e)// button angka6
        {
            textBox1.Text += "6";//textbox akan terisi angka 6 jika button ditekan
        }

        private void button7_Click(object sender, EventArgs e)// button angka7
        {
            textBox1.Text += "7";//textbox akan terisi angka 7 jika button ditekan
        }

        private void button8_Click(object sender, EventArgs e)// button angka8
        {
            textBox1.Text += "8";//textbox akan terisi angka 8 jika button ditekan
        }

        private void button9_Click(object sender, EventArgs e)// button angka9
        {
            textBox1.Text += "9";//textbox akan terisi angka 9 jika button ditekan
        }

        private void button10_Click(object sender, EventArgs e)// button angka+
        {
            hasilint += Convert.ToInt16(textBox1.Text);// menkorversi dari textBox yang berupa string ke int
            textBox1.Text = ""; // string kosong akan mengisi textbox
        }

        private void button12_Click(object sender, EventArgs e)// button angka0
        {
            textBox1.Text += "0"; //textbox akan terisi angka 0 jika button ditekan
        }

        private void button11_Click(object sender, EventArgs e)// button angka=
        {
            hasilint += Convert.ToInt16(textBox1.Text);// menkorversi dari textBox yang berupa string ke int
            textBox1.Text = hasilint.ToString(); //hasil integer akan mengisi textbox
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
