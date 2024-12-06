using System.Net.Sockets;

namespace Functions
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Program program = new Program();             //program is het variable program is een progamma
            program.Run();             //het heet program De return is run
            Program vraag = new Program();
            vraag.vraag1();
            vraag.vraag2();
            vraag.vraag3();
            vraag.vraag4();
            vraag.vraag5();
            vraag.vraag6();

            string antwoord6 = vraag6();
            Console.WriteLine(antwoord6);
        }


        internal void Run()
        {
            Console.WriteLine("...");
        }

        internal string vraag1()
        {
            Console.WriteLine("How long do you think you'd survive in a zombie apocalypse?");
            string antwoord1 = Console.ReadLine();

            return antwoord1;
        }

        internal string vraag2()
        {
            Console.WriteLine("What would you do if you won a million dollars?");
            string antwoord2 = Console.ReadLine();

            return antwoord2;
        }

        internal string vraag3()
        {
            Console.WriteLine("Why do round pizzas come in square boxes?");
            string antwoord3 = Console.ReadLine();

            return antwoord3;
        }

        internal string vraag4()
        {
            Console.WriteLine("How long do you think you'd survive in a zombie apocalypse?");
            string antwoord4 = Console.ReadLine();

            return antwoord4;
        }

        internal string vraag5()
        {
            Console.WriteLine("What secret conspiracy would you like to actually start letting other people know ? ");
            string antwoord5 = Console.ReadLine();

            return antwoord5;
        }

        internal string vraag6()
        {
            Console.WriteLine("What would you call a male ladybug?");
            string antwoord6 = Console.ReadLine();

            return antwoord6;
        }


    }

}
