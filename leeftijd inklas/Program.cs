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
        }{//Declaratie
            DateTime geboortedatum; string naam;    //input

        //input
        //Vragen naar de naam
        Console.Write("wat is jouw naam?: ");
            naam = Console.ReadLine();

            //vragen naar zijn geboortedatum
            Console.Write("wat is jouw geboortedatum?: ");
            geboortedatum = Convert.ToDateTime(Console.ReadLine();

            //output
            //Het aantal jaar dat je oud bent
            Console.WriteLine();
            Console.WriteLine("je geboortedatum " + geboortedatum.ToLongDateString()+ ".");
            Console.WriteLine(naam + " je bent al " + DateTime.Now.Subtract(geboortedatum).Days.ToString()
            + "Jaren oud. ");
            Console.WriteLine();
            Console.ReadLine();

    }
}
