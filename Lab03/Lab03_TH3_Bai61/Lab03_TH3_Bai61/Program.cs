using System;
using System.Collections.Generic;

public class He
{
    public string MaHe { get; set; } = "";
    public string TenHe { get; set; } = "";
}

public class DuLieu
{
    public static List<He> DS_He()
    {
        List<He> ds = new List<He>();

        ds.Add(new He
        {
            MaHe = "KTV",
            TenHe = "Kỹ thuật viên"
        });

        ds.Add(new He
        {
            MaHe = "CD",
            TenHe = "Chuyên đề"
        });

        ds.Add(new He
        {
            MaHe = "QT",
            TenHe = "Chứng chỉ quốc tế"
        });

        return ds;
    }
}

class Program
{
    static void Main()
    {
        List<He> dsHe = DuLieu.DS_He();

        foreach (var x in dsHe)
        {
            Console.WriteLine(x.MaHe + " - " + x.TenHe);
        }
    }
}