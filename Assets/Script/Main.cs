using UnityEngine;

public class Main : MonoBehaviour
{
    Hero hero = new Hero("Knight", 100);
    Monster monster = new Monster("Goblin", 150);
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log($"Hero: {hero.Name} | HP: {hero.Health} | Gold: {hero.Gold}");
        Debug.Log($"Monster: {monster.Name} | HP: {monster.Health}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
