using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormKontrolleri.Data;

namespace FormKontrolleri
{
    public partial class KontrollerDevam : Form
    {
        public KontrollerDevam()
        {
            InitializeComponent();
        }

        private void Btn_unbound_Click(object sender, EventArgs e)
        {
            int index = cb_unbound.SelectedIndex;
            string selectedtext = cb_unbound.SelectedText;
            string value = (string)cb_unbound.SelectedValue;
            string text = cb_unbound.Text;
            string metin = cb_unbound.GetItemText(cb_unbound.SelectedItem);
            MessageBox.Show($"index = {index}\nselectedvalue = {selectedtext}\nvalue = {value}\ntext = {text}");
        }

        DataModel dm = new DataModel();
        
        private void KontrollerDevam_Load(object sender, EventArgs e)
        {
            cb_unbound.Items.Add("Selam");
            cb_unbound.Items.Insert(1, "Merhaba");
            //cb_unbound.SelectedIndex = 3;
            //cb_unbound.SelectedIndex = cb_unbound.FindStringExact("Selam");
            cb_unbound.SelectedText = "Seçenek 3";
            //cb_unbound.Items.RemoveAt(1);
            //cb_unbound.Items.Remove("Secenek 1");

            cb_databound.ValueMember = "ID";
            cb_databound.DisplayMember = "Isim";
            //cb_databound.DataSource = dm.GetCategories();

        }

        private void Cb_tur_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_deger.Items.Clear();
            if (cb_tur.SelectedItem == "Günler")
            {
                cb_deger.Items.AddRange(new string[] { "Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma" });
            }
            else if (cb_tur.SelectedItem == "Yıllar")
            {
                cb_deger.Items.AddRange(new string[] { "2016", "2017", "2018", "2019", "2020" });
            }
        }

        private void Btn_databound_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cb_databound.SelectedValue.ToString());
        }

        private void Btn_tursec_Click(object sender, EventArgs e)
        {
            if (cb_tur.Text != "")
            {
                MessageBox.Show(cb_tur.GetItemText(cb_tur.SelectedItem) + cb_deger.GetItemText(cb_deger.SelectedItem));
            }
            
        }
    }
}
