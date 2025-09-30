using UnityEngine;

public class Hero : Character
{
    //Attributes//
    private int maxGold = 999;
    public int Gold { get; private set; }

    //Methods//
    public void Init(string newName, int newHealth, int newAttack)
    {
        base.Init(newName, newHealth, newAttack);
        Gold = 0;
    }

    public override void ShowStatus()
    {
        base.ShowStatus();
        Debug.Log($"Gold: {Gold}");
    }

    public override void Attack(Character target)
    {
        target.TakeDamage(AttackPower);
        Debug.Log($"{Name} slashes {target.Name} for {AttackPower} damage!");
    }

    public override void Attack(Character target, int bonusDamage)
    {
        target.TakeDamage(AttackPower + bonusDamage);
        Debug.Log($"{Name} slashes {target.Name} for {AttackPower} damage! with {bonusDamage} Bonus Damage!");
    }

    public override void OnDefeated()
    {
        throw new System.NotImplementedException();
    }

    public void Heal(int healAmount)
    {
        Health = Mathf.Clamp(Health + healAmount, 0, maxHealth);
        Debug.Log($"{Name} heal {healAmount} HP! | Remaining Health: {Health}");
    }

    public void EarnGold(int goldAmount)
    {
        Gold = Mathf.Clamp(Gold + goldAmount, 0, maxGold);
    }

    public bool IsAlive() { return Health > 0; } //Died Yet.
}