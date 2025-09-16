using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    public Hero hero;
    public List<Monster> monstersPrefabs;
    public Monster currentMonster;
    public List<Monster> monsters = new List<Monster>();

    void Start()
    {
        hero.Init("Knight", 100, 10);
        hero.ShowStatus();

        //---------- Spawn Goblin ----------//
        currentMonster = Instantiate(monstersPrefabs[0]); //Spawn monster game object from prefabs
        monsters.Add(currentMonster); //Keep track of monster spawn in scene
        currentMonster.Init("Goblin", 100, 5, 20); //Initialization
        //----------------------------------//

        //---------- Spawn Orc ----------//
        currentMonster = Instantiate(monstersPrefabs[1]);
        monsters.Add(currentMonster);
        currentMonster.Init("Orc", 150, 10, 50);
        //-------------------------------//

        //---------- Spawn Dragon ----------//
        currentMonster = Instantiate(monstersPrefabs[2]);
        monsters.Add(currentMonster);
        currentMonster.Init("Dragon", 200, 20, 100);
        //----------------------------------//

        foreach (Monster m in monsters)
        {
            m.ShowStatus();
        }

    }
}
