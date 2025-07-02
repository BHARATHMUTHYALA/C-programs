string question1 = "What is the capital of INDIA";
string answer1 = "Delhi";

string question2 = "What is 2+2";
string answer2 = "4";

string question3 ="What color do you get by mixing blue and yellow";
string answer3 = "Green";

int score  = 0;

Console.WriteLine(question1);
string useranswer1= Console.ReadLine();
if (useranswer1.Trim().ToLower() == answer1.ToLower())
{
    Console.WriteLine("Correct");
    score = score + 1;
}
else
{
    Console.WriteLine("Wrong!, The correct answer is "+answer1);
}
Console.WriteLine(question2);
string useranswer2 = Console.ReadLine();
if (useranswer2.Trim().ToLower() == answer2.ToLower())
{
    Console.WriteLine("Correct");
    score = score + 1;
}
else
{
    Console.WriteLine("Wrong!, The correct answer is " + answer2);
}
Console.WriteLine(question3);
string useranswer3 = Console.ReadLine();

if (useranswer3.Trim().ToLower() == answer3.ToLower())
{
    Console.WriteLine("Correct");
    //score = score + 1;
    score++;
}
else
{
    Console.WriteLine("Wrong!, The correct answer is " + answer3);
}

Console.WriteLine($"Quiz Completed and your final score is {score} out of 3");
if(score == 3)
    Console.WriteLine("Wow! you got all 3 right");
else if (score >0)
    Console.WriteLine("Good! You got something right");
else
    Console.WriteLine("Better luck next Time");

Console.ReadKey();