using UnityEngine;

public enum MonsterType
{
    Goblin, //0
    Orc, //1
    Dragon //2
}
public class Monster : Character
{
    //Attributes//
    private int loot;
    public int Loot
    {
        get { return loot; }
        private set
        {
            if (value < 0)
                loot = 0;
            else
                loot = value;
        }
    }

    public MonsterType monsterType { get; private set; }

    private bool defeated = false; //Bool Check

    //Methods//
    public void Init(MonsterType monType)
    {
        monsterType = monType;

        switch (monType)
        {
            case MonsterType.Goblin:
                base.Init("Goblin", 100, 5);
                Loot = 20;
                break;
            case MonsterType.Orc:
                base.Init("Orc", 150, 10);
                Loot = 50;
                break;
            case MonsterType.Dragon:
                base.Init("Dragon", 200, 20);
                Loot = 100;
                break;

        }
    }

    public override void ShowStatus()
    {
        base.ShowStatus();
        Debug.Log($"Loot: {Loot}");
    }

    public override void Attack(Character target)
    {
        target.TakeDamage(AttackPower);
        Debug.Log($"{Name} bites {target.Name} for {AttackPower} damage!");
    }

    public override void Attack(Character target, int bonusDamage)
    {
        target.TakeDamage((AttackPower * 2) + (bonusDamage / 2));
        Debug.Log($"{Name} bites {target.Name} for {AttackPower} damage! with {bonusDamage} Bonus Damage!");
    }
    public override void OnDefeated()
    {
        throw new System.NotImplementedException();
    }

    public int LootReward(int lootAmount)
    {
        return Loot;
    }

    public bool IsAlive() { return Health > 0; } //Died Yet.
}