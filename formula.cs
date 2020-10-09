using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My22
{
    public delegate int GetAction(int x, int y);

    class formula
    {
        public static int getSum(int a, int b)
        {
            return a + b;
        }
        public static int getSub(int a, int b)
        {
            return a - b;
        }
        public static int getMulti(int a, int b)
        {
            return a * b;
        }
        public static int getDiv(int a, int b)
        {
            return a / b;
        }
    }
}
