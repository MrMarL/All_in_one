using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        struct student
        {
            public string fio;
            public byte otenka1;
            public byte otenka2;
        }
        static void Main(string[] args)
        {
            student P = new student();

            student P1 = new student();
            P1.fio = Console.ReadLine();
            P1.otenka1 = Convert.ToByte(Console.ReadLine());
            P1.otenka2 = Convert.ToByte(Console.ReadLine());

            student P2 = new student();
            P2.fio = Console.ReadLine();
            P2.otenka1 = Convert.ToByte(Console.ReadLine());
            P2.otenka2 = Convert.ToByte(Console.ReadLine());

            student P3 = new student();
            P3.fio = Console.ReadLine();
            P3.otenka1 = Convert.ToByte(Console.ReadLine());
            P3.otenka2 = Convert.ToByte(Console.ReadLine());

            Console.WriteLine(P1.fio + " " + P1.otenka1 + " " + P1.otenka2);
            Console.WriteLine(P2.fio + " " + P2.otenka1 + " " + P2.otenka2);
            Console.WriteLine(P3.fio + " " + P3.otenka1 + " " + P3.otenka2);
            Console.Read();
        }
    }
}