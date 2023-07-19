

Data time=new Data(2005,1,02);
System.Console.WriteLine(time.getYear());
System.Console.WriteLine(time.getMonth());
System.Console.WriteLine(time.getDay());
time.Year(2004);
time.Month(1);
time.Day(09);
time.toString();

//----------------------CLASS------------------------//

public class Data{
 int _Year;
 int _Month;
  int _Day;
 
    public int getYear(){
 return _Year; 
 } 
     public string getMonth(){
 return _Month.ToString(); 
 }
     public int getDay(){
       return _Day; 
 }
 public void Year(int year){
   
    _Year=year;
 }
 public void Month(int month){
   if(month>0 && month<32 ){
    _Month=month;
    }else{
      System.Console.WriteLine("Error");
    }

 }
 public void Day(int day){
   if(day>0 && day<32 ){
    _Day=day;
    }else{
      System.Console.WriteLine("Error");
    }
 }
  public Data(int year, int month, int day)
  { if(year>1000 && year<9999){_Year=year;}else{System.Console.WriteLine("Error");}
   if(month>0 && month<=12){_Month=month;}else{System.Console.WriteLine("Error");}
    if(day>0 && day<32){ _Day=day;} else{System.Console.WriteLine("Error");}
    }  
 public void toString(){
   Convert.ToString(_Day);
    System.Console.WriteLine($"{_Day} : {Convert.ToString(_Month)} : {_Year.ToString()}");
     }
}

                                                                                                                      
