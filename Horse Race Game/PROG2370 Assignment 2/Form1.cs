using System.CodeDom;
using System.Numerics;

namespace PROG2370_Assignment_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random random = new Random();
        const double Rad2Deg = 180.0 / Math.PI;
        const double Deg2Rad = Math.PI / 180.0;

        const int h1Radius = 127;
        const int h2Radius = 178;
        const int h3Radius = 230;

       
        double h1Time = 0, h2Time = 0, h3Time = 0;

        double h1Distance = 585, h2Distance = 820, h3Distance = 1060;

        Point origin = new Point(242, 243);
        Point h1Point, h2Point, h3Point;

        double h1Angle,h2Angle,h3Angle;

        bool h1Done = false, h2Done = false, h3Done = false;

        private void lblHorseRace_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        { 

        }

        private void counter1_Tick(object sender, EventArgs e)
        {
            h1Time++;
        }

        private void counter2_Tick(object sender, EventArgs e)
        {
            h2Time++;
        }

        private void counter3_Tick(object sender, EventArgs e)
        {
            h3Time++;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            h3Time = 0;
            h2Time = 0;
            h1Time = 0;

            lblWinner.Text = "Winner:";
            lblTiming.Text = "Timing:";
            lblSpeed.Text = "Speed:";

            lblHorse1Speed.Text = "##";
            lblHorse1Timing.Text = "##";
            lblHorse2Speed.Text = "##";
            lblHorse2Timing.Text = "##";
            lblHorse3Speed.Text = "##";
            lblHorse3Timing.Text = "##";


            picHorse1.Location = new Point(116, 243);
            picHorse2.Location = new Point(65, 243);
            picHorse3.Location = new Point(12, 243);

            timer1.Enabled = true;
            timer2.Enabled = true;
            timer3.Enabled = true;
            counter1.Start();
            counter2.Start();
            counter3.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            h2Point = picHorse2.Location;
            h2Angle = GetAngle(origin, h2Point);
            h2Angle = h2Angle + random.Next(2, 10);
            Point newPoint2 = getNewPoint(h2Angle, h2Radius);
            picHorse2.Location = newPoint2;

            if (h2Point.X <= lblEnd.Right && h2Point.Y > origin.Y)
            {
                timer2.Enabled = false;
                counter2.Stop();
                h2Done = true;

                

                if (h1Done == true && h3Done == true)
                {
                    DisplayResults();
                }
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            h3Point = picHorse3.Location;
            h3Angle = GetAngle(origin, h3Point);
            h3Angle = h3Angle + random.Next(2, 10);
            Point newPoint3 = getNewPoint(h3Angle, h3Radius);
            picHorse3.Location = newPoint3;

            if (h3Point.X <= lblEnd.Right && h3Point.Y > origin.Y)
            {
                timer3.Enabled = false;
                counter3.Stop();
                h3Done = true;

               

                if (h2Done == true && h1Done == true)
                {
                    DisplayResults();
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = true;
            timer3.Enabled = true;
            counter1.Start();
            counter2.Start();
            counter3.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            h1Point = picHorse1.Location;
            h1Angle = GetAngle(origin, h1Point);
            h1Angle = h1Angle + random.Next(2, 10);
            Point newPoint1 = getNewPoint(h1Angle, h1Radius);
            picHorse1.Location = newPoint1;

            if(h1Point.X <= lblEnd.Right && h1Point.Y > origin.Y)
            {
                timer1.Enabled = false;
                counter1.Stop();
                h1Done = true;
               


                if (h2Done == true && h3Done == true)
                {
                    DisplayResults();
                }

            }
        }

        public double GetAngle(Point origin, Point end)
        {
            return Math.Atan2(origin.Y-end.Y,origin.X - end.X) *Rad2Deg;
        }

        public Point getNewPoint(double angle, int radius)
        {
            int x, y;
            x = Convert.ToInt32(origin.X - (radius * (Math.Cos(angle*Deg2Rad))));
            y = Convert.ToInt32(origin.Y -(radius * (Math.Sin(angle*Deg2Rad))));

            return new Point(x, y);
        }

        void DisplayResults()
        {
            lblHorse1Timing.Text = (h1Time / 10).ToString();
            lblHorse2Timing.Text = (h2Time / 10).ToString();
            lblHorse3Timing.Text = (h3Time / 10).ToString();

            lblHorse1Speed.Text = Math.Round((h1Distance/h1Time), 2).ToString();
            lblHorse2Speed.Text = Math.Round((h2Distance / h2Time), 2).ToString();
            lblHorse3Speed.Text = Math.Round((h3Distance / h3Time), 2).ToString();

            if (h1Time < h2Time && h1Time < h3Time)
            {
                lblWinner.Text += " 1";
                lblTiming.Text += " "+(h1Time / 10).ToString(); 
                lblSpeed.Text += " " + Math.Round((h1Distance / h1Time), 2).ToString(); 
            }
            if (h2Time < h1Time && h2Time < h3Time)
            {
                lblWinner.Text += " 2";
                lblTiming.Text += " " + (h2Time / 10).ToString();
                lblSpeed.Text += " " + Math.Round((h2Distance / h2Time), 2).ToString(); 
            }
            if (h3Time < h2Time && h3Time < h1Time)
            {
                lblWinner.Text += " 3";
                lblTiming.Text += " " + (h3Time / 10).ToString();
                lblSpeed.Text += " " + Math.Round((h3Distance / h3Time), 2).ToString();
            }
        }
    }
}