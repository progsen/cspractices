using System;
using System.Collections.Generic;

namespace CsharpOefeningen
{
    internal class ArraysAndLists
    {
        internal void Oefening0()
        {
            int[] array;
            //geef de array een rijtje getallen van 0 tot 10

            //loop hier over de array heen (for loop) en schrijf elk getal naar de console
        }


        internal void Oefening1()
        {
            string[] namen = { "joop", "joep", "joris" };

            //joop, joep en joris zijn broers hun achternaam is bakker

            for (int i = 0; i < namen.Length; i++)
            {
                //voeg de achternaam "bakker" toe aan de naam in de array op plek i (index i)
                //gebruik hier een += voor
            }
        }

        internal void Oefening2()
        {
            List<string> lijnen = new List<string>();

            //hierboven hebben we alle metro lijen van het GVB. nu zit er nog niets in.

            //voeg hier de lijnen 50,51,53 toe


            Console.WriteLine("gvb metros:");
            foreach (string lijn in lijnen)//dit is een foreach, deze lijkt op de for maar je hebt iets minder controle
            {
                Console.WriteLine(lijn);
            }

            //OOPS, we waren vergeten dat lijn 52 erbij moet, en dat lijn 51 een tijd dicht is

            //haal hier lijn 51 uit de lijnen list
            //stop hier lijn 52 in de lijnen list


            //write nu alles naar de console, met een FOR loop niet een FOREACH
        }
    }

}
