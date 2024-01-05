using System.Dynamic;

class Program
{
   static  private void Main(string[] args)
    {
      int a=2;
      double b=4.0f;
      Cat cat1 = new Cat();
      cat1.Tang();
      cat1.chieucao=2;
      Cat cat2 = new Cat();
      Cat cat3 = new Cat();
      cat2.mausac="Mau do";
      Console.WriteLine(cat1.mausac);
      Console.WriteLine(cat2.mausac);
      Console.WriteLine(cat1.chieucao);
    }
}
class ACountBank
{
    private int numberId;
    public int NumberId
    {
        get=>numberId;
        set=>numberId=value;
        
    }
    
}
class Cat
{
    public int chieucao=1;
    private int age=1;
    public string mausac = "Mau vang";
    public string maulong = "Mau do";
    public string maumat = "Mau xanh";
    public string Riamep="co ria mep";
    public static int dai=2;  //ref,out
    void An()
    {

    }
    void Nhay()
    {

    }
   public void Tang()
    {
        age+=1;
    }
    //P.J(s, ros, T);
}
