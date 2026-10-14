///bai7///
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("THONG KE DAY SO");
        Console.Write("Nhap so luong phan tu n: ");

        int n = int.Parse(Console.ReadLine());

        // Kiem tra n phai lon hon 0
        if (n <= 0)
        {
            Console.WriteLine("n phai lon hon 0!");
            return;
        }

        int tong = 0;
        int soChan = 0;
        int soLonNhat = int.MinValue;
        int soNhoNhat = int.MaxValue;

        for (int i = 1; i <= n; i++)
        {
            Console.Write("Nhap so nguyen thu " + i + ": ");
            int x = int.Parse(Console.ReadLine());

            // Tinh tong
            tong = tong + x;

            // Tim so lon nhat
            if (x > soLonNhat)
            {
                soLonNhat = x;
            }

            // Tim so nho nhat
            if (x < soNhoNhat)
            {
                soNhoNhat = x;
            }

            // Dem so chan
            if (x % 2 == 0)
            {
                soChan++;
            }
        }

        // Tinh trung binh
        double trungBinh = (double)tong / n;

        // Hien thi ket qua
        Console.WriteLine("-------------------------");
        Console.WriteLine("Tong = " + tong);
        Console.WriteLine("Trung binh = " + trungBinh);
        Console.WriteLine("So lon nhat = " + soLonNhat);
        Console.WriteLine("So nho nhat = " + soNhoNhat);
        Console.WriteLine("So luong so chan = " + soChan);

        Console.ReadKey();
    }
}

