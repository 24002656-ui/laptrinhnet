
using System;

interface IMove
{
    double TinhTocDo();
    double TinhChiPhi(double km);
    void DiChuyen();
}

class XeMay : IMove
{
    public double TinhTocDo() { return 45; }
    public double TinhChiPhi(double km) { return km * 1500; }
    public void DiChuyen()
    {
        Console.WriteLine("Xe may dang di chuyen");
    }
}

class OTo : IMove
{
    public double TinhTocDo() { return 60; }
    public double TinhChiPhi(double km) { return km * 5000; }
    public void DiChuyen()
    {
        Console.WriteLine("O to dang di chuyen");
    }
}

class XeDap : IMove
{
    public double TinhTocDo() { return 15; }
    public double TinhChiPhi(double km) { return 0; }
    public void DiChuyen()
    {
        Console.WriteLine("Xe dap dang di chuyen");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("1. Xe may");
        Console.WriteLine("2. O to");
        Console.WriteLine("3. Xe dap");
        Console.Write("Chon phuong tien: ");
        int chon = int.Parse(Console.ReadLine());

        Console.Write("Nhap so km di chuyen: ");
        double km = double.Parse(Console.ReadLine());

        IMove xe;

        switch (chon)
        {
            case 1:
                xe = new XeMay();
                break;
            case 2:
                xe = new OTo();
                break;
            case 3:
                xe = new XeDap();
                break;
            default:
                Console.WriteLine("Lua chon khong hop le!");
                return;
        }

        xe.DiChuyen();
        Console.WriteLine("Toc do: " + xe.TinhTocDo() + " km/h");
        Console.WriteLine("Chi phi: " + xe.TinhChiPhi(km) + " VND");

        Console.ReadKey();
    }
}

