internal class Program
{
    private static void Main(string[] args)
    {
       int n;
       Console.WriteLine("nhap kich thuoc mang");   //nhap kinh thuoc mang
       n = Convert.ToInt32(Console.ReadLine());
       int[] array = new int[n+1];
       for (int i = 0; i < n; i++)                 //nhap kich thuoc mang
       {
        Console.WriteLine("nhap phan tu mang: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
       }
        Console.WriteLine("Mang co cac phan tu la: ");   //in ra man hinh mang da nhap
        for (int i = 0; i < n; i++)
       {
        Console.Write(array[i]+"\t");   
       }
       Console.Write("\n");                    
       Console.WriteLine("nhap so can chen:");            //Nhap so can chen vao mang
       int x = Convert.ToInt32(Console.ReadLine());
       Console.WriteLine("nhap vi tri can chen:");       //nhap vi tri chen
       int p = Convert.ToInt32(Console.ReadLine());
       for (int i = n; i >= p; i--)                      //dich sang phai 1 vi tri va hoan doi gia tri
       {
         array[i] = array[i-1];
       }
       array[p-1] =x;                                    //chen X vao vi tri can
       for (int i = 0; i <=n; i++)                       //in ra toan bo mang do bao gom ca vi tri lon nhat
       {
        Console.Write(array[i]+"\t");   
       }
    }
}