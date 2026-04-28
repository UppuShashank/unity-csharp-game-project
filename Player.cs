public class Player : Character
{
    public Player(string name, int health) : base(name, health) { }

    public override void Attack(Character target)
    {
        int damage = 20; // stronger attack
        target.TakeDamage(damage);
        System.Console.WriteLine($"{Name} performs a special attack on {target.Name} for {damage} damage");
    }
}
