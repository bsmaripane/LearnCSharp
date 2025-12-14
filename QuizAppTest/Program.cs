namespace QuizAppTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Question[] questions = new Question[]
            {

            };

            Quiz quiz = new Quiz(questions);
            quiz.StartQuiz();
            Console.ReadKey();
        }
    }
}
