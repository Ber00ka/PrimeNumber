using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsalSayiÖdev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            label2.Text = "";
            double sayac = 0;
            listBox1.Items.Clear();// Her seferinde listBox temizlensin
            long x = long.Parse(numericUpDown1.Text);
            if (x < 2)
            {
                MessageBox.Show("Asal Sayı Bulunamadı.");
            }
            else
            {
                for (long i = 2; i <= x; i++)
                {
                    long kontrol = 0;
                    for (long j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            kontrol++;
                            break;
                        }
                    }
                    if (kontrol == 0)
                    {
                        listBox1.Items.Add(i);
                        sayac++;
                    }
                }
            }

            label2.Text = "1-" + x + " arası " + sayac + " adet Asal Sayı Bulundu.";
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown1.Maximum = 99999999999;
            numericUpDown1.Minimum = 0;
        }
    }
}
