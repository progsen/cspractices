namespace CsharpOefeningen.Classes
{
    internal class Rectangle
    {

        //hier maak je 4 variables op CLASS niveau, deze heten hetzelfde als de variables (agruments) in de constructor

        //constructor
        public Rectangle(int x, int y, int width, int height)
        {
            //gebruik this om de waarde van alle constructor argumenten (bv x) aan de CLASS variable met dezelfde naam te geven
        }

        public override string ToString()
        {
            return base.ToString();//verander dit zodat deze een string teruggeeft met de waardes van de class variables (x,y,width,height)
        }
    }
}
