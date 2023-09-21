int heroHealth = 10;
int monsterHealth = 10;
Random dice = new Random();

while (heroHealth > 0 && monsterHealth > 0)
{
    int attack = dice.Next(1, 11);
    monsterHealth -= attack;
    Console.WriteLine($"Monster was damaged and lost {attack} health;  Health is now {monsterHealth}");

    if (monsterHealth > 0)
    {
        attack = dice.Next(1, 11);
        heroHealth -= attack;
        Console.WriteLine($"Hero was damaged and lost {attack} health;  Health is now {heroHealth}");
    }
}

Console.WriteLine($"The winner is {(monsterHealth > heroHealth ? "Monster" : "Hero")}");