using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jednoduchý_editor_grafiky
{
    public partial class Form1 : Form
    {
        
        string obrazec;
        Color color;
        int sirka;
        int width;
        int height;
        int x;
        int y;

        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            obrazec = comboBox1.Text;           
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen pen = new Pen(color, sirka);
            Brush brush = new SolidBrush(color);
            g.SmoothingMode = SmoothingMode.HighQuality;

            if (obrazec == "Kružnice")
            {
                g.DrawEllipse(pen, x, y, width, width);
            }
            if (obrazec == "Kruh")
            {
                g.DrawEllipse(pen, x, y, width, width);
                g.FillEllipse(brush, x, y, width, width);
            }
            if (obrazec == "Ovál")
            {
                g.DrawEllipse(pen, x, y, width, height);
            }
            if (obrazec == "Čtverec")
            {
                g.DrawRectangle(pen, x, y, width, width);
            }
            if (obrazec == "Obdélník")
            {
                g.DrawRectangle(pen, x, y, width, height);
            }
            if (obrazec == "Trojúhelník")
            {
                Point point1 = new Point(x, y);
                Point point2 = new Point(x +width, y);
                Point point3 = new Point(x + (width / 2), y -height);
                Point[] curvePoints =
                         {
                 point1,
                 point2,
                 point3
             };

                g.DrawPolygon(pen, curvePoints);
            }
            if (obrazec == "Čára")
            {
                g.DrawLine(pen, x, y, x +width, y +height);
            }
            if (obrazec == "Diamant")
            {
                Point point1 = new Point(x, y);
                Point point2 = new Point(x + (width / 2), y + (height / 2));
                Point point3 = new Point(x + width , y);
                Point point4 = new Point(x + (width / 2), y - (height / 2));  
                Point[] curvePoints =
                         {
                 point1,
                 point2,
                 point3,
                 point4
             };

                g.DrawPolygon(pen, curvePoints);
            }
            if (obrazec == "Kosočtverec")
            {
                Point point1 = new Point(x, y);
                Point point2 = new Point(x + (width / 2), y + (width / 2));
                Point point3 = new Point(x + width, y);
                Point point4 = new Point(x + (width / 2), y - (width / 2));
                Point[] curvePoints =
                         {
                 point1,
                 point2,
                 point3,
                 point4
             };

                g.DrawPolygon(pen, curvePoints);
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            x = e.X; 
            y = e.Y;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            sirka = trackBar1.Value *3;
            label7.Text = Convert.ToString(trackBar1.Value);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            color = Color.Black;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            color = Color.Gray;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            color = Color.Red;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            color = Color.DarkRed;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            color = Color.Yellow;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            color = Color.Orange;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            color = Color.Green;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            color = Color.Blue;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            color = Color.Turquoise;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            color = Color.Purple;
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            width = trackBar2.Value * 10;
            label2.Text = Convert.ToString(trackBar2.Value);
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            height = trackBar3.Value * 10;
            label6.Text = Convert.ToString(trackBar3.Value);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            color = Color.White;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            color = Color.LightGray;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            color = Color.SaddleBrown;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            color = Color.Pink;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            color = Color.Wheat;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            color = Color.Lime;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            color = Color.PaleTurquoise;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            color = Color.Lavender;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            color = Color.SteelBlue;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            color = Color.Gold;
        }
    }
}