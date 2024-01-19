internal class Program
{
    private static void Main(string[] args)
    {
      try
      {
        try
       {
        int a = 9;
        int b=0;
        int c = a/b;
       }
       catch (ApplicationException e)
       {  
        Console.WriteLine(e.Message);
       }
      }
      catch (DivideByZeroException e)
      {
        Console.WriteLine(e.Message);
      }
      finally
      {
        Console.WriteLine("Thong diep");
      } 
    }
}
