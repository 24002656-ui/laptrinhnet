///bai8//
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("KIEM TRA SO NGUYEN TO");
        Console.Write("Nhap so nguyen n: ");

        int n = int.Parse(Console.ReadLine());

        if (n < 2)
        {
            Console.WriteLine("Khong co so nguyen to nao nho hon " + n + " va lon hon 1.");
            return;
        }

        Console.WriteLine("Cac so nguyen to khong vuot qua " + n + " la:");

        for (int i = 2; i <= n; i++)
        {
            bool laSoNguyenTo = true;

            for (int j = 2; j * j <= i; j++)
            {
                if (i % j == 0)
                {
                    laSoNguyenTo = false;
                    break;
                }
            }

            if (laSoNguyenTo == true)
            {
                Console.Write(i + " ");
            }
        }

        Console.WriteLine();
        Console.WriteLine("Ket thuc chuong trinh.");
        Console.ReadKey();
    }
}
