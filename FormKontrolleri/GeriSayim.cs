using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormKontrolleri
{
    public partial class GeriSayim : Form
    {
        public GeriSayim()
        {
            InitializeComponent();
        }

        int sayac = 0;
        private void Button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) && textBox1.Text != "0")
            {
                sayac = Convert.ToInt32(textBox1.Text);
                timer1.Start();
            }
            else
            {
                MessageBox.Show("Değer giriniz.");
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            sayac--;
            textBox1.Text = sayac.ToString();
            if (sayac <=0)
            {
                timer1.Stop();
                textBox1.Text = "Bitti";
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
