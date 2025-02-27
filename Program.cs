using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhập số lượng sinh viên: ");
        if (int.TryParse(Console.ReadLine(), out int count) && count > 0)
        {
            string[] students_144 = new string[count];

            // Nhập danh sách sinh viên
            for (int i = 0; i < count; i++)
            {
                Console.Write($"Nhập tên sinh viên {i + 1}: ");
                students_144[i] = Console.ReadLine();
            }

            // In danh sách sinh viên bằng foreach
            Console.WriteLine("\nDanh sách sinh viên:");
            foreach (string student in students_144)
            {
                Console.WriteLine($"- {student}");
            }
        }
        else
        {
            Console.WriteLine("Số lượng không hợp lệ!");
        }
    }
}
