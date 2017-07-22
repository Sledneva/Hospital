using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Hospital
{
    class MD
    {
        int x;
        int y;
        public MD(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public int X()
        {
            return x;
        }
        public int Y()
        {
            return y;
        }

        public bool heal(Man man) {
            return false;
        }
    }
}
