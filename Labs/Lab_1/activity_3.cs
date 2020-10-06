using System;
namespace simple
{
	public class program_1
	{
		public static void Main(string[] args)
		{
		
            int number_1 = int.Parse(args[1];
			int number_2 = int.Parse(args[2];
			string operation  = args[0]; 
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
