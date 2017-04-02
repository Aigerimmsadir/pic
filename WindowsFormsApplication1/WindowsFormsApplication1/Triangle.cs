using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Triangle
    {
        public GraphicsPath gp = new GraphicsPath();
        public Triangle(int x1,int y1,int w)
        {
            gp.AddLine(x1, y1, x1 + w / 2, y1 - w * 4 / 5);
            gp.AddLine(x1 + w / 2, y1 - w * 4 / 5 ,x1+w,y1);
            gp.AddLine(x1 + w, y1, x1, y1);
        }
    }
}
