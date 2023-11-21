namespace DeSlimsteMens
{
    internal class Deelnemer
    {

        public Deelnemer(string naam, int aantalDeelnames, int aantalOverwinningen)
        {
            Naam = naam;
            Score = 60;
            AantalDeelnames = aantalDeelnames;
            AantalOverwinningen = aantalOverwinningen;
        }

        public Deelnemer(string Naam) : this(Naam, 0, 0)
        {
        }
        static public Deelnemer[] FinaleDeelnemers { get; set; } = new Deelnemer[8];

        public string Naam { get; private set; }

        private int score;

        public int Score
        {
            get { return score; }
            set
            {
                if (value >= 0)
                    score = value;
                else
                    score = 0;
            }
        }


        public int AantalDeelnames { get; set; }

        private int aantalOverwinningen;
        public int AantalOverwinningen
        {
            get { return aantalOverwinningen; }
            set
            {
                if (value <= AantalDeelnames)
                    aantalOverwinningen = value;
                else
                    throw new Exception("Aantaloverwinningen kan niet groter zijn dan aantal deelnames");

            }
        }


        public double WinstPercentage
        {
            get
            {
                if (AantalDeelnames == 0) return 0;

                return 100.0*AantalOverwinningen / AantalDeelnames;
            }
        }

    }
}
