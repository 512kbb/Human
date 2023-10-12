namespace Human;
class Program
{
    public class Human
    {
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        public int Health;


        public Human(string name)
        {
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            Health = 100;
        }

        public Human(string name, int strenght, int intelligence, int dexterity, int health)
        {
            Name = name;
            Strength = strenght;
            Intelligence = intelligence;
            Dexterity = dexterity;
            Health = health;
        }

        public int Attack(Human human)
        {   
            int damage = this.Strength * 3;
            int currentHealth = human.Health - damage;
            return currentHealth;
        }
    }
    static void Main(string[] args)
    {
        Human h1 = new("512kb");
        Human h2 = new("Zote");

        Console.WriteLine(h1.Attack(h2));
    }
}
