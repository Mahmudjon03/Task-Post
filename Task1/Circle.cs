Circle cir1=new Circle(1.2 ,"red");
cir1.getRadius();
cir1.getColor();
cir1.getArea();

Circle cir2=new Circle(1.3);
System.Console.WriteLine();
cir2.color="green";
cir2.getRadius();
cir2.getColor();
cir2.getArea();

Circle cir3=new Circle();
System.Console.WriteLine();
cir3.color="blue";
cir3.Radius=2.1;
cir3.getRadius();
cir3.getColor();
cir3.getArea();

//----------------ClASS-----------------//

public class Circle{
    public double Radius { get; set; }
   
  public string color { get; set; }
  public Circle()
  {
    
  }
 
  public Circle(double radius)
  {
    Radius=radius;
   

  }

  public Circle(double rd,string clr){
    Radius=rd;
      color=clr;
  }
  public void getRadius(){
  System.Console.WriteLine(Radius);
  }
  public void getColor(){
    System.Console.WriteLine(color);
  }
  public void getArea(){
    System.Console.WriteLine(Radius*3.14*2);
  }
} 



 




