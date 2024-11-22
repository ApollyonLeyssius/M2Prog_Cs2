namespace Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();

            //program is het variable
            //program is een progamma
            //het heet program
            //De return is run
        }

        internal void vraag1()
        {

            Console.WriteLine("How long do you think you'd survive in a zombie apocalypse?");
            string antwoord = Console.ReadLine();

            Console.WriteLine(antwoord);

        }

        internal void Run()
        {
            Console.WriteLine("...");
            Console.WriteLine("How long do you think you'd survive in a zombie apocalypse?");
            Console.WriteLine("I could last 100 hours");
            Console.WriteLine("Has someone caught you dancing in front of the mirror?");
            Console.WriteLine("No");
            Console.WriteLine("Have you ever tried talking to a animal?");
            Console.WriteLine("Probably");
            Console.WriteLine("What is the worst game you played but that you liked anyway?");
            Console.WriteLine("Yakuza 3");
            Console.WriteLine("Why do round pizzas come in square boxes?");
            Console.WriteLine("Because it's easier to transport");
        }

    }
}
