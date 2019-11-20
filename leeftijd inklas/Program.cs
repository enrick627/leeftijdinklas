//enrick de munter 5ITN
/*analyse
 * vraag naam
 *vraag geboortedatum
 * bereken huidig jaartal (huidigeDatum.year)
 * Bereken geboortejaar
 *bereken leeftijd
 * bereken uitvoer
 * toon uitvoer
 * 
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leeftijd_inklas
{
    class Program
    {
        static void Main(string[] args)
        {
            //DECLARATIES
            //inputvariabelen
            string naam, geboortedatumInvoer;

            //processingvariabelen
            DateTime geboortedatum, huidigeDatum;
            ushort geboortedatums, huidigdatums, geboortejaar, huidigjaartal;
            byte leeftijd1, leeftijd2, leeftijd3;



            //outputvariabelen
            string uitvoer;
            //INPUT
            // VRAAG naam
            Console.Write("Geef uw naam in, a.u.b.: ");
            naam = Console.ReadLine();
            // VRAAG geboortedatum
            Console.Write("Geef uw geboortedatum, a.u.b.: ");
            geboortedatumInvoer = Console.ReadLine();

            //PROCESSING
            // Parsen van input
            geboortedatum = DateTime.Parse(geboortedatumInvoer);

            // BEREKEN huidigJaartal (huidigeDatum.Year)
            huidigeDatum = DateTime.Today;
            huidigdatums = (ushort)huidigeDatum.Day;
            huidigjaartal = (ushort)huidigeDatum.Year;

            // BEREKEN geboortejaar (geboortedatum.Year)
            geboortedatums = (ushort)geboortedatum.Day;
            geboortejaar = (ushort)geboortedatum.Year;

            // BEREKEN leeftijd (huidigJaartal - geboortejaar)
            leeftijd1 = (byte)((int)huidigdatums - (int)geboortedatums);
            leeftijd2 = (byte)((int)huidigjaartal - (int)geboortejaar);

            if (huidigdatums < geboortedatums)
            {
                leeftijd2 = (byte)(leeftijd2 - 1);
            }

            // BEREKEN uitvoer (= "<naam>, u bent <leeftijd> jaar oud.")
            uitvoer = $"{naam}, u bent {leeftijd2}jaar en{leeftijd1} dagen oud.";


            //OUTPUT
            // TOON uitvoer
            Console.WriteLine(uitvoer);

            //Wachten...
            Console.WriteLine();
            Console.Write("Druk op Enter om af te sluiten... ");
            Console.ReadLine();
        }
    }
}
