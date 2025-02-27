using System;

// Enum for Point color
enum PointColor
{
    LightBlue,
    BloodRed,
    Gold
}

// class điểm
class Point
{
    public int X { get; set; }
    public int Y { get; set; }
    public PointColor Color { get; set; }

    public Point(int x, int y, PointColor color)
    {
        X = x;
        Y = y;
        Color = color;
    }

    public void DisplayStatus()
    {
        Console.WriteLine($"Point({X}, {Y}), Color: {Color}");
    }
}

// class hình chữ nhật
class Rectangle
{
    public Point UpperLeft { get; set; }
    public Point BottomRight { get; set; }

    public Rectangle(Point upperLeft, Point bottomRight)
    {
        UpperLeft = upperLeft;
        BottomRight = bottomRight;
    }

    public void DisplayStatus()
    {
        Console.WriteLine("Rectangle:");
        UpperLeft.DisplayStatus();
        BottomRight.DisplayStatus();
    }
}

// chương trình chạy
class Program
{
    static void Main()
    {
        // ví dụ sử dụng 
        Point upperLeft_144 = new Point(0, 10, PointColor.LightBlue);
        Point bottomRight_144 = new Point(10, 0, PointColor.BloodRed);

        Rectangle rect = new Rectangle(upperLeft_144, bottomRight_144);

        // hiển thị kết quả
        rect.DisplayStatus();
    }
}
