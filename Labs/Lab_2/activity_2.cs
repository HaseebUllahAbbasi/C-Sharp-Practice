using System;
namespace simple
{
	public class program_1
	{
		public static void Main(string[] args)
		{
		
            int number_1 = int.Parse(Console.ReadLine());
			int number_2 = int.Parse(Console.ReadLine());
			string operation  = Console.ReadLine();; 
            if(operation == "+")
			{
				Console.WriteLine(number_1+number_2);
			}
            else if(operation == "-")
			{
				Console.WriteLine(number_1-number_2);
			}
            else if(operation == "*")
			{
				Console.WriteLine(number_1*number_2);
			}
            else if(operation == "/")
			{
				Console.WriteLine(number_1/number_2);
			}
            else if(operation == "%")
			{
				Console.WriteLine(number_1%number_2);
			}

		}
	}
}
