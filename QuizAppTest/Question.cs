using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizAppTest
{
    internal class Question
    {
        public string QuestText { get; }
        public string[] Answer { get; }
        public int CorrectAnswerIndex { get; }

        public Question(string questText, string[] answer, int correctAnswerIndex)
        {
            QuestText = questText;
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
