using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicExamples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen redPen = new Pen(Color.Red, 1);
            SolidBrush blackBrush = new SolidBrush(Color.Black);

            g.Clear(Color.White);
            g.DrawLine(redPen, 0, 0, 100, 100);
            g.DrawRectangle(redPen, 30, 30, 100, 200);
            g.FillRectangle(blackBrush, 30, 30, 100, 200);
            g.DrawEllipse(redPen, 30, 30, 200, 200);
            g.DrawEllipse(redPen, 230, 30, 200, 100);
            g.FillEllipse(blackBrush, 230, 30, 200, 100);
            g.DrawArc(redPen, 275, 150, 50, 50, 120, 300);
            g.DrawPie(redPen, 275, 225, 50, 50, 30, 300);
            g.DrawPie(redPen, 350, 225, 50, 50, 30, 60);

        }
    }
}
