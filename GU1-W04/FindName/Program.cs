internal class Program
{
    private static void Main(string[] args)
    {
       
       string[] nameList = {"Nam","Thang","Kien","Binh","Bac","Lam","Huy","GiaLinh","Doquyen"};  //1-->n   Chi so 0-->n-1
       Console.WriteLine("Nhap ten ban");
       string name = Console.ReadLine();
       bool isTrue =false;
       int i = 0;
       while (i <= nameList.Length-1)
       {
        if( nameList[i].Equals(name))
        {
            Console.WriteLine("Co ten trong mang va vi tri " +(i+1));
            isTrue=true;
            break;
        }
        i++;
       }
       if(!isTrue)
       {
        Console.WriteLine("Khong co ten trong mang");
       }
    }
}