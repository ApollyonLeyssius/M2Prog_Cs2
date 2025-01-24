using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class Quiz
    {
        internal QuizVraag[] vragen;
        internal QuizVraagAntwoord[] ingevuldeAntwoorden;

        Quiz quiz = new Quiz(10);
        internal Quiz()
        {

        }

        int aantalVragen()
        {
            vragen = new QuizVraag[aantalVragen];
        }

        int ingevuldeAntwoorden()
        {
            ingevuldeAntwoorden = new QuizVraagAntwoord[ingevuldeAntwoorden];
        }

    }
}
