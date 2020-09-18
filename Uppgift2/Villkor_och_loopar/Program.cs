using System;

namespace Villkor_och_loopar
{

    /// <summary>
    
       
    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int stnmr; //Startnummer, variabeln utanför loopen för att kunna sätta ett vilkor
            int bästatiden; //Bästa tiden
            int bästatim = 24, bästamin = 60, bästasek = 60; //För att senare konverta bästa tiden från sekunder till timmar!
            int vinnare = 0; //Bästa startnummret med tiden, alltså vilken 'siffra' är vinnaren
            int result; //skall användas för resultat
            int antaltävlande = 0; //Antal tävlande
            bool kör = true;
            while(kör)
            {
                Console.WriteLine("Ange startnummer (börja med det högsta siffran).");
                stnmr = int.Parse(Console.ReadLine());
                if (stnmr <= 0) //För att stoppa loopen om det är inga fler tävlande.
                {
                    kör = false;
                }
                if (kör)
                {
                    ++antaltävlande;
                    Console.WriteLine("Ange timme (00-23) för start.");
                    int sttim = int.Parse(Console.ReadLine()); //starttimme
                    Console.WriteLine("Ange minut(00-59) för start.");
                    int stmin = int.Parse(Console.ReadLine()); //startminut
                    Console.WriteLine("Ange sekund(00-59) för start.");
                    int stsek = int.Parse(Console.ReadLine()); //startsekund

                    Console.WriteLine("Ange timme(00-23) för mål.");
                    int mltim = int.Parse(Console.ReadLine()); //måltimme
                    Console.WriteLine("Ange minut(00-59) för mål.");
                    int mlmin = int.Parse(Console.ReadLine()); //målminut
                    Console.WriteLine("Ange sekund(00-59) för mål.");
                    int mlsek = int.Parse(Console.ReadLine()); //målsekund

                    if (mltim <= sttim) //för at ställa om timmar
                    {
                        mltim = sttim + (24 - sttim + mltim);
                    }
                    int toltim = mltim - sttim;

                    if (mlmin <= stmin) //för att ställa om minuter
                    {
                        toltim--;
                        mlmin = stmin + (60 - stmin + mlmin); 
                    }
                    int tolmin = mlmin - stmin;

                    if (mlsek <= stsek) //för att ställa om sekunder
                    {
                        tolmin--;
                        mlsek = stsek + (60 - stsek + mlsek); 
                    }
                    int tolsek = mlsek - stsek;
                    if (tolsek == 60) //för att sätta till 60 sek till en minut
                        {
                        tolmin++;
                        tolsek = 0;
                    }

                    result = toltim * 3600 + tolmin * 60 + tolsek; //result
                    bästatiden = bästatim * 3600 + bästamin * 60 + bästasek; //Bästa tid slås ihop till sekunder för en if-sats

                    if (result < bästatiden)
                    {
                        bästatiden = result;
                        vinnare = stnmr;
                        bästatim = (bästatiden/60/60%60); //Uträkning för att få ut timmarna ur bästa tiden
                        bästamin = (bästatiden/60)%60; //Uträkning för att få ut minuterna efter timmar
                        bästasek = (bästatiden%60); //Uträkning för att få ut sekunderna efter timmar och minuter
                    }
                }
            }
            Console.WriteLine(vinnare + " är vinnaren!");
            Console.WriteLine("Vinnande sluttid: " + bästatim + ":" + bästamin + ":" + bästasek);
            Console.WriteLine("Antal tävlande: " + antaltävlande);
            Console.WriteLine("Programmet avslutas.");
        }
    }
}
