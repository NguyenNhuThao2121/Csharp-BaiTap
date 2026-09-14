namespace Lab01_BTCB_Bai3;
public class Program
{
    public static int tinhtong(int gio, int phut, int giay)
    {
        int tong = gio * 3600 + phut * 60 + giay;
        return tong;
    }
    static void Main()
    {
        Console.WriteLine("nhap gio: ");
        int gio = int.Parse(Console.ReadLine());
        Console.WriteLine("nhap phut: ");
        int phut = int.Parse(Console.ReadLine());
        Console.WriteLine("nhap giay: ");
        int giay = int.Parse(Console.ReadLine());
        Console.WriteLine("tong giay la : " + tinhtong(gio, phut, giay));
    }
}