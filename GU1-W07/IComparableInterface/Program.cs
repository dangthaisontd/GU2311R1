using System;
using System.Collections;
using System.Linq;
internal class Program
{
    private static void Main(string[] args)
    {
       
    }
}
public class Cat : IComparable
{
    double temperatureF;
    public int CompareTo(object? obj)
    {
        if(obj==null) return 1;
        Cat mycat = obj as Cat;
       if(mycat!=null)
       {
        return this.temperatureF.CompareTo(mycat.temperatureF);
       }
       else
       {
        throw new NotImplementedException();
       }

    }
}
public class Dog : IComparer
{
    public int Compare(object? x, object? y)
    {
        throw new NotImplementedException();
    }
}