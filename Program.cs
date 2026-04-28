class Program
{
    static void Main(string[] args)
    {
        Player player = new Player("Hero", 100);
        Enemy enemy = new Enemy("Goblin", 80);

        player.Display();
        enemy.Display();

        System.Console.WriteLine("\n--- Battle Start ---\n");

        player.Attack(enemy);
        enemy.Attack(player);

        enemy.Taunt();

        System.Console.WriteLine("\n--- After Battle ---\n");

        player.Display();
        enemy.Display();
    }
}
