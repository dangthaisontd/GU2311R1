internal class Program
{
    private static void Main(string[] args)
    {
        Man[] myMan = {new Man{name="Tuan",age=8},
                       new Man{name="Minh",age=1},
                       new Man{name="Hang",age=10},
                       new Man{name="Hang",age=15},
                      };
        IEnumerable<Man> query = myMan.OrderBy(x=>x.age);
        foreach (var item in query)
        {
            //Console.WriteLine(item.name+item.age);
        }

        Item[] myItem = {new Item{coin="x1000",price = 9.99f},
                         new Item{coin="x10000",price = 6.99f},
                         new Item{coin="x50000",price = 4.99f},
                         new Item{coin="x200000",price = 5.99f}};
        IEnumerable<Item> queryItem = myItem.OrderBy(x=>x.price);
        foreach (var item in queryItem)
        {
            Console.WriteLine(item.coin+"  "+item.price);
        }
    }
}
public class Man
{
public string name{get;set;}
public int age{get;set;}
}
public class Item
{
    public string coin{get;set;}
    public float price{get;set;}
}