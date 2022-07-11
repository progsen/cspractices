using System;

namespace CsharpOefeningen
{
    internal class Functions
    {
        internal void Oefening0()
        {
            Bus bus = new Bus();

            //maak functies in de  Bus class:
            //1) Board(int persons) telt persons op bij passengerCount
            //2) Offboard(int persons) haalt persons af van passengerCount
            //          extra: zorg dat je niet onder 0 komt!
            //3) GetPassengerCount() geeft het huidige aantal passengerCount terug

            bus.Board(5);
            bus.Board(4);
            bus.Offboard(3);
            bus.Offboard(3);

            Console.WriteLine($"the bus has {bus.GetPassengerCount()} passengers");
            //het resultaat moet 3 zijn!
        }

        internal void Oefening1()
        {
            Bus bus = new Bus();

            //maak functies in de  Bus class:
            //1) GetStopName() haalt de huidige halte naam op
            //2) SetStopName(string name) verander de waarde van stopName in de waarde van name

            //gebruik nu de functies:
            bus.SetStopName("ma amsterdam");
            Console.WriteLine($"the next stop is: {bus.GetStopName()}");
            //nu zou je ma amsterdam in de console moeten zien

        }


    }
    //normaal heeft elke class zijn eigen file (dus Bus moet in Bus.cs) maar voor het makkelijk vinden staat deze even hier
    internal class Bus
    {
        private int passengerCount;
        private string stopName;

        //maak je functies hier!
    }

}

