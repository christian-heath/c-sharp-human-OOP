using System;

namespace human
{
    public class Human
    {
        public string name;
        public int strength = 3;
        public int intelligence = 3;
        public int dexterity = 3;
        public int health = 100;
        public Human(string name)
        {
            this.name = name;
        }
        public Human(string name, int str, int intel, int dex, int health)
        {
            this.name = name;
            strength = str;
            intelligence = intel;
            dexterity = dex;
            this.health = health;
        }
        public void Attack(Human attacked)
        {
            attacked.health -= strength * 5;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Human BasicMan = new Human("Bob");
            Human StrongMan = new Human("Bill", 20, 20,20,200);
            Console.WriteLine("Bill's health before getting smacked by Bob:" + BasicMan.health);
            StrongMan.Attack(BasicMan);
            Console.WriteLine("Bill's health after getting smacked by Bob:" + BasicMan.health);
        }
    }
}
