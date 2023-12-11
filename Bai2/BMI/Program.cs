namespace BMI{
class Program
{
    private static void Main(string[] args)
    {
    Console.WriteLine("Nhap Can nang:");
    float weight = float.Parse(Console.ReadLine());
    Console.WriteLine("Nhap Chieu cao:");
    float height = float.Parse(Console.ReadLine());
    Double  BMI = weight/(height*height);
    BMI= Math.Round(BMI,0);
    Console.WriteLine(BMI);
    if(BMI<18)
    {
         Console.WriteLine("Gay");
    }
    else if(BMI<25)   
    {
         Console.WriteLine("Binh thuong");
    }
    else if(BMI<30)   
    {
         Console.WriteLine("Thua can");
    }
    else if(BMI>30)   
    {
         Console.WriteLine("Beo phi");
    }
    else
    {
         Console.WriteLine("Nhap lai");
    }
    }
}
}