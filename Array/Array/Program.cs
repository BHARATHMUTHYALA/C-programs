int num1 = 0;
int num2 = 0;
int num3 = 0;
int num4 = 0;

int[] MYINTARRAY = [4,12,13,14,15];
string[] MYSTRINGARRAY = ["Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun"];
//for(int i =1; i <= MYSTRINGARRAY.Length; i++)
//{
//    Console.WriteLine((i));
//}

//foreach(var item in MYSTRINGARRAY) { Console.WriteLine(item); }
//Console.ReadLine();


int[,] array2D= new int[
3, 3];
//Console.WriteLine( array2D[0, 0]);

int[,,] array3D = new int[3, 3, 3];

int[,] array2Dintitialiazed =   { { 1,2}, { 3,4} };

string[,] tictactoesfield =
{
    {"O","X","X"},
    {"O","O","X"},
    {"X","X","O"},

};
//Console.WriteLine(tictactoesfield[1,2]);



string[,,] SIMPLE3DARRAY =
{
    {
        {"000","111"},
        {"010","011"},
    },
    {
        {"100","101"},
        {"110","111" },
    }
};
Console.WriteLine(SIMPLE3DARRAY[0,1,    1]);