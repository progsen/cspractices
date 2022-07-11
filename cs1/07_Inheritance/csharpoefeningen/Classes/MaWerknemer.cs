namespace CsharpOefeningen.Classes
{
    internal class MaWerknemer // inherit hier MaPersoon
    {
        private int salaris;

        public MaWerknemer(string name, int age) : base(name, age)//wat gebeurt hier? we roepen de constructor van MaPersoon
        {
        }

        //maak hier voor Oefening1 een function die als AGE > 65 


        public bool IsRetired()
        {
            //maak hier een IF als AGE > 65 dan return je true

            //mag je bij age? zo nee fix dat met een protected acces modifier

            //zo niet komt de code bij deze false als result;
            return false;
        }
    }
}
