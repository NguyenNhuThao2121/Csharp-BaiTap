public class Program
{
    public static double TinhY1(double x)
    {
        return 4 * (Math.Pow(x, 2) + 10 * Math.Sqrt(x) * x + 3 * x + 1);
    }

    public static double TinhY2(double x)
    {
        return (Math.Sin(Math.PI * Math.Pow(x, 2)) + Math.Sqrt(Math.Pow(x, 2) + 1))
            / (Math.Pow(Math.E, 2 * x) + Math.Cos(Math.PI / 4 * x));
    }

    static void Main()
    {
        Console.Write("Nhap x: ");
        double x = double.Parse(Console.ReadLine());
        double y1 = TinhY1(x);
        double y2 = TinhY2(x);
        Console.WriteLine("y1 = " + Math.Round(y1, 2));
        Console.WriteLine("y2 = " + Math.Round(y2, 2));
    }
}