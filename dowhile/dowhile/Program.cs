
int score;
int sum = 0;
int counter=0;


do
{
    Console.WriteLine("Enter student scores. enter -1 to finish!");
    score = int.Parse(Console.ReadLine());
    if (score != -1)
    {
        sum = sum + score;
        counter++;
    }
} while (score!=-1);
int average = sum / counter;
Console.WriteLine("The average is:"+average);
Console.ReadKey();