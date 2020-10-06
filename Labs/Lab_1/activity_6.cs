/*
 Write a static method named DivideWithoutOperator which takes two
values dividend and divisor and displays result of division in console. 

*/
using System;
namespace ConsoleApplication3
{
    class program6
    {
        static void Main(string[] args)
        {
            int num_1 =  int.Parse(Console.ReadLine());
            int num_2 =  int.Parse(Console.ReadLine());
            
            Console.writeLine(num_1%num_2);
            Console.writeLine(num_1/num_2);
            
        }
    }
}
