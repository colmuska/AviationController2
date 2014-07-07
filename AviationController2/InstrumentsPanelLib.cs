using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Threading;

namespace AviationController2
{
    class InstrumentsPanelLib
    {
        static public void relativeDrawLine(PaintEventArgs e,Pen pen,double x1, double y1, double x2, double y2)
        {
            int width = e.ClipRectangle.Width;
            int height = e.ClipRectangle.Height;

            Graphics g = e.Graphics;

            g.DrawLine(pen,new Point((int)(width/2 + x1*width/2),(int)(height/2 - y1 * height/2)),new Point((int)(width/2 + x2*width/2),(int)(height/2 - y2 * height/2)));

        }

        static public void paintTriAxisPanel(object sender, PaintEventArgs e,double x,double y, double z, double xMax,double yMax, double zMax)
        {
            Graphics g = e.Graphics;

            int width = e.ClipRectangle.Width;
            int height = e.ClipRectangle.Height;

            paintAxis(sender, e);

            Pen pen = new Pen(Color.Red, 3);


            pen.Color = Color.Red;
            relativeDrawLine(e, pen, 0, 0, -x / xMax * Math.Sqrt(3) / 2 * 0.9, x / xMax * -0.5*0.9);
            pen.Color = Color.Green;
            relativeDrawLine(e, pen, 0, 0, y / yMax * Math.Sqrt(3) / 2 * 0.9, y / yMax * -0.5*0.9);
            pen.Color = Color.Blue;
            relativeDrawLine(e, pen, 0, 0, 0, z / zMax * 0.9);
        }
        static private void paintAxis(object sender, PaintEventArgs e)
        {
            relativeDrawLine(e, Pens.LightGray, 0, 0.9, 0, -0.9);
            relativeDrawLine(e, Pens.LightGray, -Math.Sqrt(3) / 2 * 0.9, 0.5 * 0.9, Math.Sqrt(3) / 2 * 0.9, -0.5 * 0.9);
            relativeDrawLine(e, Pens.LightGray, Math.Sqrt(3) / 2 * 0.9, 0.5 * 0.9, -Math.Sqrt(3) / 2 * 0.9, -0.5 * 0.9);
            relativeDrawLine(e, Pens.DarkGray, 0, 0, 0, 0.9);
            relativeDrawLine(e, Pens.DarkGray, 0, 0,  Math.Sqrt(3) / 2 * 0.9, -0.5 * 0.9);
            relativeDrawLine(e, Pens.DarkGray, 0, 0, -Math.Sqrt(3) / 2 * 0.9, -0.5 * 0.9);
        }

        static public void paintRingPanel(object sender, PaintEventArgs e,string label, Image outerRing, Image innerRing, double degAngle)
        {
            Bitmap canvas = new Bitmap(e.ClipRectangle.Width,e.ClipRectangle.Height);
            Graphics g = Graphics.FromImage(canvas);

            
            g.DrawImage(outerRing,0,0,e.ClipRectangle.Width,e.ClipRectangle.Height);

            g.TranslateTransform(e.ClipRectangle.Width / 2, e.ClipRectangle.Height / 2);
            g.RotateTransform((float)degAngle);
            g.TranslateTransform(-e.ClipRectangle.Width / 2, -e.ClipRectangle.Height / 2);
            g.DrawImage(innerRing, 0, 0, e.ClipRectangle.Width, e.ClipRectangle.Height);

            
            e.Graphics.DrawImage(canvas, new Point(0, 0));

        }
        
    }
}
