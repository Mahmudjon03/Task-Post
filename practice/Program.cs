

//-----------------------------OBJECTE------------------------------//

var pos =new Post()
{
    Title = "Softclub",
    Deskription = "Free Lesson",
    Data = new DateTime(2023, 07, 17)
    
};
System.Console.WriteLine(pos.Title);
System.Console.WriteLine(pos.Deskription);
System.Console.WriteLine(pos.Data);
pos.Publish();
pos.Like(1);
System.Console.WriteLine($"Like: {pos.Like(1)}");
System.Console.Write($"Comment : ");
string comment=Console.ReadLine();
pos.Comment(comment);


//------------------------------CLASS------------------------------//


   public class  Post{
     public string Title { get; set; }
     public string Deskription { get; set; }
     public DateTime Data;


     public void Publish(){
System.Console.WriteLine($"Text is Publish");
    }
    public int Like(int n){
        n++;
     return n;
    }
    public string Comment(string comment){
        return comment;
    }
    

   }


   