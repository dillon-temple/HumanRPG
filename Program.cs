using System;

namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {
            Human billy = new Human("Billy");
            Human jared = new Human("Jared");
            billy.Attack(jared);
            billy.Attack(jared);
        }
    }

    class Human
    {
        // Fields for Human
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        private int health;

        public int Health{
            get {return health;}
        }


        public Human(){
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            Name = "Bobby Hill";
            health = 100; 
        }

        public Human(string name)
        {
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            Name = name;
            health = 100;
        }

        public Human(string name, int str, int intel, int dex, int startHealth){
            Name = name;
            Strength = str;
            Intelligence = intel;
            Dexterity = dex;
            health = startHealth;
        }

        // add a public "getter" property to access health

        // Add a constructor that takes a value to set Name, and set the remaining fields to default values

        // Add a constructor to assign custom values to all fields

        // Build Attack method
        public int Attack(Human target)
        {
            target.health -= this.Strength * 5;
            Console.WriteLine(target.health);
            return target.health;
        }
    }
}
