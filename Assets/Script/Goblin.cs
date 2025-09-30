using UnityEngine;

public class Goblin : Monster
{
    public override int Loot => 5;

    public void InitializeGoblin(string name)
    {
        base.Init("Gojek", 100, 5);
    }

    public override void Roar()
    {
        Debug.Log("Gyak Gyak!");
    }

    public override void Attack(Character target)
    {
        target.TakeDamage(AttackPower);
        Debug.Log($"{Name} attacks {target.Name} with Quick Stab for {AttackPower} damage!");
    }

    public override void Attack(Character target, int bonusDamage)
    {
        target.TakeDamage((AttackPower * 2) + (bonusDamage / 2));
        Debug.Log($"{Name} attacks {target.Name} with Quick Stab for {AttackPower} damage! with {bonusDamage} Bonus Damage!");
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
