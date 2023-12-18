internal class Program
{
    private static void Main(string[] args)
    {
       int sumnerList=0;
       int[] myList = {1,2,3,4,5,6,7,8,9,10};
       Console.WriteLine("Tong cua mang la");
       for (int i = 0; i <= myList.Length-1; i++)    //for (int i = 0; i < myList.Length; i++)
       {
        sumnerList += myList[i];   // sumnerList = sumnerList + myList[i]; 
       }
       Console.WriteLine(sumnerList);
    }
}