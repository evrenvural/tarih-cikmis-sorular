using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Question
    {
        public string QuestionText { get; set; }

        public string[] Answers { get; set; }

        public int TrueAnswerIndex { get; set; }

        public Question(string question, string[] answers, int trueAnswerIndex)
        {
            this.QuestionText = question;
            this.Answers = answers;
            this.TrueAnswerIndex = trueAnswerIndex;
        }
    }
}
