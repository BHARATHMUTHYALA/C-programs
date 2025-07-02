Random random = new Random();

int secretNumber = random.Next(1,101);
int userguess = 0;
int counter = 0;

Console.WriteLine("Guess the number between 1 and 100 ");

while (userguess != secretNumber)
{
    counter++;
    Console.WriteLine("Enter your guess");
    userguess = int.Parse(Console.ReadLine());
    if (userguess > secretNumber)
    {
        Console.WriteLine("Too high try again");
    }
    else if (userguess < secretNumber)
    {
        Console.WriteLine("Too low try again");
    }
    else
    {
        Console.WriteLine("CONGRATS, You got the right number!!!!!!!!!!!!"+"It took you "+counter+" tries");
    }
}

Console.ReadKey();