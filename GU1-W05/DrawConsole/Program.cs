internal class Program
{
private static void Main(string[] args)
    {
    ConsoleKeyInfo keyinfor;
     while (true)
     {
        keyinfor = Console.ReadKey();
        Console.WriteLine(keyinfor.Key);
        if(keyinfor.Key==ConsoleKey.UpArrow||keyinfor.Key==ConsoleKey.W)   ////KeyCode.Space Input.GetAxiz("Horizontal);Input.GetAxix("Vartical);
        {
            Console.WriteLine("Di len");
        }
        if(keyinfor.Key==ConsoleKey.RightArrow||keyinfor.Key==ConsoleKey.D)
        {
            Console.WriteLine("Sang phai");
        }
        if(keyinfor.Key==ConsoleKey.LeftArrow||keyinfor.Key==ConsoleKey.A)
        {
            Console.WriteLine("Sang trai");
        }
        if(keyinfor.Key==ConsoleKey.DownArrow||keyinfor.Key==ConsoleKey.S);
        {
            Console.WriteLine("Lui lai");
        }

    }
     }
}