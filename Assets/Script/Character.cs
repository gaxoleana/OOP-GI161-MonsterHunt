using UnityEngine;

public abstract class Character : MonoBehaviour
{
    //Attributes//
    private string name; //Field
    public string Name //Property
    {
        get { return name; }
        private set
        {
            if (string.IsNullOrEmpty(value))
                name = "Unknow player";
            else
                name = value;
        }
    }

    protected int maxHealth = 200;

    public int Health { get; protected set; }
    
    public int AttackPower { get; private set; }

    public Weapons EquippedWeapon { get; protected set; }

    //Methods//
    public void Init(string newName, int newHealth, int newAttackPower)
    {
        Name = newName;
        Health = newHealth;
        AttackPower = newAttackPower;
    }

    public void EquipWeapon(Weapons weapon)
    {
        EquippedWeapon = weapon;
    }

    public virtual void ShowStatus()
    {
        Debug.Log($"Name: {Name} | Health: {Health} | Attack: {AttackPower}");
    }

    public void TakeDamage(int damageValue)
    {
        Health = Mathf.Clamp(Health - damageValue, 0, maxHealth);
    }

    public abstract void Attack(Character target);

    public abstract void Attack(Character target, int bonusDamage);

    public virtual void Attack(Character target, Weapons weapon)
    {
        if (weapon != null)
        {
            int damage = AttackPower + weapon.BonusDamage;
            target.TakeDamage(damage);
            Debug.Log($"{Name} uses a {weapon.WeaponName} with Bonus {weapon.BonusDamage}" + $"-> deals total {damage} damage! to {target.Name}.");
        }
    }

    public abstract void OnDefeated();

    public bool IsAlive() { return Health > 0; } //Died Yet.
}
