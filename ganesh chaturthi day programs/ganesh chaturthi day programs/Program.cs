//Console.WriteLine("How old are you? Write A WHOLE NUMBER");

//int age = int.Parse(Console.ReadLine());
//bool isWithParents;

//if (age >= 18)
//{
//    Console.WriteLine("GO F**k yourself");
//}
//else if ((age >= 13))
//{
//    Console.WriteLine("Are you with your parents? Answer yes or no");
//    string isWithParentsString = Console.ReadLine();
//    if (isWithParentsString == "yes") { 
//    Console.WriteLine("Go party with your parents");
//}
//    else
//    {
//        Console.WriteLine("No party for you today");
//    }
//}
//else
//{
//    Console.WriteLine("Go party in the kindergarden");
//}
//Console.ReadKey();




//if (Month == 1) { 
//    MonthName = ("January");
//}
//else if (Month == 3)
//    MonthName=("MARCH");
//else if (Month == 4)
//    MonthName = ("APRIL");
//else if (Month == 2)
//    MonthName = ("February");
//else
//    MonthName = ("uNKNOWN");
//Console.WriteLine(MonthName);
//Console.ReadKey();
int Month = 9;
string MonthName;

switch (Month)
{
    case 1:
        MonthName = "jANUARY";
        break;
    case 2:
        MonthName = "February";
        break;
    default:
        MonthName = "Unknown";
        break;
}

Console.WriteLine("THE MONTH IS " + MonthName);
Console.ReadKey();
