using System;

namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Ryan = new Person("Ryan", 50, 50, 50, 100);
            Person Ethan = new Person("Ethan", 50, 50, 50, 100);
            Ryan.Attack(Ethan);
            Ethan.Attack(Ryan);
            Wizard Alexis = new Wizard("Alexis",23,46,56,100);
            Alexis.Attack(Ryan);
            Ninja Melvin = new Ninja("Melvin", 50,50,50,100);
            Samurai Benji = new Samurai("Benji", 50, 50, 50, 100);
            Benji.Attack(Melvin);
            Benji.Meditate(Benji);
            Melvin.Steal(Ryan);
        }
    }
}
