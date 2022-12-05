namespace ImageProcessTest
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbSrcImage = new System.Windows.Forms.PictureBox();
            this.pbProcImage = new System.Windows.Forms.PictureBox();
            this.btnLoadImg = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbSobel = new System.Windows.Forms.TrackBar();
            this.radioSobelXY = new System.Windows.Forms.RadioButton();
            this.radioSobelY = new System.Windows.Forms.RadioButton();
            this.radioSobelX = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pbColor = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSobelY = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSobelX = new System.Windows.Forms.TrackBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbHueInvert = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.tbHueBlue = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.tbHueGreen = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.tbHueRed = new System.Windows.Forms.TrackBar();
            this.btnSaveImage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbSrcImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProcImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSobel)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSobelY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSobelX)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbHueInvert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbHueBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbHueGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbHueRed)).BeginInit();
            this.SuspendLayout();
            // 
            // pbSrcImage
            // 
            this.pbSrcImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbSrcImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbSrcImage.Location = new System.Drawing.Point(0, 0);
            this.pbSrcImage.Name = "pbSrcImage";
            this.pbSrcImage.Size = new System.Drawing.Size(367, 305);
            this.pbSrcImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSrcImage.TabIndex = 0;
            this.pbSrcImage.TabStop = false;
            // 
            // pbProcImage
            // 
            this.pbProcImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbProcImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbProcImage.Location = new System.Drawing.Point(0, 0);
            this.pbProcImage.Name = "pbProcImage";
            this.pbProcImage.Size = new System.Drawing.Size(366, 305);
            this.pbProcImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbProcImage.TabIndex = 1;
            this.pbProcImage.TabStop = false;
            // 
            // btnLoadImg
            // 
            this.btnLoadImg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLoadImg.Location = new System.Drawing.Point(12, 323);
            this.btnLoadImg.Name = "btnLoadImg";
            this.btnLoadImg.Size = new System.Drawing.Size(87, 23);
            this.btnLoadImg.TabIndex = 2;
            this.btnLoadImg.Text = "Load Image";
            this.btnLoadImg.UseVisualStyleBackColor = true;
            this.btnLoadImg.Click += new System.EventHandler(this.btnLoadImg_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pbSrcImage);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pbProcImage);
            this.splitContainer1.Size = new System.Drawing.Size(737, 305);
            this.splitContainer1.SplitterDistance = 367;
            this.splitContainer1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tbSobel);
            this.groupBox1.Controls.Add(this.radioSobelXY);
            this.groupBox1.Controls.Add(this.radioSobelY);
            this.groupBox1.Controls.Add(this.radioSobelX);
            this.groupBox1.Location = new System.Drawing.Point(626, 323);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(123, 149);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sobel Generation";
            // 
            // tbSobel
            // 
            this.tbSobel.Location = new System.Drawing.Point(6, 97);
            this.tbSobel.Maximum = 15;
            this.tbSobel.Minimum = 1;
            this.tbSobel.Name = "tbSobel";
            this.tbSobel.Size = new System.Drawing.Size(104, 45);
            this.tbSobel.TabIndex = 3;
            this.tbSobel.Value = 1;
            this.tbSobel.Scroll += new System.EventHandler(this.TrackbarUpdate);
            // 
            // radioSobelXY
            // 
            this.radioSobelXY.AutoSize = true;
            this.radioSobelXY.Location = new System.Drawing.Point(6, 72);
            this.radioSobelXY.Name = "radioSobelXY";
            this.radioSobelXY.Size = new System.Drawing.Size(47, 19);
            this.radioSobelXY.TabIndex = 2;
            this.radioSobelXY.Text = "X+Y";
            this.radioSobelXY.UseVisualStyleBackColor = true;
            this.radioSobelXY.CheckedChanged += new System.EventHandler(this.radioSobelXY_CheckedChanged);
            // 
            // radioSobelY
            // 
            this.radioSobelY.AutoSize = true;
            this.radioSobelY.Location = new System.Drawing.Point(6, 47);
            this.radioSobelY.Name = "radioSobelY";
            this.radioSobelY.Size = new System.Drawing.Size(32, 19);
            this.radioSobelY.TabIndex = 1;
            this.radioSobelY.Text = "Y";
            this.radioSobelY.UseVisualStyleBackColor = true;
            this.radioSobelY.CheckedChanged += new System.EventHandler(this.radioSobelY_CheckedChanged);
            // 
            // radioSobelX
            // 
            this.radioSobelX.AutoSize = true;
            this.radioSobelX.Checked = true;
            this.radioSobelX.Location = new System.Drawing.Point(6, 22);
            this.radioSobelX.Name = "radioSobelX";
            this.radioSobelX.Size = new System.Drawing.Size(32, 19);
            this.radioSobelX.TabIndex = 0;
            this.radioSobelX.TabStop = true;
            this.radioSobelX.Text = "X";
            this.radioSobelX.UseVisualStyleBackColor = true;
            this.radioSobelX.CheckedChanged += new System.EventHandler(this.radioSobelX_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.pbColor);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbSobelY);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tbSobelX);
            this.groupBox2.Location = new System.Drawing.Point(408, 323);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(212, 149);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sobel Overlay";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Color";
            // 
            // pbColor
            // 
            this.pbColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbColor.Location = new System.Drawing.Point(58, 111);
            this.pbColor.Name = "pbColor";
            this.pbColor.Size = new System.Drawing.Size(28, 28);
            this.pbColor.TabIndex = 8;
            this.pbColor.TabStop = false;
            this.pbColor.Click += new System.EventHandler(this.pbColor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Y Offset";
            // 
            // tbSobelY
            // 
            this.tbSobelY.Location = new System.Drawing.Point(58, 72);
            this.tbSobelY.Maximum = 20;
            this.tbSobelY.Minimum = -20;
            this.tbSobelY.Name = "tbSobelY";
            this.tbSobelY.Size = new System.Drawing.Size(148, 45);
            this.tbSobelY.TabIndex = 6;
            this.tbSobelY.Value = 1;
            this.tbSobelY.Scroll += new System.EventHandler(this.TrackbarUpdate);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "X Offset";
            // 
            // tbSobelX
            // 
            this.tbSobelX.Location = new System.Drawing.Point(58, 21);
            this.tbSobelX.Maximum = 20;
            this.tbSobelX.Minimum = -20;
            this.tbSobelX.Name = "tbSobelX";
            this.tbSobelX.Size = new System.Drawing.Size(148, 45);
            this.tbSobelX.TabIndex = 4;
            this.tbSobelX.Value = 1;
            this.tbSobelX.Scroll += new System.EventHandler(this.TrackbarUpdate);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.tbHueInvert);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.tbHueBlue);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.tbHueGreen);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.tbHueRed);
            this.groupBox3.Location = new System.Drawing.Point(203, 323);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(199, 225);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Color Shift";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Invert";
            // 
            // tbHueInvert
            // 
            this.tbHueInvert.Location = new System.Drawing.Point(50, 174);
            this.tbHueInvert.Maximum = 255;
            this.tbHueInvert.Name = "tbHueInvert";
            this.tbHueInvert.Size = new System.Drawing.Size(143, 45);
            this.tbHueInvert.TabIndex = 12;
            this.tbHueInvert.Scroll += new System.EventHandler(this.TrackbarUpdate);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Blue";
            // 
            // tbHueBlue
            // 
            this.tbHueBlue.Location = new System.Drawing.Point(50, 123);
            this.tbHueBlue.Maximum = 511;
            this.tbHueBlue.Name = "tbHueBlue";
            this.tbHueBlue.Size = new System.Drawing.Size(143, 45);
            this.tbHueBlue.TabIndex = 10;
            this.tbHueBlue.Value = 255;
            this.tbHueBlue.Scroll += new System.EventHandler(this.TrackbarUpdate);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Green";
            // 
            // tbHueGreen
            // 
            this.tbHueGreen.Location = new System.Drawing.Point(50, 72);
            this.tbHueGreen.Maximum = 511;
            this.tbHueGreen.Name = "tbHueGreen";
            this.tbHueGreen.Size = new System.Drawing.Size(143, 45);
            this.tbHueGreen.TabIndex = 8;
            this.tbHueGreen.Value = 255;
            this.tbHueGreen.Scroll += new System.EventHandler(this.TrackbarUpdate);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Red";
            // 
            // tbHueRed
            // 
            this.tbHueRed.Location = new System.Drawing.Point(50, 22);
            this.tbHueRed.Maximum = 511;
            this.tbHueRed.Name = "tbHueRed";
            this.tbHueRed.Size = new System.Drawing.Size(143, 45);
            this.tbHueRed.TabIndex = 6;
            this.tbHueRed.Value = 255;
            this.tbHueRed.Scroll += new System.EventHandler(this.TrackbarUpdate);
            // 
            // btnSaveImage
            // 
            this.btnSaveImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSaveImage.Location = new System.Drawing.Point(12, 352);
            this.btnSaveImage.Name = "btnSaveImage";
            this.btnSaveImage.Size = new System.Drawing.Size(87, 23);
            this.btnSaveImage.TabIndex = 7;
            this.btnSaveImage.Text = "Save Image";
            this.btnSaveImage.UseVisualStyleBackColor = true;
            this.btnSaveImage.Click += new System.EventHandler(this.btnSaveImage_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 560);
            this.Controls.Add(this.btnSaveImage);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.btnLoadImg);
            this.Name = "MainForm";
            this.Text = "Image Processing Test";
            ((System.ComponentModel.ISupportInitialize)(this.pbSrcImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProcImage)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSobel)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSobelY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSobelX)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbHueInvert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbHueBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbHueGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbHueRed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pbSrcImage;
        private PictureBox pbProcImage;
        private Button btnLoadImg;
        private SplitContainer splitContainer1;
        private GroupBox groupBox1;
        private RadioButton radioSobelXY;
        private RadioButton radioSobelY;
        private RadioButton radioSobelX;
        private TrackBar tbSobel;
        private GroupBox groupBox2;
        private TrackBar tbSobelX;
        private Label label2;
        private TrackBar tbSobelY;
        private Label label1;
        private Label label3;
        private PictureBox pbColor;
        private GroupBox groupBox3;
        private Label label4;
        private TrackBar tbHueRed;
        private Label label6;
        private TrackBar tbHueBlue;
        private Label label5;
        private TrackBar tbHueGreen;
        private Label label7;
        private TrackBar tbHueInvert;
        private Button btnSaveImage;
    }
}