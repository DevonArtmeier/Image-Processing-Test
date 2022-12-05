namespace ImageProcessTest
{
    public partial class MainForm : Form
    {
        Image srcImage, procImage;
        Sobel.Type sobelType = Sobel.Type.X;
        Color overlayColor = Color.Red;

        public MainForm()
        {
            srcImage = new Image(200, 200);
            procImage = new Image(200, 200);

            InitializeComponent();
            ProcessImage();
        }

        private void ProcessImage()
        {
            Image sobelImage = Sobel.Process(srcImage, sobelType, tbSobel.Value);
            procImage = HueShift.Process(srcImage, tbHueRed.Value / 255.0, tbHueGreen.Value / 255.0, tbHueBlue.Value / 255.0, tbHueInvert.Value / 255.0);
            procImage = SobelOverlay.Process(procImage, sobelImage, tbSobelX.Value, tbSobelY.Value, overlayColor, 1);

            pbProcImage.Image = procImage.ToBitmap();
            pbColor.BackColor = overlayColor;
        }

        private void radioSobelX_CheckedChanged(object sender, EventArgs e)
        {
            sobelType = Sobel.Type.X;
            ProcessImage();
        }

        private void radioSobelY_CheckedChanged(object sender, EventArgs e)
        {
            sobelType = Sobel.Type.Y;
            ProcessImage();
        }

        private void radioSobelXY_CheckedChanged(object sender, EventArgs e)
        {
            sobelType = Sobel.Type.XY;
            ProcessImage();
        }

        private void TrackbarUpdate(object sender, EventArgs e)
        {
            ProcessImage();
        }

        private void pbColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            colorDlg.AnyColor = true;
            colorDlg.SolidColorOnly = true;
            colorDlg.Color = Color.Red;

            if (colorDlg.ShowDialog() == DialogResult.OK)
                overlayColor = colorDlg.Color;
            ProcessImage();
        }

        private void btnSaveImage_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dlg = new SaveFileDialog())
            {
                dlg.Filter = "PNG Image Files|*.png|JPEG Image Files|*.jpg|BMP Image Files|*.bmp|GIF Image Files|*.gif";
                dlg.Title = "Save Image File";
                if (dlg.ShowDialog() == DialogResult.OK)
                    procImage.Save(dlg.FileName);
            }
        }

        private void btnLoadImg_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Filter = "Image Files|*.bmp;*.png;*.jpg;*.gif";
                dlg.Title = "Open Image File";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    srcImage = new Image(dlg.FileName);
                    pbSrcImage.Image = srcImage.ToBitmap();
                    ProcessImage();
                }
            }
        }
    }
}