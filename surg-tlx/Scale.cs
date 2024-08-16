using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using static System.Windows.Forms.AxHost;
using System.Runtime.CompilerServices;

namespace surg_tlx
{
    internal class Scale : RadioButton
    {
        //Fields

        //protected override void On

        private void DrawRec(PaintEventArgs e)
        {
            System.Drawing.Point[] p = new System.Drawing.Point[5];
            p[0] = new Point(30, 30);
            p[1] = new Point(0, 30);
            p[2] = new Point(0, 0);
            p[3] = new Point(30, 0);
            p[4] = new Point(30, 15);
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddPolygon(p);

            System.Drawing.Region r = new System.Drawing.Region(gp);
            Graphics gr = e.Graphics;
        }
    }
}
