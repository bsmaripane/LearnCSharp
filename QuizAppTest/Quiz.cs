using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizAppTest
{
    internal class Quiz
    {
        private Question[] questions;
        private int score;

        public Quiz(Question[] questions)
        {
            this.questions = questions;
        }

        public void StartQuiz()
        {
            Console.WriteLine("Welcome to the Quiz!");
            int questionNumber = 1; // to display question numbers

            foreach (var question in questions)
            {
                //Console.WriteLine($"Question {questionNumber}:");
                DisplayQuestion(question, questionNumber);
                questionNumber++;
                int userChoice = GetUserChoice();

                if (question.IsCorrectAnswer(userChoice))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Correct!");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine($"Incorrect!\nThe correct answer was: {question.Answers[question.CorrectAnswerIndex]}");
                    Console.ResetColor();
                }
            }
        }

        private void DisplayQuestion(Question question, int num = 1)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("╔════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine($"║                                Question {num}                              ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════════════════════╝");
            Console.ResetColor();
            Console.WriteLine(question.QuestionText);

            for (int i = 0; i < question.Answers.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;    // changes the text color
                Console.Write($"  {i + 1}");
                Console.ResetColor();   // resets the foreground (text) color
                Console.WriteLine($". {question.Answers[i]}");
            }
        }

        private void DisplayResults()
        {

        }

        private int GetUserChoice()
        {
            Console.Write("Your answer (number): ");
            string input = Console.ReadLine() ?? "";
            int choice = 0;
            while (!int.TryParse(input, out choice) || choice < 1 || choice > 4)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid choice. Please enter a number between 1 and 4: ");
                Console.ResetColor();
                input = Console.ReadLine() ?? "";
            }

            return choice - 1; // adjust to 0-indexed array
        }
    }
}
