internal class Program
{
    private static void Main(string[] args)
    {
        string[] s  = {"c","h","a","o"}; 
        Console.WriteLine("Nhap ky tu tu ban phim");
        string inputS = Console.ReadLine();
        Console.WriteLine(inputS);
        int count=0;
        for (int i = 0; i < s.Length; i++)
        {
            if(s[i]==inputS)
            {
             count+=1;
            }
        }
        Console.WriteLine("So ky tu co trong chuoi la"+ count);
    }
}