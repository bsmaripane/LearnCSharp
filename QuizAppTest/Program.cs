namespace QuizAppTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Question[] questions = new Question[]
            {
                new Question(
                    "What is the capital of Germany?",   // Question text
                    new string[] {"Paris", "Berlin", "London", "Madrid"},   // Answers array
                    1   // Correct answer
                )
            };

            Quiz quiz = new Quiz(questions);
            quiz.StartQuiz();
            Console.ReadKey();
        }
    }
}
