Random random = new Random();
var heroHp = 10;
var monsterHp = 10;

while (heroHp > 0 && monsterHp > 0)
{
    var heroDamage = random.Next(1, 10);
    monsterHp -= heroDamage;
    Console.WriteLine($"Monster was damaged and lost {heroDamage} health and now has {monsterHp} health.");

    if (monsterHp <= 0) break;

    var monsterDamage = random.Next(1, 10);
    heroHp -= monsterDamage;
    Console.WriteLine($"Hero was damaged and lost {monsterDamage} health and now has {heroHp} health.");
}

Console.WriteLine(heroHp > monsterHp ? "Hero wins!" : "Monster wins!");
