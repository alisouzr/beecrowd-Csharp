using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1005___Media_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            double media = ((a*3.5) + (b*7.5))/11;

            Console.WriteLine("MEDIA = "+media);
            Console.ReadLine();
        }
    }
}
