using System;

enum OrderStatus
{
    Pending,      // Chờ xử lý
    Processing,   // Đang xử lý
    Shipped,      // Đã giao hàng
    Delivered,    // Đã nhận hàng
    Cancelled     // Đã hủy
}

class Program
{
    static void Main()
    {
        Console.Write("Nhập trạng thái đơn hàng (0-4): ");
        if (int.TryParse(Console.ReadLine(), out int statusNumber) && statusNumber >= 0 && statusNumber <= 4)
        {
            OrderStatus status_144 = (OrderStatus)statusNumber;

            Console.WriteLine($"Trạng thái (EN): {GetOrderStatusDescription(status_144)}");
            Console.WriteLine($"Trạng thái (VI): {GetOrderStatusDescription(status_144, "vi")}");
        }
        else
        {
            Console.WriteLine("Trạng thái không hợp lệ!");
        }
    }

    static string GetOrderStatusDescription(OrderStatus status, string language = "en")
    {
        switch (language.ToLower())
        {
            case "vi":
                return status switch
                {
                    OrderStatus.Pending => "Chờ xử lý",
                    OrderStatus.Processing => "Đang xử lý",
                    OrderStatus.Shipped => "Đã giao hàng",
                    OrderStatus.Delivered => "Đã nhận hàng",
                    OrderStatus.Cancelled => "Đã hủy",
                    _ => "Không xác định"
                };

            default:
                return status.ToString(); // Trả về tên tiếng Anh mặc định
        }
    }
}
