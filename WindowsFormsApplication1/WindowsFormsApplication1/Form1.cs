using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        GraphicsPath gp = new GraphicsPath();
        GraphicsPath gp2 = new GraphicsPath();
        Rectangle r2 = new Rectangle(300, 220, 60, 40);
        Rectangle r = new Rectangle(0,0,700,520);
        Rectangle r3 = new Rectangle(322, 230, 15, 30);
        SolidBrush b = new SolidBrush(Color.Green);
        SolidBrush b2 = new SolidBrush(Color.White);
        SolidBrush b3 = new SolidBrush(Color.Yellow);
        Pen p = new Pen(Color.Yellow);
        Pen red = new Pen(Color.Red);
        Pen pp = new Pen(Color.Black,100);
        Pen p2 = new Pen(Color.Green);
        public Form1()
        {
            InitializeComponent();

            this.Size = new Size(720, 550);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
           
            e.Graphics.DrawRectangle(pp, r);
            gp.AddLine(360, 220, 330, 200);
            gp.AddLine(300, 220, 300, 200);
            gp.AddLine(300, 260, 330, 280);
            gp.AddLine(330, 280, 360, 260);
            e.Graphics.FillPath(b3, gp);

            e.Graphics.FillEllipse(b2, 70, 100, 20, 20);
            e.Graphics.FillEllipse(b2, 270, 100, 20, 20);
            e.Graphics.FillEllipse(b2, 550, 130, 20, 20);

            e.Graphics.FillEllipse(b2, 400, 380, 20, 20);
            e.Graphics.FillEllipse(b2, 170, 400, 20, 20);
            e.Graphics.FillEllipse(b2, 610, 400, 20, 20);
            e.Graphics.FillRectangle(b3, r2);
            e.Graphics.FillRectangle(p2.Brush, r3);
            Point[] triangle =
            {
                new Point(315, 230),
                new Point(330, 210),
                new Point(342, 230)
        };
            e.Graphics.FillPolygon(p2.Brush,triangle);
            int x = 360;
            int y = 100;
            Point[] poins = {
                                new Point (x,y),
                                new Point (x-5,y+30),
                                 new Point (x-20,y+45),
                                 new Point (x+20,y+45),
                                 new Point (x+5,y+30),
            };
            e.Graphics.FillClosedCurve(b, poins);
          

            Point[] poins2 = {
                                new Point (x,y+90),

                                new Point (x+5,y+60),
                                 new Point (x+20,y+42),
                                 new Point (x-20,y+42),
                                 new Point (x-5,y+60),
                            };
            e.Graphics.FillClosedCurve(b, poins2);
            Star star = new Star(175, 130, 15, 24);
            e.Graphics.DrawPath(red, star.gp);
            Star star2 = new Star(500, 100, 15, 24);
            e.Graphics.DrawPath(red, star2.gp);
            Star star3 = new Star(215, 300, 15, 24);
            e.Graphics.DrawPath(red, star3.gp);
            Star star4 = new Star(475, 300, 15, 24);
            e.Graphics.DrawPath(red, star4.gp);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor  = Color.SlateBlue;
            
        }
    }
}
