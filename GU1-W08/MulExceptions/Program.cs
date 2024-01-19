internal class Program
{
    private static void Main(string[] args)
    {
       
       try
       {
         int[] myArray = new int[5]{1,2,3,4,5};
         int a = myArray[10];
         Console.WriteLine(" Vi tri toa do cua lenh");
       }
       catch (ArgumentException e)
       {
        Console.WriteLine(e.Message);
       }
       catch (ArithmeticException e)
       {
        Console.WriteLine(e.Message);
       }
       catch (System.Exception e)
       {
        Console.WriteLine(e.Message);
       }
       finally
       {
         Console.WriteLine("Giai phong bo nho");
       }
    }
}
