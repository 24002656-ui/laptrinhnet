///bai6///

using System;

abstract class NhanVien
{
    public string MaNV;
    public string HoTen;

    public NhanVien(string ma, string ten)
    {
        MaNV = ma;
        HoTen = ten;
    }

    public abstract double TinhLuong();

    public void HienThi()
    {
        Console.WriteLine("Ma NV: " + MaNV);
        Console.WriteLine("Ho ten: " + HoTen);
        Console.WriteLine("Luong: " + TinhLuong());
    }
}

class NhanVienVanPhong : NhanVien
{
    public double LuongCoBan;
    public int SoNgayCong;

    public NhanVienVanPhong(string ma, string ten,
        double luong, int ngay) : base(ma, ten)
    {
        LuongCoBan = luong;
        SoNgayCong = ngay;
    }

    public override double TinhLuong()
    {
        return LuongCoBan * SoNgayCong / 26;
    }
}

class NhanVienKinhDoanh : NhanVien
{
    public double LuongCoBan;
    public double DoanhSo;

    public NhanVienKinhDoanh(string ma, string ten,
        double luong, double doanhSo) : base(ma, ten)
    {
        LuongCoBan = luong;
        DoanhSo = doanhSo;
    }

    public override double TinhLuong()
    {
        return LuongCoBan + DoanhSo * 0.02;
    }
}

class GiangVien : NhanVien
{
    public double LuongMoiTiet;
    public int SoTiet;

    public GiangVien(string ma, string ten,
        double luong, int tiet) : base(ma, ten)
    {
        LuongMoiTiet = luong;
        SoTiet = tiet;
    }

    public override double TinhLuong()
    {
        return LuongMoiTiet * SoTiet;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("1. Nhan vien van phong");
        Console.WriteLine("2. Nhan vien kinh doanh");
        Console.WriteLine("3. Giang vien");
        Console.Write("Chon loai nhan vien: ");
        int loai = int.Parse(Console.ReadLine());

        Console.Write("Nhap ma nhan vien: ");
        string ma = Console.ReadLine();

        Console.Write("Nhap ho ten: ");
        string ten = Console.ReadLine();

        NhanVien nv;

        if (loai == 1)
        {
            Console.Write("Nhap luong co ban: ");
            double luong = double.Parse(Console.ReadLine());

            Console.Write("Nhap so ngay cong: ");
            int ngay = int.Parse(Console.ReadLine());

            nv = new NhanVienVanPhong(ma, ten, luong, ngay);
        }
        else if (loai == 2)
        {
            Console.Write("Nhap luong co ban: ");
            double luong = double.Parse(Console.ReadLine());

            Console.Write("Nhap doanh so: ");
            double doanhSo = double.Parse(Console.ReadLine());

            nv = new NhanVienKinhDoanh(ma, ten, luong, doanhSo);
        }
        else if (loai == 3)
        {
            Console.Write("Nhap luong moi tiet: ");
            double luong = double.Parse(Console.ReadLine());

            Console.Write("Nhap so tiet day: ");
            int tiet = int.Parse(Console.ReadLine());

            nv = new GiangVien(ma, ten, luong, tiet);
        }
        else
        {
            Console.WriteLine("Loai nhan vien khong hop le!");
            return;
        }

        Console.WriteLine("\n=== THONG TIN NHAN VIEN ===");
        nv.HienThi();

        Console.ReadKey();
    }
}
