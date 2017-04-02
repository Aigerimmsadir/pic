using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Star
    {
        public GraphicsPath gp = new GraphicsPath();
        public Star(int x1, int y1, int w,int h)
        {
            Rectangle r = new Rectangle( x1,  y1, w,  h);
            gp.AddRectangle(r);
            Triangle t1 = new Triangle(x1, y1, w);
            gp.AddPath(t1.gp,true);
            Triangle t2 = new Triangle(x1+2*w, y1, -w);
            gp.AddPath(t2.gp, true);
            Triangle t3 = new Triangle(x1 +  w, y1+h, w);
            gp.AddPath(t3.gp, true);
            Triangle t4 = new Triangle(x1+w, y1 + h, -w);
            gp.AddPath(t4.gp, true);
            Triangle t5 = new Triangle(x1 - w, y1 + h, w);
            gp.AddPath(t5.gp, true);
            Triangle t6 = new Triangle(x1 , y1, -w);
            gp.AddPath(t6.gp, true);
           
        }
    }
}
