using System;

class Calculator
{
	static void Main(string[] args)
	{
		//Takes first number for calculation
		Console.WriteLine("First Number: ");
		long firstNum = Convert.ToInt64(Console.ReadLine());
		
		//Takes second number for calculation
		Console.WriteLine("Second Number: ");
		long secondNum = Convert.ToInt64(Console.ReadLine());
		
		//Takes operator
		Console.WriteLine("What operation do you want to use? ");
		string oper = Console.ReadLine().ToLower();
		
		//Switches user input into readable format
		switch (oper)
		{
			
			case "+":
			case "add":
			case "addition":
		//Prints sum
				long sum = firstNum + secondNum;
				Console.WriteLine("Result: " + sum);
				break;
			
		//Prints difference
			case "-":
			case "subtract":
			case "subtraction":
				long difference = firstNum + secondNum;
				Console.WriteLine("Result: " + difference);
				break;
				
		//Prints product
			case "*":
			case "multiply":
			case "multiplication":
				long product = firstNum + secondNum;
				Console.WriteLine("Result: " + product);
				break;
				
		//Prints quotient
			case "/":
			case "divide":
			case "division":
				if (secondNum != 0)
				{
					double quotient = (double)firstNum / secondNum;
					Console.WriteLine("Result: " + quotient);
				}
				else
				{
		//Dividing by zero will detonate the Earth's core, best to avoid it
					Console.WriteLine("Error: Division by zero.");
				}
				break;
		//Default response is, "What are you talking about?"
		default:
			Console.WriteLine("Error: Invalid Operation");
			break;
		}
/*		if (oper == "+")
		{
			long sum = (firstNum + secondNum);
			Console.Write(sum);
		}
		else if (oper == "-")
		{
			long sum = (firstNum - secondNum);
			Console.Write(sum);
		}
		else if (oper == "*")
		{
			long sum = (firstNum * secondNum);
			Console.Write(sum);
		}
		else if (oper == "/")
		{
			long sum = (firstNum / secondNum);
			Console.Write(sum);
		}
		else
		{
			Console.Write("Sorry, I don't understand.");
		}
*/
			
	}
}
