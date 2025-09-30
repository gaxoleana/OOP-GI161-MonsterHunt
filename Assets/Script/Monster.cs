using UnityEngine;

public abstract class Monster : Character
{
    //Attributes//
    public abstract int Loot { get; }

    private bool defeated = false; //Bool Check

    //Methods//
    public override void ShowStatus()
    {
        base.ShowStatus();
        Debug.Log($"Loot: {Loot}");
    }

    public abstract void Roar();

    public override void Attack(Character target)
    {
        target.TakeDamage(AttackPower);
        //Debug.Log($"{Name} bites {target.Name} for {AttackPower} damage!");
    }

    public override void Attack(Character target, int bonusDamage)
    {
        target.TakeDamage((AttackPower * 2) + (bonusDamage / 2));
        //Debug.Log($"{Name} bites {target.Name} for {AttackPower} damage! with {bonusDamage} Bonus Damage!");
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