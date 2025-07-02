// See https://aka.ms/new-console-template for more information

/*bool isRainy = true;
bool hasUmbrella = false;

if (isRainy && !hasUmbrella)
{
    Console.WriteLine("I am wet");
}
Console.ReadKey();
*/

int num1 = 0;
int num2 = 0;
int age = 0;
bool isEqual = num1 == num2;
bool isNotEqual = num1 != num2;

Console.WriteLine("Please enter a number");
if(num1 == int.Parse(Console.ReadLine()))
{
    Console.WriteLine("Numbers are equal");

    Console.WriteLine("Please enter your age");
    age = int.Parse(Console.ReadLine());
    if (age >= 18)
    {
        Console.WriteLine("Enter your preffered prize");
        string prize = Console.ReadLine();
    }
    else
    {
        Console.WriteLine("Sorry too young");
    }
}
else
{
    Console.WriteLine("Sorry wrong choice");
}
Console.WriteLine(age); 
Console.ReadKey();
