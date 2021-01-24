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
    public partial class TimerKontrolü : Form
    {
        int sayac = 0;
        public TimerKontrolü()
        {
            InitializeComponent();
            lbl_ekran.Text = DateTime.Now.ToLongTimeString();
        }

        private void Btn_basla_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Btn_dur_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            //sayac++;
            //lbl_ekran.Text = sayac.ToString();
            //lbl_ekran.Text = DateTime.Now.ToLongTimeString();

        }
    }
}
