class Hero
{
    // In class data call attributes
    public string Name;
    public int Health;
    public int Gold;

    // Constructor to create an object
    public Hero(string newName, int newHealth)
    {
        Name = newName;
        Health = newHealth;
        Gold = 0;
    }
}