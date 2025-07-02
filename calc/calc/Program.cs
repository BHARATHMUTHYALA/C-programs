// See https://aka.ms/new-console-template for more information
using System.Numerics;

Console.WriteLine("Enter first number!");
double myNumber1;
string userInput = Console.ReadLine();
myNumber1 = double.Parse(userInput);

Console.WriteLine("Enter second number");
double myNumber2;
string userInput2 = Console.ReadLine();
myNumber2 = Convert.ToDouble(userInput2);

double Addition = myNumber1 + myNumber2;
Addition = Math.Round(Addition, 2);
Console.WriteLine("Addition is "+ Addition);

double Multiplication = myNumber1 * myNumber2;
Console.WriteLine("Multiplication is " +Multiplication );

double Division = myNumber1 / myNumber2;
Console.WriteLine("Division result is "+Division);
Console.ReadKey();
