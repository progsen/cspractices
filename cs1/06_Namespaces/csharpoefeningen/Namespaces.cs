using System;
//gebruik hier een using!

namespace CsharpOefeningen
{
    internal class Namespaces
    {
        public void Oefening0()
        {
            //Hier willen we de CalcHelper class uit de NamespaceOefeningLib gebruiken
            //maar hij pakt hem niet? hoe kan dat? 
            //fix het! zie de usings boven in de file
            CalcHelper helper = new CalcHelper();

            int result = helper.Add(867, 150);
            Console.WriteLine(result);
        }
    }
}

