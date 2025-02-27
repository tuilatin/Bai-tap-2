using System;

class Program
{
    // Định nghĩa enum DayOfWeek
    enum DayOfWeek
    {
        Monday = 2, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }

    // Phương thức lấy tên ngày trong tuần từ enum
    static string GetDayName(DayOfWeek day)
    {
        return day.ToString(); // Chuyển enum thành chuỗi
    }

    static void Main()
    {
        Console.Write("Nhập số từ 2 đến 8 để chọn ngày trong tuần: ");
        if (int.TryParse(Console.ReadLine(), out int dayNumber) && dayNumber >= 2 && dayNumber <= 8)
        {
            DayOfWeek day_144 = (DayOfWeek)dayNumber; // Chuyển số thành enum
            Console.WriteLine($"Ngày bạn chọn là: {GetDayName(day_144)}");
        }
        else
        {
            Console.WriteLine("Vui lòng nhập số hợp lệ từ 2 đến 8.");
        }
    }
}
