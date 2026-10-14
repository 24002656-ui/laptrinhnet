
using System;

class TaiKhoanNganHang
{
    // 1. Khai bao thuoc tinh
    public string SoTaiKhoan;
    public string TenChuTaiKhoan;
    public double SoDu;

    // 2. Ham nhap thong tin tai khoan
    public void NhapThongTin()
    {
        Console.Write("Nhap so tai khoan: ");
        SoTaiKhoan = Console.ReadLine();

        Console.Write("Nhap ten chu tai khoan: ");
        TenChuTaiKhoan = Console.ReadLine();

        Console.Write("Nhap so du ban dau: ");
        SoDu = double.Parse(Console.ReadLine());

        if (SoDu < 0)
        {
            Console.WriteLine("So du khong duoc am!");
            SoDu = 0;
        }
    }

    // 3. Ham nap tien
    public void NapTien(double soTien)
    {
        if (soTien <= 0)
        {
            Console.WriteLine("So tien nap phai lon hon 0!");
        }
        else
        {
            SoDu = SoDu + soTien;
            Console.WriteLine("Nap tien thanh cong!");
        }
    }

    // 4. Ham rut tien
    public void RutTien(double soTien)
    {
        if (soTien <= 0)
        {
            Console.WriteLine("So tien rut phai lon hon 0!");
        }
        else if (soTien > SoDu)
        {
            Console.WriteLine("So du khong du de rut tien!");
        }
        else
        {
            SoDu = SoDu - soTien;
            Console.WriteLine("Rut tien thanh cong!");
        }
    }

    // 5. Ham chuyen tien
    public void ChuyenTien(
        TaiKhoanNganHang taiKhoanNhan, double soTien)
    {
        if (soTien <= 0)
        {
            Console.WriteLine("So tien chuyen phai lon hon 0!");
        }
        else if (soTien > SoDu)
        {
            Console.WriteLine("So du khong du de chuyen!");
        }
        else
        {
            SoDu = SoDu - soTien;
            taiKhoanNhan.SoDu = taiKhoanNhan.SoDu + soTien;

            Console.WriteLine("Chuyen tien thanh cong!");
        }
    }

    // 6. Ham hien thi tai khoan
    public void HienThi()
    {
        Console.WriteLine("So tai khoan: " + SoTaiKhoan);
        Console.WriteLine("Chu tai khoan: " + TenChuTaiKhoan);
        Console.WriteLine("So du: " + SoDu);
    }
}

class Program
{
    static void Main(string[] args)
    {
        TaiKhoanNganHang tk1 = new TaiKhoanNganHang();
        TaiKhoanNganHang tk2 = new TaiKhoanNganHang();

        Console.WriteLine("=== NHAP TAI KHOAN 1 ===");
        tk1.NhapThongTin();

        Console.WriteLine("\n=== NHAP TAI KHOAN 2 ===");
        tk2.NhapThongTin();

        Console.Write("\nNhap so tien can nap vao TK1: ");
        double tienNap = double.Parse(Console.ReadLine());
        tk1.NapTien(tienNap);

        Console.Write("\nNhap so tien can rut tu TK1: ");
        double tienRut = double.Parse(Console.ReadLine());
        tk1.RutTien(tienRut);

        Console.Write("\nNhap so tien chuyen tu TK1 sang TK2: ");
        double tienChuyen = double.Parse(Console.ReadLine());
        tk1.ChuyenTien(tk2, tienChuyen);

        Console.WriteLine("\n=== THONG TIN TAI KHOAN 1 ===");
        tk1.HienThi();

        Console.WriteLine("\n=== THONG TIN TAI KHOAN 2 ===");
        tk2.HienThi();

        Console.ReadKey();
    }
}
