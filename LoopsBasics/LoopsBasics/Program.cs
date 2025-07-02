using System;


string MyString =  "          /\\\n" +
                        "         |  |\n" +
                        "         |  |\n" +
                        "        /____\\\n" +
                        "       |      |\n" +
                        "       |  ||  |\n" +
                        "       |  ||  |\n" +
                        "       |__||__|\n" +
                        "       |      |\n" +
                        "       |______|\n" +
                        "      /        \\ \n" +
                        "     /__________\\\n" +
                        "    |            |\n" +
                        "    |____________|\n" +
                        "    |____________|\n" +
                        "        |  |\n" +
                        "        |  |\n" +
                        "        |__|\n" +
                        "        |__|\n" +
                        "        |__|\n" +
                        "        |__|\n" +
                        "       /____\\\n" +
                        "       |____|\n";
;

string smileyFace = "\U0001F600";  // 😀 (grinning face)
string heart = "\U0001F49B";       // 💛 (yellow heart)

for (int counter = 10; counter >=1; counter--)
{
    Console.Clear();
    Console.WriteLine($"I is {counter}");
    Console.WriteLine(MyString);
    MyString = "\r\n" + MyString;
    Thread.Sleep(1000);
}
Console.WriteLine("The rocket has landed");



Console.ReadKey();
