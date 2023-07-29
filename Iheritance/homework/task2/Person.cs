



namespace Pers;

public class Person{
    public string Name { get; set; }
    public  string Address { get; set; }

    public Person(string name,string address)
    {
        Name = name;
        Address = address;
    }
    public void GetName(){
        System.Console.WriteLine(Name);
    }
    public void GetAddress(){
        System.Console.WriteLine(Address);
    }
    public void SetAddress(string addres){
   Address=addres;
    }
    public override string ToString(){
        return $"name - {Name}  address - {Address} ";

    }
}

