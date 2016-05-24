using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aplicada1_2016_2
{
   public  class Calculos
    {
        public static int Sumar(int n1, int n2)
        {
            return n1 + n2;
        }

        public static int Factorial(int n)
        {
            if (n == 0)
                return 1;
            else
                return Factorial(n - 1) * n;
        }
    }
}
