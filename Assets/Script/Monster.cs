using UnityEngine;

public class Monster : MonoBehaviour
{
    //Attributes//
    public string Name;

    private int health; //Field
    public int Health //Property
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

    private int loot;
    public int Loot
    {
        get { return loot; }
        set
        {
            if (value < 0)
                value = loot;
            else
                value = 1;
        }
    }

    bool defeated = false; //Bool Check

    //Methods//
    public void Init(string newName, int newHealth, int newAttack, int newLoot)
    {
        Name = newName;
        Health = newHealth;
        Attack = newAttack;
        Loot = newLoot;
    }

    public void ShowStatus()
    {
        Debug.Log($"Monster: {Name} | Health: {Health} | Attack: {Attack} | Coin: {Loot}");
    }

    public void TakeDamage(int damageValue)
    {
        Health -= damageValue;
        Debug.Log("Take damage");
    }

    public int DropReward()
    {
        return loot;
    }

    public bool IsAlive() { return health > 0; } //Died Yet.
}