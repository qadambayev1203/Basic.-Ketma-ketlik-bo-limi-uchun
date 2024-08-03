using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_topshiriq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1-misol

            Console.Write("Birinchi raqamni kiriting: ");
            double raqam1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Operatsiyani kiriting (+, -, *, /): ");
            char operatsiya = Console.ReadKey().KeyChar;
            Console.WriteLine();

            Console.Write("Ikkinchi raqamni kiriting: ");
            double raqam2 = Convert.ToDouble(Console.ReadLine());

            double natija = 0;

            switch (operatsiya)
            {
                case '+':
                    natija = raqam1 + raqam2;
                    break;
                case '-':
                    natija = raqam1 - raqam2;
                    break;
                case '*':
                    natija = raqam1 * raqam2;
                    break;
                case '/':
                    if (raqam2 != 0)
                    {
                        natija = raqam1 / raqam2;
                    }
                    else
                    {
                        Console.WriteLine("Nolga bo'lib bo'lmaydi.");
                        return;
                    }
                    break;
                default:
                    Console.WriteLine("Noto'g'ri operatsiya.");
                    return;
            }

            Console.WriteLine($"Natija: {natija}");


            //2-misol
            Console.Write("N ni kiriting: ");
            int N = Convert.ToInt32(Console.ReadLine());

            int yigindi = 0;

            for (int i = 1; i <= N; i++)
            {
                yigindi += i;
            }

            Console.WriteLine($"1 dan {N} gacha bo'lgan sonlar yig'indisi: {yigindi}");


            //3-misol
            Console.Write("Raqamni kiriting: ");
            int raqam = Convert.ToInt32(Console.ReadLine());

            if (raqam % 2 == 0)
            {
                Console.WriteLine("Juft");
            }
            else
            {
                Console.WriteLine("Toq");
            }
            Console.ReadKey();
        }
    }
}
