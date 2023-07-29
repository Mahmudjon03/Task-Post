int n,s;


Laptop lap =new Laptop(2,8,128,"abcd");
lap.GetInfo();
lap.WeightCheck();
System.Console.WriteLine("addram :");
n=Convert.ToInt32(Console.ReadLine());
lap.AddRam(n);
System.Console.WriteLine("addStorge");
s=Convert.ToInt32(Console.ReadLine());
lap.AddStoage(s);
lap.GetInfo();


var phone =new Smarthone(0,18,256,"gfds");

phone.GetInfo();
phone._Selfies();
 phone.AddRam(8);
 phone.addStorge(256)
phone.GetInfo();


public class Computer{
    private readonly string keyboard;

    public int Ram { get; set; }
    public int Storge { get; set; }
    public string Keyboard { get; set; }
    public Computer(int ram,int storge,string keyboard)
    {
        Ram = ram;
        Storge = storge;
        Keyboard = keyboard;
    }

    

    public void AddRam(int a)
    {
            Ram+=a;
    }
    public  void AddStoage(int b){
 Storge+=b;
    }
} 
public class  Smarthone:Computer{
public int Selfies { get; set; }
public Smarthone (int selfies ,int ram  ,int storge,string keyboard): base (ram,storge,keyboard)
{}
public void GetInfo(){
    System.Console.WriteLine($"Ram={Ram}");
    System.Console.WriteLine($"storge={Storge}");
    System.Console.WriteLine($"Keyboard={Keyboard}");
    System.Console.WriteLine($"Weight={Selfies}");
 
}

public void _Selfies(){
    Selfies++;
    }
}
public class Laptop:Computer{
    public int Weight { get; set; }
    
public Laptop( int weight,  int ram  ,int storge,string keyboard): base (ram,storge,keyboard)
{
    Weight=weight;
}
public void WeightCheck(){
    if(Weight>=3){
        System.Console.WriteLine($"Fuuuuuuuuuu");
    }else{
        System.Console.WriteLine($"Normal laptop");
    }
}
public void GetInfo(){
    System.Console.WriteLine($"Ram={Ram}");
    System.Console.WriteLine($"storge-{Storge}");
    System.Console.WriteLine($"Keyboard-{Keyboard}");
    System.Console.WriteLine($"Weight={Weight}");
 
}


   
}

