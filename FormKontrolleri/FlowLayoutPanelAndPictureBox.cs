using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FormKontrolleri
{
    public partial class FlowLayoutPanelAndPictureBox : Form
    {
        public FlowLayoutPanelAndPictureBox()
        {
            InitializeComponent();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FlowLayoutPanelAndPictureBox_Load(object sender, EventArgs e)
        {
            FlowLayoutDoldur();
            pictureBox1.Image = ((PictureBox)flowLayoutPanel1.Controls[0]).Image;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void FlowLayoutDoldur()
        {
            List<string> resimler = Directory.GetFiles(@"C:\Users\onure\Desktop\Yazılım Kursu 2\FormKontrolleri\FormKontrolleri\Images\").ToList();

            foreach (string item in resimler)
            {
                PictureBox pb = new PictureBox();
                pb.Width = 150;
                pb.Height = 120;
                pb.BorderStyle = BorderStyle.FixedSingle;
                pb.Image = Image.FromFile(item);
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                pb.Click += Pb_Click; //Code1
                flowLayoutPanel1.Controls.Add(pb);
            }
        }

        private void Pb_Click(object sender, EventArgs e)
        {
            //flowlayoutpanel içerisinde üretilen (Code1) her picturebox kontrolünün click event'i budur.
            pictureBox1.Image = ((PictureBox)sender).Image;
        }
    }
}
