using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
namespace Hospital
{
    class Action
    {
        public void Moving(PictureBox pb, Man man, MD md, Timer tm1, Timer tm2)
        {
            Point pt;
            if ((man.Y() != md.Y()) || ((man.X() != md.X()))) { 
                if(!(man.X() == md.X()))
                man.changeX(man.X()<md.X());
                if(!(man.Y() == md.Y()))
                man.changeY(man.Y()<md.Y());
                pt = new Point(man.X(), man.Y());
                pb.Location = pt;
            }
            else
            {
                tm1.Stop();
                tm2.Start();
            }
            

        }
    }
}
