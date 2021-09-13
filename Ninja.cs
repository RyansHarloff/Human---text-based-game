using System;

namespace Human
{
    public class Ninja : Person
    {
        public Ninja(string n, int strng, int intel, int dex, int hlth) : base(n, strng, intel, dex, hlth)
        {
            Dexterity = 175;
        }
        public override void Attack(Person Target)
        {
            Target.Dexterity -= 5;
        }
        public void Steal(Person Target)
        {
            Target.Health -= 5;
            Health += 5;
            Console.WriteLine($"{Target.Name} health was stolen by {Name}, {Target.Name}'s new Health Rating is {Target.Health}");
        }
    }
}