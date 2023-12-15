using System.ComponentModel;

internal class Program
{
    private static void Main(string[] args)
    {
        int count=-1;
        while (count!=0)
        {   Console.WriteLine("yeu cau bai toan");
            count = int.Parse(Console.ReadLine());  
            Console.WriteLine("Nhap chieu cao cua hinh vuong");
            int height = int.Parse(Console.ReadLine()); 
            Console.WriteLine("Nhap chieu dai cua hinh vuong");
            int width = int.Parse(Console.ReadLine()); 
            switch (count)
            {
                case 1: 
                {
                 Add(height, width);   //day la vi tri goi ham 1   //This.height. This.width
                }
                break;
                case 2: 
                {
                 Add1();                  //Day la vi tri cua ham so 2
                }
                break;
                case 3: 
                {
                 Add2();                //day la vi tri cua ham so 3
                } 
                break;
                case 4:
                {
                    Console.WriteLine(" Chao cac ban dep trai");
                }
                break;
                default:
                Console.WriteLine("Nhap lai");
                break;
            }
            
        }
    }
    static void Add(int height, int width)
    {
     for (int i = 0; i < height; i++)
                  {
                    for (int j = 0; j < width; j++)
                    {
                        Console.Write("*");
                    }
                    Console.Write("\n");
                  }
    }
    static void Add1()
    {
         for (int i = 0; i < 20; i++)
                  {
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.Write("\n");
                  }
    }
    static void Add2()
    {
        for (int i = 0; i < 20; i++)
                      {
                         for (int j = 1; j <= 20 - i; j++)
                         Console.Write(" ");
                         for (int j = 1; j <= 2 * i - 1; j++)
                         Console.Write("*");
                         Console.Write("\n");
                       } 
    }
}