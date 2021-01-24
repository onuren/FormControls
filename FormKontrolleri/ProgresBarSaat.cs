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
    public partial class ProgresBarSaat : Form
    {
        public ProgresBarSaat()
        {
            InitializeComponent();
            timer1.Start();
            progressBar1.Value = DateTime.Now.Hour;
            progressBar2.Value = DateTime.Now.Minute;
            progressBar3.Value = DateTime.Now.Second;
            progressBar4.Value = DateTime.Now.Millisecond;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = DateTime.Now.Hour;
            progressBar2.Value = DateTime.Now.Minute;
            progressBar3.Value = DateTime.Now.Second;
            progressBar4.Value = DateTime.Now.Millisecond;
            label1.Text = Convert.ToString(progressBar1.Value);
            label2.Text = Convert.ToString(progressBar2.Value);
            label3.Text = Convert.ToString(progressBar3.Value);
            label4.Text = Convert.ToString(progressBar4.Value);
        }
    }
}
