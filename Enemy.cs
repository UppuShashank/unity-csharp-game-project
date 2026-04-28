public class Enemy : Character
{
    public Enemy(string name, int health) : base(name, health) { }

    public void Taunt()
    {
        System.Console.WriteLine($"{Name} is taunting the player!");
    }
}
