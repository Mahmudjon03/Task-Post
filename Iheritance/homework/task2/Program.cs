using Pers;
using Studen;
using Teach;

var str=new Student("Ahmad","Vahdat");
str.numCurses=10;
str.courses=new string[]{"aaaa","sfesfse","wfeff"};
str.grades=new int[]{70,80,99,98,100};
str.PrinteGrande();
System.Console.WriteLine();
str.AverangeGrande();
System.Console.WriteLine(str.ToString());
System.Console.WriteLine("\\------------------------------------------------------------------//");
var teach=new Teachar("Ustod","Norak");
teach.numCurses=3;
teach.courses=new string[]{"1kurs","2kurs","3kurs"};
System.Console.WriteLine(teach.ToString());






