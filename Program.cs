using System;
class Program
{
    // Phương thức tính lương với tham số tùy chọn
    static double TinhLuong(double luongCoBan_144, double thuong = 0, double phuCap = 500000)
    {
        return luongCoBan_144 + thuong + phuCap;
    }

    static void Main()
    {
        // Gọi hàm với các cách truyền tham số khác nhau
        Console.WriteLine("Lương với chỉ lương cơ bản: " + TinhLuong(10000000));
        Console.WriteLine("Lương với lương cơ bản và thưởng: " + TinhLuong(10000000, 2000000));
        Console.WriteLine("Lương với cả ba tham số: " + TinhLuong(10000000, 2000000, 1000000));
    }
}