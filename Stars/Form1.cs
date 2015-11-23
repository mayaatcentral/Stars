using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stars
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StarField(100);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StarField(100);

        }
        private void StarField(int y)
        {
    
        Random randNum = new Random();
        int counter = 0;
        int rand;

        Graphics g = this.CreateGraphics();
            rand = randNum.Next(1, 10001);

            Pen drawPen = new Pen(Color.Red, 10);

            while (counter < y)
            {
                counter++;
                int xValue = randNum.Next(0, this.Width);
                int yValue = randNum.Next(0, this.Height);
                int RGBValue1 = randNum.Next(0, 225);
                int RGBValue2 = randNum.Next(0, 225);
                int RGBValue3 = randNum.Next(0, 225);
                int size1 = randNum.Next(0, 100);
                int size2 = randNum.Next(0, 100);

                drawPen.Color = Color.FromArgb(RGBValue1, RGBValue2, RGBValue3, 0);
                g.DrawEllipse(drawPen, xValue, yValue, size1, size2);
            }

            counter = 0;
        }









    }
}

