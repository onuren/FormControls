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
    public partial class DatetimeVeMonth : Form
    {
        public DatetimeVeMonth()
        {
            InitializeComponent();
        }

        private void Btn_goruntule_Click(object sender, EventArgs e)
        {
            string zaman = dtp_datetime.Value.ToShortDateString();
             
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Btn_takvim_Click(object sender, EventArgs e)
        {
            //lbl_monthtakvim.Text = monthCalendar1.SelectionStart.ToShortDateString() + " - " + monthCalendar1.SelectionEnd.ToShortDateString();
            SelectionRange range = monthCalendar1.SelectionRange;
            DateTime baslangic = range.Start;
            DateTime bitis = range.End;

            lbl_monthtakvim.Text = (bitis - baslangic).TotalDays.ToString();

            //TimeSpan aralik = bitis - baslangic;
            //lbl_monthtakvim.Text = aralik.Days.ToString();

            //DateTime simdi = DateTime.Now;
            //DateTime gecmis = Convert.ToDateTime("12/06/2019 12:10");
            //TimeSpan saataralik = simdi - gecmis;
            //lbl_monthtakvim.Text = saataralik.Days.ToString() + " Gün " + saataralik.Hours.ToString() + " Saat";

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            monthCalendar1.MaxSelectionCount = Convert.ToInt32(comboBox1.Text);
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            monthCalendar1.ShowToday = checkBox1.Checked;
        }

        private void MonthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}
