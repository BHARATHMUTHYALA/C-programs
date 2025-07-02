Console.WriteLine("Welcome to the adventure!");
Console.WriteLine("Enter your character's name");
string playername= Console.ReadLine();
Console.WriteLine($"You, {playername}, are now chased by jhonny sins!!!");
Console.WriteLine("Do you wish to proceed or immediately pull out");
string choice = Console.ReadLine();
if  (choice.ToLower() == "Enter")
{
    Console.WriteLine("Buy some condoms");
}
else
{
    Console.WriteLine("Run away as fast as you can ");
}
bool GameContinues = true;
while (GameContinues)
{
    Console.WriteLine("You now have a big injury in your back, go back or continue");
    string decision=Console.ReadLine();
    if (decision.ToLower() == "go back") {
        Console.WriteLine("Happy ending");
        GameContinues = false;
    }
    else
    {
        Console.WriteLine("You get teabagged");
        Console.WriteLine("last chance, fight or flee");
        string fightChoice= Console.ReadLine();
        if (fightChoice.ToLower() == "fight")
        {
            Console.WriteLine("Get ready , in position");
        }
        else
        {
            Console.WriteLine("Get railed");
            GameContinues= false;
        }
    }
}
Console.WriteLine("Game over!!!!!!!");
Console.ReadKey();