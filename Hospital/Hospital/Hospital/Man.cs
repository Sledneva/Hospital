using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Hospital
{
    class Man
    {
        int x;
        int y;
        public Man(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public void changeX(bool b)
        {
            if (b)
                x++;
            else
                x--;
        }
        public int X()
        {
            return x;
        }
        public int Y()
        {
            return y;
        }
        public void changeY(bool b)
        {
            if (b)
                y++;
            else
                y--;
        }
    }
}
