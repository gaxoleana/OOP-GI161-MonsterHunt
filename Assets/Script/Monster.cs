using UnityEngine;

public class Monster : Character
{
    //Attributes//
    private int loot;
    public int Loot
    {
        get { return loot; }
        set
        {
            if (value < 0)
                loot = 0;
            else
                loot = value;
        }
    }

    bool defeated = false; //Bool Check

    //Methods//
    public void Init(string newName, int newHealth, int newAttack, int newLoot)
    {
        base.Init(newName, newHealth, newAttack);
        Loot = newLoot;
    }

    public override void ShowStatus()
    {
        base.ShowStatus();
        Debug.Log($"Loot: {Loot}");
    }

    public int lootDrop()
    {
        return loot;
    }

    public bool IsAlive() { return Health > 0; } //Died Yet.
}