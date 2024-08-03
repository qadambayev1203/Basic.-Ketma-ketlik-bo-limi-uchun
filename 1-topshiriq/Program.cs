using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DotnetKurs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1-misol
            Console.Write("radius = ");
            double radius = Convert.ToDouble(Console.ReadLine());
            double S = Math.PI * Math.Pow(radius, 2);
            double L = 2 * Math.PI * radius;
            Console.WriteLine($"S = {S}, L = {L}");


            // 2-misol
            Console.Write("qiymat = ");
            double qiymat = Convert.ToDouble(Console.ReadLine());
            Console.Write("kurs = ");
            double kurs = Convert.ToDouble(Console.ReadLine());
            double natija = qiymat * kurs;
            Console.WriteLine($"{natija} so'm");

            //3-misol
            Console.Write("x = ");
            int x = Convert.ToInt32(Console.ReadLine());
            int hozirgiYil = 2024;
            int kunlar = (hozirgiYil - x) * 365;
            Console.WriteLine($"{kunlar} kun");

            Console.ReadKey();

        }
    }
}
