using UnityEngine;

public class Dragon : Monster
{
    public override int Loot => 20;

    public void InitializeDragon(string name)
    {
        base.Init("Dragoon", 200, 20);
    }

    public override void Roar()
    {
        Debug.Log("Rawrrrr!");
    }

    public override void Attack(Character target)
    {
        target.TakeDamage(AttackPower);
        Debug.Log($"{Name} attacks {target.Name} with Fire Breath for {AttackPower} damage!");
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
