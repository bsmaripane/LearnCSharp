using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizAppTest
{
    internal class Quiz
    {
        private Question[] _questions;
        private int _score;

        public Quiz(Question[] questions)
        {
            this._questions = questions;
            _score = 0;
        }

        public void StartQuiz()
        {
            Console.WriteLine("Welcome to the Quiz!");
            int questionNumber = 1; // to display question numbers

            foreach (var question in _questions)
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
                    _score++;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Incorrect!\nThe correct answer was: {question.CorrectAnswerIndex + 1}. {question.Answers[question.CorrectAnswerIndex]}");
                    Console.ResetColor();
                }
            }
            DisplayResults();
        }

        private void DisplayQuestion(Question question, int num = 1)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n╔════════════════════════════════════════════════════════════════════════╗");
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
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n╔════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine($"║                                Results                                 ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════════════════════╝");
            Console.ResetColor();
            Console.WriteLine($"Quiz finished. Your score is: {_score} out of {_questions.Length}");

            double percentage = (double)_score / _questions.Length;
            double[] scoreRange = {0.0, 0.19,0.2,0.39,0.4,0.59,0.6,0.79,0.8};

            if (percentage >= scoreRange[8])
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Excellent!");
            }
            else if (percentage >= scoreRange[6] && percentage <= scoreRange[7])
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Good!");
            }
            else if (percentage >= scoreRange[4] && percentage <= scoreRange[5])
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Average!");
            }
            else if (percentage >= scoreRange[2] && percentage <= scoreRange[3])
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Below Average!");
            }
            else if (percentage >= scoreRange[0] && percentage <= scoreRange[1])
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Poor!");
            }
            Console.ResetColor();
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
