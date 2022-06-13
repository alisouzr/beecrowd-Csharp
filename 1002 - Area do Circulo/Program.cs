using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1002___Area_do_Circulo
{
    internal class BEECROWN
    {
        static void Main(string[] args)
        {
            double raio, pi, area;
            raio = double.Parse(Console.ReadLine());
            pi = 3.14159;
            area = pi * Math.Pow(raio, 2);
            Console.WriteLine("A={0}", area.ToString("0."));

            Console.ReadLine();
        }
    }
}
