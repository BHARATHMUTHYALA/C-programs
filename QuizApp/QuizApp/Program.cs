namespace QuizApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Question[] questions = new Question[]
            {
                new Question("What is the capital of Germany",
               new string[]{"PARIS","BERLIN","LONDON","MADRID"},1
               )



            };

            Quiz newquiz = new Quiz(questions);
            newquiz.DsiplayQuestion(questions[0]);
            Console.ReadLine();
            
        }
    }
}
