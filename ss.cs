using System;
namespace Ss;
public class ss{
public static void Main(){
Console.Write("enter the number size :");
var num=Convert.ToInt32(Console.ReadLine());
var arr=new int [num];  

for (var i=0;i<num;i++){
     Console.Write("enter the num"+(i+1) +":");
     arr[i]=Convert.ToInt32(Console.ReadLine());
}

var max=arr[0];
for (var i=1;i<num;i++){
     if (arr[i]>max){
        max=arr[i];
     }
}
Console.WriteLine("the max is :" +max);
}
}