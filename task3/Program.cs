//------------------OBJECTE------------------//
var birds =new int []{2,0,5,3,7,8,4};
var birdCount=new BirdCount(birds);
      birdCount.Birds=false;
var lastWeek=birdCount.LastWeek();
foreach (var bird in lastWeek){
    System.Console.Write(bird+",");
}
birdCount.Today();
birdCount.IcrementTodaysCount();
birdCount.Today();
birdCount.HasDayscount();

System.Console.WriteLine(birdCount.Birds);
System.Console.WriteLine(birdCount.BusyDays(4));

System.Console.WriteLine(birdCount.DaySum());


    

//--------------------CLASS---------------//

public class BirdCount{
    int[] _birdPerDay;
   public bool Birds { get; set; }
    public BirdCount(int[] birdPeyDay)
    {
        _birdPerDay=birdPeyDay;
    } 
    public int[] LastWeek(){
        return _birdPerDay;
    }
    public void Today(){
        System.Console.WriteLine();
        System.Console.Write("Today:");
        System.Console.WriteLine(_birdPerDay[_birdPerDay.Length-1]);
    }
    public void IcrementTodaysCount(){
        _birdPerDay[_birdPerDay.Length-1]++;
         }
         public void HasDayscount(){
            for (int i = 0; i < _birdPerDay.Length; i++){
                if(_birdPerDay[i]==0){
                    Birds=true;
                   
                    break;
                }else{
                    
              Birds=false;                 
        }  }
              }
              public int BusyDays(int day){
                int n=0;
                for (int i = 0; i < day; i++){
                    n+=_birdPerDay[i];
                }
                 return n;
              } 
              public int DaySum(){
                int f=0;
                for (int i = 0; i <_birdPerDay.Length; i++)
                {
                    if (_birdPerDay[i]>5){
                        f++;
                    }
                  }
                  return f;
              }
   }
