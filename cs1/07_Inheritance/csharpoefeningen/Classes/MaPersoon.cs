namespace CsharpOefeningen.Classes
{
    internal class MaPersoon
    {
        private int age;
        protected string name;

        public MaPersoon(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public override string ToString()
        {
            return $"{name} {age}";
        }
    }
}
