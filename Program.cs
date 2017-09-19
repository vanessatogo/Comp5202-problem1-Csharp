using System;

namespace _9960471_problem01_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Hello this programe will ask for two number input and show which of the two numbers are higher ");
        //tell user what the programme does
        Console.ReadLine();
        Console.WriteLine("Please enter your first number");//ask user for input
           var num1 = Console.ReadLine();
        Console.WriteLine("Please enter your second number");
           var num2 = Console.ReadLine();
            if(num1<num2);//calculate which of the 2 are higher
            {
        Console.WriteLine("Your first number is higher than you second number");
           }

           else(num2<num1);
           
            {
            //out put the answer
        Console.WriteLine("Your second number is higher than your first number");
            }
        }
    }
}
