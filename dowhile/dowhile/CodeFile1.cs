using System;

public class One
{
    public static void Main(string[] args)
    {



        for (int i = 0; i < 10; i++)
        {
            if (i == 2)
            {
                continue;
            }
            Console.WriteLine(i);
        }
    }
}
