using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public static class Calculadora
    {
        public static int Somar(int a, int b)
        {
            return a + b;
        }

        public static int Somar(int a, int b, int c)
        {
            return a + b + c;
        }

        public static int Subtrair(int a, int b)
        {
            return a - b;
        }

        public static int Subtrair(int a, int b, int c)
        {
            return a - b - c;
        }

        public static int Multiplicar(int a, int b)
        {
            return a * b;
        }

        public static int Multiplicar(int a, int b, int c)
        {
            return a * b * c;
        }
    }
}
