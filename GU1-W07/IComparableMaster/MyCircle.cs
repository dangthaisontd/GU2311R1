using System;

namespace Shape
{
  public class MyCircle : Circle, IComparable<MyCircle>
  {

    public MyCircle() { }
    public MyCircle(double radius) : base(radius) { }
    public MyCircle(double radius, string color, bool filled) : base(radius, color, filled) { }

    public int CompareTo(MyCircle o)
    {
      if (getRadius() > o.getRadius()) return 1;
      else if (getRadius() < o.getRadius()) return -1;
      else return 1;
    }
  }
}