using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tesseract;

namespace OCR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOCR_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                var img = new Bitmap(openFileDialog1.FileName);
                var ocr = new TesseractEngine("./tessdata", "tur", EngineMode.Default);
                var page = ocr.Process(img);
                txtSonuc.Text = page.GetText();
              
            }
        }
    }
}
