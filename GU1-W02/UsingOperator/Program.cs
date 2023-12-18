
using System;
namespace UsingOperator
{
 class Program
{
    private static void Main(string[] args)
    {
        float width;
        float height;
        Console.WriteLine("Nhap gia tri cho hinh chu nhat");
        Console.WriteLine("Nhap chieu rong: ");
        width = float.Parse(Console.ReadLine());
        Console.WriteLine("Nhap chieu cao: ");
        height = float.Parse(Console.ReadLine());
        Console.WriteLine("Dien tich hinh chu nhat la:" + width*height);
       
    }
}
}