namespace PracticeApp
{
	internal class Program
	{
		static void Main(string[] args)
		{
			bool continueApp = true;
			while (continueApp)
			{
				Console.WriteLine("CommandIt:");
				string command = Console.ReadLine();
				switch (command.ToLower())
				{
					case "help":
						{
							Console.WriteLine("""
								help -to get the list of commands
								calc -to open calculator mode
								exit() -to exit
								""");
							break;
						}
					case "exit()":
						{
							continueApp = false;
							break;
						}
					case "calc":
						{
							bool exitCalc = false;
							while (!exitCalc)
							{
								Console.Write("enter the first number: ");
								double num1 = double.Parse(Console.ReadLine());
								Console.Write("enter the operator(+,-,*,/,**): ");
								string calcOperator = Console.ReadLine();
								Console.Write("enter the second number: ");
								double num2 = double.Parse(Console.ReadLine());
								switch (calcOperator)
								{
									case "+":
										{
											Console.WriteLine($"{num1} + {num2} = " + ( num1 + num2 ));
											break;
										}
									case "-":
										{
											Console.WriteLine($"{num1} - {num2} = " + ( num1 - num2 ));
											break;
										}
									case "*":
										{
											Console.WriteLine($"{num1} * {num2} = " + ( num1 * num2 ));
											break;
										}
									case "/":
										{
											if (num2 == 0)
											{
												Console.WriteLine("Can't divide by zero!");
												break;
											}
											Console.WriteLine($"{num1} / {num2} = " + num1 / num2);
											break;
										}
									case "**":
										{
											Console.WriteLine($"{num1} ** {num2} = " + Math.Pow(num1 , num2));
											break;
										}
								}
								bool exitOrNot = true;
								while (exitOrNot)
								{
									Console.Write("Calculate again?(Y/N)");
									string CalcContinue = Console.ReadLine().ToLower();
									if (CalcContinue == "n")
									{
										exitCalc = true;
										exitOrNot = false;
									}
									else if (CalcContinue == "y")
									{
										exitOrNot = false;
									}
									else
									{
										Console.WriteLine("sorry didn't understand");
									}
								}
							}
							break;
						}
					default:
						{
							Console.WriteLine("sorry didn't understand");
							Console.WriteLine("write help to see the commands list");
							break;
						}
				}
			}
		}
	}
}
