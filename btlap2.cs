
using System;

class SanPham
{
    // 1. Khai bao cac thuoc tinh
    public string MaSP;
    public string TenSP;
    public double DonGia;
    public int SoLuong;

    // 2. Ham nhap thong tin san pham
    public void NhapThongTin()
    {
        Console.Write("Nhap ma san pham: ");
        MaSP = Console.ReadLine();

        Console.Write("Nhap ten san pham: ");
        TenSP = Console.ReadLine();

        Console.Write("Nhap don gia: ");
        DonGia = double.Parse(Console.ReadLine());

        Console.Write("Nhap so luong: ");
        SoLuong = int.Parse(Console.ReadLine());
    }

    // 3. Ham kiem tra du lieu
    public bool KiemTraDuLieu()
    {
        if (string.IsNullOrWhiteSpace(MaSP))
        {
            return false;
        }

        if (string.IsNullOrWhiteSpace(TenSP))
        {
            return false;
        }

        if (DonGia < 0 || SoLuong < 0)
        {
            return false;
        }

        return true;
    }

    // 4. Ham tinh thanh tien
    public double TinhThanhTien()
    {
        return DonGia * SoLuong;
    }

    // 5. Ham hien thi thong tin
    public void HienThi()
    {
        Console.WriteLine("\n--- THONG TIN SAN PHAM ---");
        Console.WriteLine("Ma san pham: " + MaSP);
        Console.WriteLine("Ten san pham: " + TenSP);
        Console.WriteLine("Don gia: " + DonGia);
        Console.WriteLine("So luong: " + SoLuong);
        Console.WriteLine("Thanh tien: " + TinhThanhTien());
    }
}

class Program
{
    static void Main(string[] args)
    {
        SanPham sp = new SanPham();

        sp.NhapThongTin();

        if (sp.KiemTraDuLieu())
        {
            sp.HienThi();
        }
        else
        {
            Console.WriteLine("Du lieu khong hop le!");
        }

        Console.ReadKey();
    }
}

