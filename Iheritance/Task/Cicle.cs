using Programm;

public class Circle:Shape{
  int radius ;
  public Circle(int s)
  {
    radius=s;
  }
    public override double Area()
    {
        return 3.14*radius*radius;
    }
    public override double Perimeter()
    {
        return 2*3.14*radius;
    }
};


