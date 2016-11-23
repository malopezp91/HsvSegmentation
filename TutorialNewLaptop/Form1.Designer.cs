namespace TutorialNewLaptop
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnStart = new System.Windows.Forms.Button();
            this.frameCamera = new Emgu.CV.UI.ImageBox();
            this.frameBinarized = new Emgu.CV.UI.ImageBox();
            this.frameWithCentroid = new Emgu.CV.UI.ImageBox();
            this.lowHue = new System.Windows.Forms.TrackBar();
            this.highHue = new System.Windows.Forms.TrackBar();
            this.lowSat = new System.Windows.Forms.TrackBar();
            this.highSat = new System.Windows.Forms.TrackBar();
            this.lowValue = new System.Windows.Forms.TrackBar();
            this.highValue = new System.Windows.Forms.TrackBar();
            this.txtBxX = new System.Windows.Forms.TextBox();
            this.txtBxY = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBxHueLow = new System.Windows.Forms.TextBox();
            this.txtBxSatLow = new System.Windows.Forms.TextBox();
            this.txtBxValueLow = new System.Windows.Forms.TextBox();
            this.txtBxValueHigh = new System.Windows.Forms.TextBox();
            this.txtBxSatHigh = new System.Windows.Forms.TextBox();
            this.txtBxHueHigh = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.frameCamera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frameBinarized)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frameWithCentroid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowHue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.highHue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowSat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.highSat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.highValue)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(729, 458);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(174, 36);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // frameCamera
            // 
            this.frameCamera.Location = new System.Drawing.Point(53, 61);
            this.frameCamera.Name = "frameCamera";
            this.frameCamera.Size = new System.Drawing.Size(320, 240);
            this.frameCamera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.frameCamera.TabIndex = 2;
            this.frameCamera.TabStop = false;
            // 
            // frameBinarized
            // 
            this.frameBinarized.Location = new System.Drawing.Point(442, 61);
            this.frameBinarized.Name = "frameBinarized";
            this.frameBinarized.Size = new System.Drawing.Size(320, 240);
            this.frameBinarized.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.frameBinarized.TabIndex = 3;
            this.frameBinarized.TabStop = false;
            // 
            // frameWithCentroid
            // 
            this.frameWithCentroid.Location = new System.Drawing.Point(839, 61);
            this.frameWithCentroid.Name = "frameWithCentroid";
            this.frameWithCentroid.Size = new System.Drawing.Size(320, 240);
            this.frameWithCentroid.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.frameWithCentroid.TabIndex = 4;
            this.frameWithCentroid.TabStop = false;
            // 
            // lowHue
            // 
            this.lowHue.Location = new System.Drawing.Point(193, 360);
            this.lowHue.Maximum = 180;
            this.lowHue.Name = "lowHue";
            this.lowHue.Size = new System.Drawing.Size(104, 56);
            this.lowHue.TabIndex = 5;
            this.lowHue.Scroll += new System.EventHandler(this.lowHue_Scroll);
            // 
            // highHue
            // 
            this.highHue.Location = new System.Drawing.Point(432, 360);
            this.highHue.Maximum = 360;
            this.highHue.Name = "highHue";
            this.highHue.Size = new System.Drawing.Size(104, 56);
            this.highHue.TabIndex = 6;
            this.highHue.Value = 360;
            this.highHue.Scroll += new System.EventHandler(this.highHue_Scroll);
            // 
            // lowSat
            // 
            this.lowSat.Location = new System.Drawing.Point(193, 421);
            this.lowSat.Maximum = 360;
            this.lowSat.Name = "lowSat";
            this.lowSat.Size = new System.Drawing.Size(104, 56);
            this.lowSat.TabIndex = 7;
            this.lowSat.Scroll += new System.EventHandler(this.lowSat_Scroll);
            // 
            // highSat
            // 
            this.highSat.Location = new System.Drawing.Point(432, 421);
            this.highSat.Maximum = 360;
            this.highSat.Name = "highSat";
            this.highSat.Size = new System.Drawing.Size(104, 56);
            this.highSat.TabIndex = 8;
            this.highSat.Value = 360;
            this.highSat.Scroll += new System.EventHandler(this.highSat_Scroll);
            // 
            // lowValue
            // 
            this.lowValue.Location = new System.Drawing.Point(193, 490);
            this.lowValue.Maximum = 360;
            this.lowValue.Name = "lowValue";
            this.lowValue.Size = new System.Drawing.Size(104, 56);
            this.lowValue.TabIndex = 9;
            this.lowValue.Scroll += new System.EventHandler(this.lowValue_Scroll);
            // 
            // highValue
            // 
            this.highValue.Location = new System.Drawing.Point(432, 490);
            this.highValue.Maximum = 360;
            this.highValue.Name = "highValue";
            this.highValue.Size = new System.Drawing.Size(104, 56);
            this.highValue.TabIndex = 10;
            this.highValue.Value = 360;
            this.highValue.Scroll += new System.EventHandler(this.highValue_Scroll);
            // 
            // txtBxX
            // 
            this.txtBxX.Location = new System.Drawing.Point(844, 377);
            this.txtBxX.Name = "txtBxX";
            this.txtBxX.Size = new System.Drawing.Size(60, 22);
            this.txtBxX.TabIndex = 11;
            this.txtBxX.Text = "0";
            // 
            // txtBxY
            // 
            this.txtBxY.Location = new System.Drawing.Point(938, 377);
            this.txtBxY.Name = "txtBxY";
            this.txtBxY.Size = new System.Drawing.Size(60, 22);
            this.txtBxY.TabIndex = 12;
            this.txtBxY.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 380);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Hue";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 434);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Saturation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 503);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Value";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(208, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Low Limit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(450, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "High Limit";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(726, 382);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Centroid";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(866, 351);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "X";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(960, 351);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "Y";
            // 
            // txtBxHueLow
            // 
            this.txtBxHueLow.Location = new System.Drawing.Point(313, 377);
            this.txtBxHueLow.Name = "txtBxHueLow";
            this.txtBxHueLow.Size = new System.Drawing.Size(60, 22);
            this.txtBxHueLow.TabIndex = 21;
            this.txtBxHueLow.Text = "0";
            // 
            // txtBxSatLow
            // 
            this.txtBxSatLow.Location = new System.Drawing.Point(313, 438);
            this.txtBxSatLow.Name = "txtBxSatLow";
            this.txtBxSatLow.Size = new System.Drawing.Size(60, 22);
            this.txtBxSatLow.TabIndex = 22;
            this.txtBxSatLow.Text = "0";
            // 
            // txtBxValueLow
            // 
            this.txtBxValueLow.Location = new System.Drawing.Point(313, 507);
            this.txtBxValueLow.Name = "txtBxValueLow";
            this.txtBxValueLow.Size = new System.Drawing.Size(60, 22);
            this.txtBxValueLow.TabIndex = 23;
            this.txtBxValueLow.Text = "0";
            // 
            // txtBxValueHigh
            // 
            this.txtBxValueHigh.Location = new System.Drawing.Point(557, 507);
            this.txtBxValueHigh.Name = "txtBxValueHigh";
            this.txtBxValueHigh.Size = new System.Drawing.Size(60, 22);
            this.txtBxValueHigh.TabIndex = 26;
            this.txtBxValueHigh.Text = "360";
            // 
            // txtBxSatHigh
            // 
            this.txtBxSatHigh.Location = new System.Drawing.Point(557, 438);
            this.txtBxSatHigh.Name = "txtBxSatHigh";
            this.txtBxSatHigh.Size = new System.Drawing.Size(60, 22);
            this.txtBxSatHigh.TabIndex = 25;
            this.txtBxSatHigh.Text = "360";
            // 
            // txtBxHueHigh
            // 
            this.txtBxHueHigh.Location = new System.Drawing.Point(557, 377);
            this.txtBxHueHigh.Name = "txtBxHueHigh";
            this.txtBxHueHigh.Size = new System.Drawing.Size(60, 22);
            this.txtBxHueHigh.TabIndex = 24;
            this.txtBxHueHigh.Text = "360";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(143, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 25);
            this.label9.TabIndex = 27;
            this.label9.Text = "Original Frame";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(525, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(154, 25);
            this.label10.TabIndex = 28;
            this.label10.Text = "Binarized Frame";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(867, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(264, 25);
            this.label11.TabIndex = 29;
            this.label11.Text = "Original Frame With Centroid";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 578);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtBxValueHigh);
            this.Controls.Add(this.txtBxSatHigh);
            this.Controls.Add(this.txtBxHueHigh);
            this.Controls.Add(this.txtBxValueLow);
            this.Controls.Add(this.txtBxSatLow);
            this.Controls.Add(this.txtBxHueLow);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBxY);
            this.Controls.Add(this.txtBxX);
            this.Controls.Add(this.highValue);
            this.Controls.Add(this.lowValue);
            this.Controls.Add(this.highSat);
            this.Controls.Add(this.lowSat);
            this.Controls.Add(this.highHue);
            this.Controls.Add(this.lowHue);
            this.Controls.Add(this.frameWithCentroid);
            this.Controls.Add(this.frameBinarized);
            this.Controls.Add(this.frameCamera);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "HSV Segmentation";
            ((System.ComponentModel.ISupportInitialize)(this.frameCamera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frameBinarized)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frameWithCentroid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowHue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.highHue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowSat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.highSat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.highValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private Emgu.CV.UI.ImageBox frameCamera;
        private Emgu.CV.UI.ImageBox frameBinarized;
        private Emgu.CV.UI.ImageBox frameWithCentroid;
        private System.Windows.Forms.TrackBar lowHue;
        private System.Windows.Forms.TrackBar highHue;
        private System.Windows.Forms.TrackBar lowSat;
        private System.Windows.Forms.TrackBar highSat;
        private System.Windows.Forms.TrackBar lowValue;
        private System.Windows.Forms.TrackBar highValue;
        private System.Windows.Forms.TextBox txtBxX;
        private System.Windows.Forms.TextBox txtBxY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBxHueLow;
        private System.Windows.Forms.TextBox txtBxSatLow;
        private System.Windows.Forms.TextBox txtBxValueLow;
        private System.Windows.Forms.TextBox txtBxValueHigh;
        private System.Windows.Forms.TextBox txtBxSatHigh;
        private System.Windows.Forms.TextBox txtBxHueHigh;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}

