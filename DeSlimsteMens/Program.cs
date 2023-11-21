namespace DeSlimsteMens
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Deelnemer deelnemer1 = new Deelnemer("Jennifer Heylen", 4,3);   
            Deelnemer deelnemer2 = new Deelnemer("Alex Agnew");
            Deelnemer deelnemer3 = new Deelnemer("Toby Alderweireld",4 , 1);

            Console.WriteLine(deelnemer1.WinstPercentage);
            Console.WriteLine(deelnemer2.WinstPercentage);
            Console.WriteLine(deelnemer3.WinstPercentage);

            //finale tussen d1 en d2  // TODO: dit plaatsen in klasse SlimsteMens, methode: SpeelFinale(deelnemer2, deelnemer3)
            Deelnemer finalist1 = deelnemer2;
            Deelnemer finalist2 = deelnemer3;
            do
            {
                //TODO: hier spelen we de finale
            } while (finalist1.Score!= 0 && finalist2.Score!=0);

            if(finalist1.Score!=0)
            {
                Deelnemer.FinaleDeelnemers[0] = finalist1;
                //Todo in finale lijst platsen
            }
            else
                Deelnemer.FinaleDeelnemers[0] = finalist2;

        }
    }
}