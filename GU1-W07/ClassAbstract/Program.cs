using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
       
    }
}
public interface IDamage
{
    void Health();
    void Death();

}
public interface Iatach
{
 void Fire();
 void Melee();
}
public abstract class Animal
{
public abstract void Eat();
public abstract void Sleep();
}
public class Cat : Animal,IDamage,Iatach
{
    public void Death()
    {
        
    }

    public override void Eat()
    {
       
    }

    public void Fire()
    {
      
    }

    public void Health()
    {
        
    }

    public void Melee()
    {
        
    }

    public override void Sleep()
    {
        
    }
}
public class Dog : Animal, IDamage
{
    public void Death()
    {
        
    }

    public override void Eat()
    {
       
    }

    public void Health()
    {
        
    }

    public override void Sleep()
    {
        
    }
}
//Goij phuong thuc Death()
public class tiger : IDamage
{
    int health=1000;
    bool isDead=false;
    public void Death()
    {
        if(health<0)
        {
         isDead=true;
        }
    }
    public void Health()
    {
        health-=1;
    }
}
public class Chicken: IDamage
{
    int health=200;
    bool isStar=true;
    bool isDead=false;
    public void Death()
    {
       health-=10;
    }
    public void Health()
    {
       if(health<0 && !isStar)
       {
        isDead=true;
       }
    }
}
public class Bullet( int other)
{
      //other.Health();
}
public interface Effect
{
  void Efect();
}

public class Water : Effect
{
    public void Efect()
    {
        Console.WriteLine("Ban nuoc len");
    }
}
public class Steel:Effect
{
    public void Efect()
    {
        Console.WriteLine("Sinh ra tia lua dien");
    }
}
public class Wood: Effect
{
 public void Efect()
    {
        Console.WriteLine("Tao ra lo tren go");
    }
}

