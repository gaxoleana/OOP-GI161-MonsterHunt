using UnityEngine;

public class Hero : MonoBehaviour
{
    //Attributes//
#pragma warning disable CS0108 // Member hides inherited member; missing new keyword
    private string name; //Field
#pragma warning restore CS0108 // Member hides inherited member; missing new keyword
    public string Name //Property
    {
        get { return name; }
        set
        {
            if (string.IsNullOrEmpty(value))
                name = "Unknow player";
            else
                name = value;
        }
    }

    private int health;
    public int Health
    {
        get { return health; }
        set
        {
            if (value >= 0)
                health = value;
            else
                health = 0;
        }
    }

    public int Attack { get; private set; }

    private int gold;
    public int Gold
    {
        get { return gold; }
        set
        {
            if (value > 999)
                gold = 999;
            else if (value < 0)
                gold = 0;
            else
                gold = value;
        }
    }
    
    //Methods//
    public void Init(string newName, int newHealth, int newAttack, int newGold)
    {
        Name = newName;
        Health = newHealth;
        Attack = newAttack;
        Gold = newGold;
    }

    public void ShowStatus()
    {
        Debug.Log($"Name: {Name} | Health: {Health} | Gold: {Gold}");
    }

    public void TakeDamage(int damageValue)
    {
        Health -= damageValue;
    }

    public void EarnGold(int amount)
    {
        if (amount > 0)
        {
            Gold += amount;
        }
    }

    public bool IsAlive() { return health > 0; } //Died Yet.
}