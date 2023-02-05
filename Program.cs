using System;
class Program{
    public static void Main(string[]args){
        double Input, ans;
        Console.WriteLine("Input number:");
        Input = double.Parse(Console.ReadLine());

        Console.WriteLine("Ans:");
        Console.WriteLine(Cal(Input));
}
    public static double Cal(double Input)
    {
       if(Math.Pow(Input,2)<4 || Math.Pow(Input,2)==4){
         return 2;
       }
       else{
         double ans = 1+Cal(Input - (4*Math.Abs(Input)/Input));
         return ans;
       }
    }
}