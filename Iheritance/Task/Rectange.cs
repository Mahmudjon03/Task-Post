namespace Rectan;
using Programm;
public class Rectange: Programm.Shape
{
  int size1;
  int size2;
    public override double Area()
    {
        return  size1*size2;
    }
    public override double Perimeter()
    {
        return 2*(size1+size2);
    }

  
  
  public Rectange(int a,int b)
  {
    size1=a;
    size2=b;
  }
}

