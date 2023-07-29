public class Point3D:Point2D{
    int _z;
    public Point3D()
    {_z=6;
    }
public Point3D(int x,int y,int z):base(x,y)
{
    _x=x;
    _y=y;
    _z=z;
}
public void GetZ(){
    System.Console.WriteLine($"z={_z}");
} 
public void SetZ(int z){
    _z=z;
}
    public override string ToString()
    {
        return $"x={_x},y={_y},z={_z}";
    }
   }