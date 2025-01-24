using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class QuizVraag
    {
        internal string vraag;
        internal string antwoord;

        internal QuizVraag(string vraag, string antwoord)
        {
            this.vraag = vraag;
            this.antwoord = antwoord;
        }

        private void Run()
        {
            QuizVraag quizVraag = new QuizVraag("Wat is de hoofdstad van Nederland?", "Amsterdam");
        }

    }

}
