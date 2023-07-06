using System;
using System.Windows.Forms;

namespace Quiz1_Rastgele_Sifre_Uretme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int a, b;

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            Random rnd = new Random();
            for (int i = 0; i < 12; i++)
            {
                a = rnd.Next(1, 9);
                textBox1.Text += a.ToString();
                b = rnd.Next(1, 6);
                if (b == 1)
                    textBox1.Text += "a";
                else if (b == 2)
                    textBox1.Text += "b";
                else if (b == 3)
                    textBox1.Text += "c";
                else if (b == 4)
                    textBox1.Text += "d";
                else if (b == 5)
                    textBox1.Text += "e";
            }

            a = rnd.Next(1, 9);
            textBox1.Text += a.ToString();
        }
    }
}
