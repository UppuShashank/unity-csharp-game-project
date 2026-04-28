public class Character
{
    private string name;
    private int health;

    public Character(string name, int health)
    {
        this.name = name;
        this.health = health;
    }

    public string Name { get { return name; } }
    public int Health { get { return health; } protected set { health = value; } }

    public virtual void Attack(Character target)
    {
        int damage = 10;
        target.TakeDamage(damage);
        System.Console.WriteLine($"{name} attacks {target.Name} for {damage} damage");
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        if (Health < 0) Health = 0;
    }

    public void Display()
    {
        System.Console.WriteLine($"{name} - Health: {health}");
    }
}
