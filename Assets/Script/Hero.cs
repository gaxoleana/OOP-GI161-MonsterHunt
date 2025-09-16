using UnityEngine;

public class Hero : Character
{
    //Attributes//
    private int gold;
    public int Gold
    {
        get { return gold; }
        set
        {
            if (value < 0)
                gold = 0;
            else if (value >= 1000)
                gold = 999;
            else
                gold = value;
        }
    }

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

    public void EarnGold(int goldAmount)
    {
        if (goldAmount > 0)
        {
            Gold += goldAmount;
        }
    }

    public bool IsAlive() { return Health > 0; } //Died Yet.
}