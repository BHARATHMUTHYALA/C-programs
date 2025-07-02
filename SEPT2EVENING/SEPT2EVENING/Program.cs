// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
char myFavoriiteCharacter = '�';
Console.WriteLine(myFavoriiteCharacter);
 
int num = 123;
double price = 123.123;
string name = "Bharath";
//Interpolation
Console.WriteLine($"The number is {num}");
//concatenation     
Console.WriteLine("The number is "+num);
//String formatting
Console.WriteLine("The number is {0}, and the price is {1}, and the name is {2}", num, price, name);
Console.ReadKey();

string s1 = "This is a \"stirng\" with  a \nand a :";
Console.WriteLine(s1);
Console.ReadKey();