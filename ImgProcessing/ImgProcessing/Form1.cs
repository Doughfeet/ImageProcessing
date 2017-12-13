using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImgProcessing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Image File (*.bmp, *.jpg)|*.bmp;*.jpg";

            if (DialogResult.OK == openFileDialog.ShowDialog())
            {
                this.pictureBoxOriginal.Image = new Bitmap(openFileDialog.FileName);

            }
        }

        private void BtnGray_Click(object sender, EventArgs e)
        {
            Bitmap bitmapCopy = new Bitmap((Bitmap)pictureBoxOriginal.Image);

            Processing.ConvertToGray(bitmapCopy);
            this.pictureBoxResult.Image = bitmapCopy;
        }

        private void BtnLGray_Click(object sender, EventArgs e)
        {
            Bitmap bitmapCopy = new Bitmap((Bitmap)pictureBoxOriginal.Image);

            Processing.ToGrayScaleLuminosity(bitmapCopy);
            this.pictureBoxResult.Image = bitmapCopy;

        }
    }
}
