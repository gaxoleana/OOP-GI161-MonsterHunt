using UnityEngine;

public abstract class Character : MonoBehaviour
{
    //Attributes//
    private string name; //Field
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

    public int Attack { get; set; }

    //Methods//
    public void Init(string newName, int newHealth, int newAttack)
    {
        Name = newName;
        Health = newHealth;
        Attack = newAttack;
    }

    public virtual void ShowStatus()
    {
        Debug.Log($"Name: {Name} | Health: {Health} | Attack: {Attack}");
    }

    public void TakeDamage(int damageValue)
    {
        Health -= damageValue;
    }

    public bool IsAlive() { return health > 0; } //Died Yet.
}
