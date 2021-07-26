using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace QR_Code_Demo_ZXing.NET
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtEncode_TextChanged(object sender, EventArgs e)
        {
            if (txtEncode.Text.Length == 0)
            {
                pictureBox.Image = null;
                return;
            }

            var writer = new BarcodeWriter();
            writer.Format = BarcodeFormat.QR_CODE;
            writer.Options.Width = pictureBox.Width;
            writer.Options.Height = pictureBox.Height;
            writer.Options.Hints.Add(EncodeHintType.CHARACTER_SET, "utf-8");

            var barcode = writer.Write(txtEncode.Text);
            pictureBox.Image = barcode;
        }

        private void btnSaveQR_Click(object sender, EventArgs e)
        {
            using (var sfd = new SaveFileDialog())
            {
                sfd.Filter = "QR Code Output|*.jpg";
                if (sfd.ShowDialog() == DialogResult.OK && sfd.FileName.Length != 0)
                {
                    pictureBox.Image.Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
            }
        }

        private void btnLoadQR_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.Filter = "QR Code Input | *.jpg;*.png;*.jpeg;*.gif";
                if (ofd.ShowDialog() == DialogResult.OK && ofd.FileName.Length != 0)
                {
                    var reader = new BarcodeReader();
                    var bitmap = new Bitmap(ofd.FileName);
                    var result = reader.Decode(bitmap);
                    txtEncode.Text = result.Text;
                }
            }
        }

        private void btnCOPY_Click(object sender, EventArgs e)
        {
            if (pictureBox.Image != null)
            {
                Clipboard.SetImage(pictureBox.Image);
            }
        }
    }
}