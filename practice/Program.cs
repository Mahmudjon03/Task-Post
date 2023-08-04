


//-----------------------------OBJECTE------------------------------//
var poslist=new List<Post>();
var pos1 =new Post()
{
    Title = "Post1",
    Deskription = "this is test post ",
    Data = new DateTime(2023, 07, 17),
    likeCount=1,
    

};
 pos1.Comment("this is super post");
 pos1.Comment("this is super 2 ");
 System.Console.WriteLine();
   pos1.Data = new DateTime(2023,07,18);
   System.Console.WriteLine(pos1.Data);
  pos1.Like();
 pos1.Like();
 System.Console.WriteLine($"Number of likes {pos1.likeCount}");
 foreach (var commen in pos1.Comments)

 {
    System.Console.WriteLine("comment :"+ commen);
 }
 var pos2 =new Post()
{
    Title = "Post1",
    Deskription = "this is test post ",
    Data = new DateTime(2023, 07, 17),
    likeCount=1,
    

};
 pos2.Comment("this is super post");
 pos2.Comment("this is super 2 ");
   pos2.Data = new DateTime(2023,07,17);
    System.Console.WriteLine();
   System.Console.WriteLine(pos2.Data);
  
  pos2.Like();
 pos2.Like();
  pos2.Like();   pos2.Like();
 System.Console.WriteLine($"Number of likes {pos2.likeCount}");
 foreach (var commen in pos2.Comments)

 {
    System.Console.WriteLine("comment :"+ commen);
 }
  var pos3 =new Post()
{
    Title = "Post1",
    Deskription = "this is test post ",
    Data = new DateTime(2023, 07, 17),
    likeCount=1,
    

};
 pos3.Comment("this is super post");
 pos3.Comment("this is super 2 ");
   pos3.Data = new DateTime(2023,07,17);
   System.Console.WriteLine();
   System.Console.WriteLine(pos3.Data);

  pos3.Like();
 pos3.Like();
  pos3.Like();   
 System.Console.WriteLine($"Number of likes {pos3.likeCount}");
 foreach (var commen in pos3.Comments)

 {
    System.Console.WriteLine("comment :"+ commen);
 }

poslist.Add(pos1);
poslist.Add(pos2);
poslist.Add(pos3);
foreach (var pos in poslist){
    

    System.Console.WriteLine(pos);
}
{
    
}




//------------------------------CLASS------------------------------//


   public class  Post{
     public string Title { get; set; }
     public string Deskription { get; set; }
     public DateTime Data;
     public int likeCount=0; 
     public List<string> Comments;

     public void Publish(){
System.Console.WriteLine($"Your post is Publishing . . . 40");
System.Console.WriteLine($"Your post is Publishing . . . 60");
System.Console.WriteLine($"Your post is Publishing . . . 70");
System.Console.WriteLine($"Your post is Publishing . . . 100");
System.Console.WriteLine($"Your post has been publishing");
    }
    public void Like(){
     likeCount++;   
     
    }
    public void Comment(string text){
        if(Comments == null) Comments=new List<string>();
           Comments.Add(text);
          }
          }


   


   
