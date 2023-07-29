using Logo;
namespace Programm;
public class Shape{
  public Locition c =new Locition();
    public override string ToString()
    {
        return $"Location :{c.x},{c.y}";
    }
public virtual double Area(){
  return 0;
}
public virtual double Perimeter(){
return 0;
}
}


