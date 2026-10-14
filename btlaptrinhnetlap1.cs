///bai6///
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("GIAI PHUONG TRINH BAC HAI");
        Console.WriteLine("Phuong trinh co dang: ax^2 + bx + c = 0");
        Console.WriteLine("-----------------------------------");

        double a, b, c;

        Console.Write("Nhap a: ");
        a = double.Parse(Console.ReadLine());

        Console.Write("Nhap b: ");
        b = double.Parse(Console.ReadLine());

        Console.Write("Nhap c: ");
        c = double.Parse(Console.ReadLine());

        if (a == 0)
        {
            if (b == 0)
            {
                if (c == 0)
                {
                    Console.WriteLine("Phuong trinh vo so nghiem.");
                }
                else
                {
                    Console.WriteLine("Phuong trinh vo nghiem.");
                }
            }
            else
            {
                double x = -c / b;
                Console.WriteLine("Nghiem x = {0:F2}", x);
            }
        }
        else
        {
            double delta = b * b - 4 * a * c;

            Console.WriteLine("Delta = {0:F2}", delta);

            if (delta < 0)
            {
                Console.WriteLine("Phuong trinh vo nghiem thuc.");
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine("Nghiem kep x = {0:F2}", x);
            }
            else
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

                Console.WriteLine("Nghiem x1 = {0:F2}", x1);
                Console.WriteLine("Nghiem x2 = {0:F2}", x2);
            }
        }

        Console.WriteLine("Ket thuc chuong trinh.");
        Console.ReadKey();
    }
}

