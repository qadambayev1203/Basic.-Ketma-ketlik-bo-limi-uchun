using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_topshiriq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1-misol
            Console.Write("Raqamni kiriting: ");
            int raqam = Convert.ToInt32(Console.ReadLine());
            bool tub = true;

            if (raqam <= 1)
            {
                tub = false;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(raqam); i++)
                {
                    if (raqam % i == 0)
                    {
                        tub = false;
                        break;
                    }
                }
            }

            if (tub)
            {
                Console.WriteLine("Tub");
            }
            else
            {
                Console.WriteLine("Tub emas");
            }


            //2-misol
            Console.Write("Raqamni kiriting: ");
            int raqam2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Bo'luvchilari: ");
            bool first = true;

            for (int i = 2; i <= 10; i++)
            {
                if (raqam2 % i == 0)
                {
                    if (!first) Console.Write(", ");
                    Console.Write(i);
                    first = false;
                }
            }
            Console.WriteLine();

            //3-misol
            Console.Write("Sonni kiriting: ");
            int son = Convert.ToInt32(Console.ReadLine());
            Console.Write("Darajani kiriting: ");
            int daraja = Convert.ToInt32(Console.ReadLine());

            int natija = Convert.ToInt32(Math.Pow(son, daraja));


            Console.WriteLine($"Natija: {natija}");


            //4-misol
            Console.Write("Harajatlarni kiriting (vergul bilan ajratib): ");
            string input = Console.ReadLine();
            string[] qator = input.Split(',');

            int yigindi = 0;
            foreach (string item in qator)
            {
                yigindi += Convert.ToInt32(item.Trim());
            }

            Console.WriteLine($"Yig'indi: {yigindi}");

            //5-misol
            Console.Write("Raqamni kiriting: ");
            int raqam5 = Convert.ToInt32(Console.ReadLine());
            int original = raqam5;
            int raqamlarSoni = raqam5.ToString().Length;
            int yigindi2 = 0;

            while (raqam5 > 0)
            {
                int digit = raqam5 % 10;
                yigindi2 += (int)Math.Pow(digit, raqamlarSoni);
                raqam5 /= 10;
            }

            if (yigindi2 == original)
            {
                Console.WriteLine($"{original} Armstrong son");
            }
            else
            {
                Console.WriteLine($"{original} Armstrong son emas");
            }

            //6-misol
            Console.Write("Raqamni kiriting: ");
            int raqam3 = Convert.ToInt32(Console.ReadLine());
            int soni = 0;

            for (int i = 1; i <= raqam3; i++)
            {
                if (raqam3 % i == 0)
                {
                    bool sifatli = true;
                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            sifatli = false;
                            break;
                        }
                    }
                    if (sifatli)
                    {
                        soni++;
                    }
                }
            }

            Console.WriteLine($"Sifatli bo'luvchilari soni: {soni}");

        }
    }
}
