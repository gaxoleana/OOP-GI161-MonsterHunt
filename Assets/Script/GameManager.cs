using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    public Hero hero;
    public List<Monster> monsterPrefabs;
    public Monster currentMonster;
    public List<Monster> monsters = new List<Monster>();

    void Start()
    {
        hero.Init("Knight", 100, 10);
        hero.ShowStatus();

        SpawnMonster(MonsterType.Goblin);
        SpawnMonster(MonsterType.Orc);
        SpawnMonster(MonsterType.Dragon);

        foreach (var monster in monsters)
        {
            monster.ShowStatus();
        }

        Debug.Log("Battle");

        currentMonster = monsters[0];

        hero.Attack(currentMonster, 10);
        currentMonster.ShowStatus();

        currentMonster.Attack(hero, 5);
        hero.ShowStatus();

        /*
        //---------- Spawn Goblin ----------//
        currentMonster = Instantiate(monsterPrefabs[0]); //Spawn monster game object from prefabs
        monsters.Add(currentMonster); //Keep track of monster spawn in scene
        currentMonster.Init("Goblin", 100, 5, 20); //Initialization
        //----------------------------------//

        //---------- Spawn Orc ----------//
        currentMonster = Instantiate(monsterPrefabs[1]);
        monsters.Add(currentMonster);
        currentMonster.Init("Orc", 150, 10, 50);
        //-------------------------------//

        //---------- Spawn Dragon ----------//
        currentMonster = Instantiate(monsterPrefabs[2]);
        monsters.Add(currentMonster);
        currentMonster.Init("Dragon", 200, 20, 100);
        //----------------------------------//

        foreach (Monster monster in monsters)
        {
            monster.ShowStatus();
        }

        Debug.Log("Battle");

        currentMonster = monsters[0];
        
        hero.Attack(currentMonster, 10);
        currentMonster.ShowStatus();
        
        currentMonster.Attack(hero, 5);
        hero.ShowStatus();

        //Monster is defeated - Hero earn loot golds
        Debug.Log($"{currentMonster.Name} is defeated!");
        hero.EarnGold(currentMonster.Loot);
        hero.ShowStatus();
        */
    }

    public void SpawnMonster(MonsterType monsterType)
    {
        Monster monsterPrefab = monsterPrefabs[(int)monsterType];

        Monster monsterObj = Instantiate(monsterPrefab);

        monsterObj.Init(monsterType);
        monsters.Add(monsterObj);
    }
}
