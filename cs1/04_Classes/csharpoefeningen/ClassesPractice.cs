using CsharpOefeningen.Classes;
using System;

namespace CsharpOefeningen
{
    internal class ClassesPractice
    {
        public void RunOefeningen()
        {
            Oefening0();
            Oefening1();
        }
        public void Oefening0()
        {
            //Enemy staat in Enemy.cs
            Enemy enemy = new Enemy();

            //de onderstaande functions werken nog niet, zorg dat dit gaat werken
            Console.WriteLine(enemy.GetName());


            Console.WriteLine(enemy.GetHp());//hier zou 1000 uit moeten komen
            Console.WriteLine(enemy.DoDamage(9));

            Console.WriteLine(enemy.GetHp());//dit zou 991 moeten opleveren


        }

        public void Oefening1()
        {
            //Rectangle staat in Rectangle.cs
            Rectangle rectangle = new Rectangle(10, 50, 100, 100);

            //hieronder roepen we ToString() aan, als deze CsharpOefeningen.Rectangle als resultaat teruggeeft moet je ToString nog aanpassen in Rectangle.cs
            Console.WriteLine(rectangle.ToString());
        }
    }
}
