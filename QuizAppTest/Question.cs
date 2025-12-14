using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizAppTest
{
    internal class Question
    {
        public string QuestionText { get; }
        public string[] Answer { get; }
        public int CorrectAnswerIndex { get; }

        public Question(string questionText, string[] answer, int correctAnswerIndex)
        {
            QuestionText = questionText;
            Answer = answer;
            CorrectAnswerIndex = correctAnswerIndex;
        }

        // Method to check if the answer is correct
        public bool IsCorrectAnswer(int choice)
        { 
            return CorrectAnswerIndex == choice; 
        }
    }
}
