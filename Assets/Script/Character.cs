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

    /*
    private int health;
    public int Health
    {
        get { return health; }
        private set
        {
            if (value >= 0)
                health = value;
            else
                health = 0;
        }
    }
    */

    protected int maxHealth = 200;
    public int Health { get; protected set; }
    
    public int AttackPower { get; private set; }

    //Methods//
    public void Init(string newName, int newHealth, int newAttackPower)
    {
        Name = newName;
        Health = newHealth;
        AttackPower = newAttackPower;
    }

    public virtual void ShowStatus()
    {
        Debug.Log($"Name: {Name} | Health: {Health} | Attack: {AttackPower}");
    }

    public void TakeDamage(int damageValue)
    {
        //Health -= damageValue;

        Health = Mathf.Clamp(Health - damageValue, 0, maxHealth);

        /*
        if (Health < 0) Health = 0;
        else if (Health > maxHealth) Health = maxHealth;
        */
    }

    public abstract void Attack(Character target);
    public abstract void Attack(Character target, int bonusDamage);

    public abstract void OnDefeated();

    /*
    public virtual void Attack(Character target)
    {
        target.TakeDamage(AttackPower);
    }
    */

    public bool IsAlive() { return Health > 0; } //Died Yet.
}
