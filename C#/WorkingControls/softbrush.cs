using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WorkingControls
{
    static class softbrush
    {
        public static void drawLine(Graphics g,Brush brush,Point x,Point y,int width)
        {
            if(x==y)
            {
                g.FillEllipse(brush, getBound(x,width));
            }
            else
            {
                g.FillEllipse(brush, getBound(x, width));

                DrawMidpart(g, brush, x, y, width);

                g.FillEllipse(brush, getBound(y, width));
            }
        }

        private static void DrawMidpart(Graphics g, Brush brush, Point x, Point y, int width)
        {
            g.DrawLine(new Pen(brush, (float)width*2+1), x, y);
        }

        private static Rectangle getBound(Point origin,int width)
        {
            Point x = new Point(origin.X + width, origin.Y + width);
            Point y = new Point(origin.X - width, origin.Y - width);
            return new Rectangle(y.X,y.Y, width*2+1,width*2+1);
        }
    }
}
