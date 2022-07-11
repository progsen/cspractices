using System;

namespace InstanceCopyPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Person person1 = new Person() { name = "person1", age = 35, job = "programmer" };

            Address address1 = new Address() { street = "newyorkstreet" };
            person1.address = address1;

            Person person2 = new Person() { name = "person2", age = 33, job = "shop manager" };

            Address address2 = new Address() { street = "bakerstreet" };
            person2.address = address2;

            //oefening 1:
            //maak een kopie van person2
            Person copyOf2;

            //wat gebeurt er als je nu de age aanpast op copyOf2?


            //oefening 2:
            //stel nu person1 en person2 gaan samenwonen, person1 gaat bij person 2 wonen
            //doe dit door de address te kopieeren net als bij oefening 1


            //oefening 3:
            //stel nu person1 en person2 gaan samenwonen, person1 gaat bij person 2 wonen
            //doe dit door de REFERENCE naar het address over te nemen bij person1

            //hoeveel keer staat address nu in het geheugen?
            

            //oefening 3:
            //nu gaan ze verhuizen, pas het address aan van person1, wat is er nu met het address van person2 gebeurt?
        }
    }

    class Person
    {
        internal string name;
        internal int age;
        internal string job;
        internal Address address;
    }
    class Address
    {
        internal string street;
    }
}
