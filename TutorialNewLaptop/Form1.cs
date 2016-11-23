using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.Util;

namespace TutorialNewLaptop
{
    public partial class Form1 : Form
    {
        private Capture capture;
        private bool captureInProgress;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (capture==null)
            {
                try
                {
                    capture = new Capture();
                }
                catch(NullReferenceException excpt)
                {
                    MessageBox.Show(excpt.Message);
                }
            }
            if (capture!= null)
            {
                if(captureInProgress)
                {
                    btnStart.Text = "Start";
                    Application.Idle -= processFrame;
                }
                else
                {
                    btnStart.Text = "Pause";
                    Application.Idle += processFrame;
                
                }
                captureInProgress = !captureInProgress;
            }

        }

        private void processFrame(object sender, EventArgs args)
        {
            Mat imageCaptured = capture.QueryFrame();
            frameCamera.Image = imageCaptured;
            frameBinarized.Image = applyHsvInRangeAndClosureOperation(imageCaptured);
            frameWithCentroid.Image = detectCentroidInFrame(imageCaptured);
        }

        private Image<Gray, Byte> applyHsvInRangeAndClosureOperation(Mat imageCaptured)
        {
            Image<Hsv, Byte> hsvConvertedImage = imageCaptured.ToImage<Hsv, Byte>();
            Hsv lowerLimit = new Hsv((double)lowHue.Value, (double)lowSat.Value, (double)lowValue.Value);
            Hsv higherLimit = new Hsv((double)highHue.Value, (double)highSat.Value, (double)highValue.Value);

            Image<Gray, Byte> inRangedImage = hsvConvertedImage.InRange(lowerLimit, higherLimit);
            Image<Gray, Byte> filteredImage = new Image<Gray, Byte>(inRangedImage.Width, inRangedImage.Height);
            Image<Gray, Byte> kernel = new Image<Gray, byte>(3, 3, new Gray(0));

            CvInvoke.MorphologyEx(inRangedImage, filteredImage, Emgu.CV.CvEnum.MorphOp.Close, kernel, new Point(-1,-1), 3, Emgu.CV.CvEnum.BorderType.Default, new MCvScalar(0));

            return filteredImage;
        }

        private Image<Bgr, Byte> detectCentroidInFrame(Mat imageCaptured)
        {
            Image<Gray, Byte> binarizedImage = applyHsvInRangeAndClosureOperation(imageCaptured);
            MCvMoments moments = CvInvoke.Moments(binarizedImage, true);
            double m00 = moments.GetSpatialMoment(0, 0);
            double m10 = moments.GetSpatialMoment(1, 0);
            double m01 = moments.GetSpatialMoment(0, 1);
            double xCentroid = 0;
            double yCentroid = 0;
            if (m00 != 0)
            {
                xCentroid = m10 / m00;
                yCentroid = m01 / m00;
            }
            txtBxX.Text = ((int) xCentroid).ToString();
            txtBxY.Text = ((int) yCentroid).ToString();
            CircleF centroid = new CircleF(new PointF((float)xCentroid, (float) yCentroid), 15f);
            Image<Bgr, Byte> imageWithCentroid = imageCaptured.ToImage<Bgr, Byte>();
            imageWithCentroid.Draw(centroid, new Bgr(0, 0, 255), -1);

            return imageWithCentroid;
        }
        private void lowSat_Scroll(object sender, EventArgs e)
        {
            txtBxSatLow.Text = lowSat.Value.ToString();
        }

        private void lowHue_Scroll(object sender, EventArgs e)
        {
            txtBxHueLow.Text = lowHue.Value.ToString();
        }

        private void lowValue_Scroll(object sender, EventArgs e)
        {
            txtBxValueLow.Text = lowValue.Value.ToString();
        }

        private void highHue_Scroll(object sender, EventArgs e)
        {
            txtBxHueHigh.Text = highHue.Value.ToString();
        }

        private void highSat_Scroll(object sender, EventArgs e)
        {
            txtBxSatHigh.Text = highSat.Value.ToString();
        }

        private void highValue_Scroll(object sender, EventArgs e)
        {
            txtBxValueHigh.Text = highValue.Value.ToString();
        }
    }

}
