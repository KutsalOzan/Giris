using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tekrarla
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void geriDönToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Sayi1, Sayi2, Proje, Ortalama;

            Sayi1 = Convert.ToDouble(textBox1.Text);
            Sayi2 = Convert.ToDouble(textBox2.Text);
            Proje = Convert.ToDouble(textBox3.Text);
            Ortalama = (Sayi1 + Sayi2 + Proje) / 3;
            listBox1.Items.Add("Ortalama: " +  Ortalama);

            

            if (Sayi1 > 100 || Sayi2 > 100 || Proje > 100)
            {

               
                listBox1.Items.Add("Ortalama 100'den büyüktür. Hatalı !!!!");
                listBox1.BackColor = Color.Red;
            }

            if (Sayi1 < 0 || Sayi2 < 0 || Proje < 0 )
            {
                listBox1.Items.Add("Ortalama 0'dan küçüktür. Hatalı !!!!");
                listBox1.BackColor = Color.Red;
            }

            if (Ortalama <= 100 && Ortalama >= 75)
            {
                listBox1.Items.Add("Durum: Mükemmel :)");
            }

            if (Ortalama < 75 && Ortalama >= 50)
            {
                listBox1.Items.Add("Durum: İyi");
            }
            if (Ortalama < 50 && Ortalama >= 25)
            {
                listBox1.Items.Add("Durum: Kötü");
            }
            if (Ortalama < 25 && Ortalama >= 0 )
            {
                listBox1.Items.Add("Durum: Çok Kötü :(");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
