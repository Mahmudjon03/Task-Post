using Pers;
namespace Studen;
public class Student:Person{
    public int numCurses { get; set; }
    public string[] courses { get; set; }

    public int[] grades { get; set; }
    

    public Student(string name,string address):base(name,address)
    {
        Name=name;
        Address = address;
    }
    public void AddCurceGrande(string curse,int grande){

    }
    public void PrinteGrande(){
         foreach (var item in grades)
         {
          System.Console.WriteLine(item);  
         }
         }

         public void AverangeGrande(){
            int n=0,s=0;
            foreach (var item in grades)
            {
                n+=item;
                s=n/5;
            }
            System.Console.WriteLine(s);
             }
    public override string ToString()
    {
        return $"student: {base.ToString()}";
    }
}
