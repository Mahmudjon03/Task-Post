using Pers;
namespace Teach;

public class Teachar:Person{
   public int numCurses { get; set; }
    public string[] courses { get; set; }

   
    public Teachar(string name,string address):base(name,address)
    {
      }
    public override string ToString()
    {
        return $"teacher-{base.ToString()}";
    }

}
