//int num = 0;


//Console.WriteLine("Num is "+num);
//num++;
//Console.WriteLine("New num value is "+num);
//Console.WriteLine("Num is {0}",++num);
//Console.WriteLine("Num is {0}", num++);
//Console.WriteLine("Num is {0}", num);
//num--;
//Console.WriteLine("Num is "+ num);
//Console.WriteLine("Num is {0}", --num);
//Console.WriteLine("Num is {0}", num--);
//Console.WriteLine("Num is {0}", num);

//num += 30;
//Console.WriteLine("Num value is "+num);
//num *= 10; 
//Console.WriteLine("Num value is "+ num);
//num /= 10;
//Console.WriteLine("Num value is " + num);
//num %= 2;
//Console.WriteLine("Num value is "+num);

//Console.ReadLine();


//        Console.WriteLine("Give me a number");


;

Random random = new Random();
int randomNumber = random.Next(1, 11);
Console.WriteLine("Guess The number");
string inputString = Console.ReadLine();
int num1;
bool isNumber = int.TryParse(inputString, out num1);
if (isNumber)
{
    if (num1 == randomNumber)
    {
        Console.WriteLine("You guessed right");
    }
    else
    {
        Console.WriteLine("Wrong Number");
    }
}
else
    Console.WriteLine("Not a number");

Console.ReadKey();