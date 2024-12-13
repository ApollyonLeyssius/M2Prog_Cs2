namespace Data_classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.run();
        }

        internal void run()
        {
            Auto auto1 = new Auto()
            {
                automaat = true,
                kenteken = "AA824H",
                kilometerStand = 20567,
                merk = "Volkswagen"
            };

            Auto auto2 = new Auto()
            {
                automaat = false,
                kenteken = "KU786G",
                kilometerStand = 65739,
                merk = "Volvo",
            };

            RijLeraar rijLeraar = new RijLeraar()
            {
                leeftijd = 30,
                naam = "John",
                zzp = true,
            };

            LesUur lesUur = new LesUur()
            {
                auto = auto1,
                RijLeraar = rijLeraar,

                tijd = 1130
            };

            Student student = new Student()
            {
                LesPakket = LesPakket,
                theorietest = TheorieTest,
                rijtest = RijTest,
                lesUur = lesUur
            };

            Dag dag = new Dag()
            {
                datum = DateTime,
                lesuren = lesUur
            };
        }
    }


}
