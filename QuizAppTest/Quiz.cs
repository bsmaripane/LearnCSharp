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
            
        }

        public void DisplayQuestion(Question question)
        {
            Console.WriteLine(question.QuestionText);

            for (int i = 0; i < question.Answers.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {question.Answers[i]}");
            }
        }

        private void DisplayResults()
        {

        }

        private void GetUserChoice()
        {

        }
    }
}
