class Monster
{
    // In class data call attributes
    public string Name;
    public int Health;
    private bool Defeated;

    // Constructor to create an object
    public Monster(string newName, int newHealth)
    {
        Name = newName;
        Health = newHealth;
        Defeated = false;
    }
}