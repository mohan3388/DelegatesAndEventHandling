using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleCastDelegate
{
    internal class Delegate
    {
        public delegate int Operation(int x, int y);

        public static int Addition(int x, int y)
        {
            return x + y;
        }
    }
}
