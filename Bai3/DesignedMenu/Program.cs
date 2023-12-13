class Program
{
    private static void Main(string[] args)
    {
        int Choise= -1;
        while (Choise!=0)
        {
            Console.WriteLine("Nhap mot ky tu tu ban phim");
            Choise = Convert.ToInt32(Console.ReadLine());
            switch (Choise)
            {
                case 1:
                {
                Console.WriteLine("************");
                Console.WriteLine("**********");
                Console.WriteLine("********");
                Console.WriteLine("*******");
                Console.WriteLine("******");
                Console.WriteLine("*****");
                Console.WriteLine("****");
                Console.WriteLine("***");
                Console.WriteLine("**");
                Console.WriteLine("*");
                }
                break;
                case 2:
                {
                Console.WriteLine("************");
                Console.WriteLine("************");
                Console.WriteLine("************");
                Console.WriteLine("************");
                Console.WriteLine("************");
                }
                break;
                case 3:
                {
                Console.WriteLine("************");
                Console.WriteLine("************");
                Console.WriteLine("************");
                }
                break;
                case 4:
                {
                    /////
                }
                break;
                default: Console.WriteLine("Nhap lai");
                break;
            }
        }
        //Vi tri ket thuc khi nhap 0
    }
}