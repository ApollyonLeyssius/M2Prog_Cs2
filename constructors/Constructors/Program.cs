namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
        }
            private void Run()
        {
            QuizVraag quizVraag = new QuizVraag("Wat is de hoofdstad van Nederland?", "Amsterdam");
        }
    }
    }

