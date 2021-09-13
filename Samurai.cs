using System;

namespace Human
{
    public class Samurai : Person
    {
        public Samurai(string n, int strng, int intel, int dex, int hlth) : base(n, strng, intel, dex, hlth)
        {
            Health = 200;
        }
        public override void Attack(Person Target)
        {
            if(Target.Health <= 50)
                Console.WriteLine("No health Rmeianing");
        }
        public void Meditate(Person Target)
        {
            Health += 200;
            Console.WriteLine($"{Health}");
        }
    }
}