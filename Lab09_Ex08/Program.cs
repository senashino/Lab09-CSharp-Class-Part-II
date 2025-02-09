Circle.PrintCircleArea(100);

class Circle
{
    public static void PrintCircleArea(double radius)
    {
        double PI = 3.14159;
        PI = 3.14159265359;
        System.Console.WriteLine($"Radius = {radius}, Area = {PI * radius * radius}");
    }
}