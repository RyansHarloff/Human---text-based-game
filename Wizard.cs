using System;

namespace Human
{
    public class Wizard : Person
    {
        public Wizard(string n, int strng, int intel, int dex, int hlth) : base(n, strng, intel, dex, hlth)
        {
            Intelligence = 25;
            Health = 50;
        }
        public override void Attack(Person Target)
        {
            Target.Intelligence -= 5;
            Health += 5;
            Console.WriteLine($"{Target.Name} was struck by {Name}, {Target.Name}'s new Intelligence Rating is {Target.Intelligence}");
            Console.WriteLine($"{Name}'s new health rating is {Health}");
        }
        public void Heal(Person Target)
        {
            Target.Health += 10;
            Console.WriteLine($"{Target.Name} was healed by {Name}, {Target.Name}'s new Health Rating is {Target.Health}");
        }
    }
}