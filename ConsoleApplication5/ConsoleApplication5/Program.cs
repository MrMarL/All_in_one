using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 999999;
            do
            {
                Random rnd = new Random();

                int value = rnd.Next(100 , 999);

                Console.Write(value);
                i--;
                System.Threading.Thread.Sleep(1);
            }
            while (i > 0);
            Console.ReadKey();
        }
    }
}
