using System;

namespace CsharpOefeningen
{
    internal class Variabelen
    {
        public void Oefening0()
        {
            //variables een persoon maken:

            //maak de volgende variables hieronder:
            //1) voornaam
            //2) achternaam
            //3) leeftijd
            //4) postcode
            //5) huisnummer

            //geef alle variables een vulling

            //laat alle variables 1 voor 1 zien, gebruik de Console.WriteLine() statement

        }
        public void Oefening1()
        {
            //De bus

            //maak een string met de naam van de lijn: lijn 55

            //maak hier 2  variables:
            //1) bij welke halte de bus is, noem deze  'halte', begin op 1
            //2) hoe vol de bus zit, noem deze passagiers, begin op 0

            while (halte <= 10)//voor elke loop/rondje hier komen we bij een halte en stappen mensen in en uit
            {
                Random random = new Random();
                int instap = random.Next(0, 5);//0-4 mensen stappen in
                int uitstap = random.Next(0, 5);//0-4 mensen stappen uit

                //tel instap op bij passagiers
                //trek uitstap af van de passagiers

                //tel 1 bij halte op
            }

            //laat zien hoeveel mensen er bij de laatste halte uitstappen, gebruik de Console.WriteLine() statement

        }
        public void Oefening2()
        {
            //DateTime

            //maak een nieuwe DateTime variable zie
            //https://docs.microsoft.com/en-us/dotnet/api/system.datetime?view=net-6.0

            //de vulling moet de huidige datum tijd zijn, zie NOW in de pagina van de link

            //nu gaan we de toekomst in:
            //letop uit de functies komt de NIEUWE datum, zet die als vulling van de oude!
            //tel een maand op (AddMonth)
            //tel 4 dagen op (AddDays)


            //laat de toekomst datum zien, gebruik de Console.WriteLine() statement

        }
    }
}
