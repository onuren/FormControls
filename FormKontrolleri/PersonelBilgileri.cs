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
    public partial class PersonelBilgileri : Form
    {
        public PersonelBilgileri()
        {
            InitializeComponent();
        }

        private void Btn_kaydet_Click(object sender, EventArgs e)
        {
            List<string> bilgiler = new List<string>();
            bilgiler.Add(tb_ad.Text);
            bilgiler.Add(tb_soyad.Text);
            bilgiler.Add(tb_email.Text);
            bilgiler.Add(tb_telefon.Text);
            bilgiler.Add(tb_yas.Text);
            if (rb_erkek.Checked)
            {
                bilgiler.Add("Erkek");
            }
            else
            {
                bilgiler.Add("Kadın");
            }
            if (rb_bekar.Checked)
            {
                bilgiler.Add("Bekar");
            }
            else
            {
                bilgiler.Add("Evli");
            }
            listBox1.DataSource = bilgiler;
        }
    }
}
