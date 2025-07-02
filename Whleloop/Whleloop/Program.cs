//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine((i));
//}
//Console.ReadKey();

bool isgood = true;

int counter=0;
Console.WriteLine("Enter go or stay");
string userchoice = Console.ReadLine();

while (userchoice=="go")
{
    Console.WriteLine("Life is good");
    Console.WriteLine("Wanna keep living? Enter go");
    userchoice = Console.ReadLine();

}

Console.ReadKey();  