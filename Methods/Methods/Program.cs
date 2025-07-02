// See https://aka.ms/new-console-template for more information


void MyfirstMethod()
{
    Console.WriteLine("This is my first method");
    Console.WriteLine("SUPER COMPLICATED CODE");
}
MyfirstMethod();
Console.WriteLine("This is out of the method");

int Add(int num1, int num2)
{
    int result =num1 + num2;
    return result;
}


void WriteSomething()
{
    Console.WriteLine("Writing something");
}
WriteSomething();

void WriteSomethingSpecific(string S)
{
    Console.WriteLine("My string is "+S);   
}
string myUsername = "fRANK";
WriteSomethingSpecific(myUsername); 


int AddTwoValues(int value1, int value2)
{
    int sum = value1 + value2;
    return sum;
}

int num1 = int.Parse(Console.ReadLine()); 
int myresult= AddTwoValues(num1, 10);
Console.WriteLine("The result is "+myresult);
Console.ReadKey();