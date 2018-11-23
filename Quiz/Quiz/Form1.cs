using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class Form1 : Form
    {
        private int nrOfCorrectAnswers;
        private QuizCard quizcard;

        public Form1()
        {
            InitializeComponent();
            nrOfCorrectAnswers = 0;
        }

        private void AnswerButton_Click(object sender, EventArgs e)
        {

        }

        private void NextQuestionButton_Click(object sender, EventArgs e)
        {

        }

        private void ShowResult()
        {
            throw new NotImplementedException();
        }
    }
}
