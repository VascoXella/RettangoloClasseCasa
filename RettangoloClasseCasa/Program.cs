using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RettangoloClasseCasa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rettangolo r = new Rettangolo();

            r.l1 = float.Parse(Console.ReadLine());
            r.l2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Area:{0}, perimetro:{1}", r.Area(), r.Perimetro());

            Console.ReadLine();
        }
    }
}
