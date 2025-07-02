namespace Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] students = { 70, 80, 90 };
            double avg = (double)students.Sum()/students.Length;
            char grade;

            if (avg > 90)
            {
                grade = 'A';
            }
            else if (avg >= 80)
            {
                grade = 'B';
            }
            else if (avg >= 70)
            {
                grade = 'C';
            }
            else if(avg>=60)
            {
                grade = 'D';
            }
            else
            {
                grade = 'F';
            }
            Console.WriteLine($"The total marks are {students.Sum()} " +
                $"and the grade of the student is {grade}"
                );
            Console.ReadKey();
        }
    }
}
