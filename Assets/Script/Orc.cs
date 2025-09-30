using UnityEngine;

public class Orc : Monster
{
    public override int Loot => 10;

    public void InitializeOrc(string name)
    {
        base.Init("Pitong", 150, 10);
    }

    public override void Roar()
    {
        Debug.Log("Aughhhh!");
    }

    public override void Attack(Character target)
    {
        target.TakeDamage(AttackPower);
        Debug.Log($"{Name} attacks {target.Name} with Heavy Slash for {AttackPower} damage!");
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
