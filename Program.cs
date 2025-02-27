using System;

// Enum for Point color
enum PointColor
{
    LightBlue,
    BloodRed,
    Gold
}
// Point class
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

// Main program
class Program
{
    static void Main()
    {
        // Ví dụ sử dụng
        Point p1_144 = new Point(3, 5, PointColor.Gold);
        Point p2_144 = new Point(7, 2, PointColor.BloodRed);
        // Hiển thị trạng thái
        p1_144.DisplayStatus();
        p2_144.DisplayStatus();
    }
}
