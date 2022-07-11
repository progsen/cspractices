//gebruik hier een using!

using CsharpOefeningen.Classes;
using System;

namespace CsharpOefeningen
{
    internal class Inheritance
    {
        public void Oefening0()
        {
            //het onderstaande werkt niet, kijk snel in MaWerknemer en zorg ervoor dat deze MaPersoon inherit
            MaPersoon persoon = new MaWerknemer("docent",50);
        }

        public void Oefening1()
        {
            //het onderstaande werkt niet, kijk snel in MaWerknemer en zorg ervoor dat deze MaPersoon inherit
            MaWerknemer persoon = new MaWerknemer("docent",88);
            //waarom hierboven geen MaPersoon?

            Console.WriteLine(persoon.IsRetired());
        }
    }
}

