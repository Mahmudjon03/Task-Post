public class Point2D{
    public int _x { get; set; }

public int _y { get; set; }   
 public Point2D()
    {
        _x=12;
        _y=21;
    }
    public Point2D(int x,int y)
    {
        _x = x;
        _y = y;
    }
    public void GetX(){
        System.Console.WriteLine($"x= {_x}");
    }
    public void SetX(int xx){

           _x=xx;
    }
    public void GetY(){
    System.Console.WriteLine($"y={_y}");
    }
    public void  SetY(int yy){
        yy=_y;  
      }
    public override string ToString()
    {
        return $"x={_x},y={_y}";
    }
    }
