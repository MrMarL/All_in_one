using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    static class Arifm
    {
        public static int sum(int a, int b)
        {
         return(a + b);
        }
        public static int ymn(int a, int b)
        {
            return (a * b);
        }
        public static int min(int a, int b)
        {
            return (a - b);
        }
        public static int del(int a, int b)
        {
            return (a / b);
        }
        public static int koren(int a)
        {
            return (Convert.ToInt32(Math.Sqrt(a)));
        }
        public static int kvad(int a)
        {
            return (a * a);
        }

    }
}
