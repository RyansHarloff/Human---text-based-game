using System;

namespace Human
{
    public class Person
    {
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        public int Health;
        public Person()
        {
            Name = "n";
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            Health = 100;
        }
        public Person(string n, int strng, int intel, int dex, int hlth)
        {
            Name = n;
            Strength = strng;
            Intelligence = intel;
            Dexterity = dex;
            Health = hlth;
        }
        public void displayPerson()
        {
            Console.WriteLine($"{Name}");
            Console.WriteLine($"{Intelligence}");
            Console.WriteLine($"{Strength}");
        }
        public virtual void Attack(Person Target)
        {
            Target.Strength -= 5;
            Console.WriteLine($"{Target.Name} was struck by {Name}, {Target.Name}'s new Strength Rating is {Target.Strength}");
        }
    }
}