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

        public static double LightenAmount { get; set; }
        public static double DarkenAmount { get; set; }



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

        private void BtnLighten_Click(object sender, EventArgs e)
        {
            Bitmap bitmapCopy = new Bitmap((Bitmap)pictureBoxOriginal.Image);

            Processing.LightenImage(bitmapCopy);
            this.pictureBoxResult.Image = bitmapCopy;
        }

        private void comboBoxLighten_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxLighten.Text == "")
            {
                return;
            }

            LightenAmount = double.Parse(comboBoxLighten.Text);

            
        }

        private void BtnDarken_Click(object sender, EventArgs e)
        {
            Bitmap bitmapCopy = new Bitmap((Bitmap)pictureBoxOriginal.Image);

            Processing.DarkenImage(bitmapCopy);
            this.pictureBoxResult.Image = bitmapCopy;
        }

        private void comboBoxDarken_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxDarken.Text == "")
            {
                return;
            }

            DarkenAmount = double.Parse(comboBoxDarken.Text);
        }

        private void BtnNegative_Click(object sender, EventArgs e)
        {
            Bitmap copy = new Bitmap((Bitmap)this.pictureBoxOriginal.Image);
            Processing.ConvertToNegative(copy);
            this.pictureBoxResult.Image = copy;
        }

        private void BtnBlur_Click(object sender, EventArgs e)
        {
            Bitmap copy = new Bitmap((Bitmap)this.pictureBoxOriginal.Image);
            Processing.Blur(copy);
            this.pictureBoxResult.Image = copy;
        }
    }
   
}
