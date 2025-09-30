using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    public Hero hero;
    
    public List<Monster> monsterPrefabs;
    public Monster currentMonster;
    public List<Monster> monsters = new List<Monster>();

    public List<Weapons> weaponPrefabs;

    void Start()
    {
        hero.Init("Knight", 100, 10);
        hero.ShowStatus();

        Weapons sword = Instantiate(weaponPrefabs[0], new Vector3(-3, -1, 0), Quaternion.identity);
        Weapons knife = Instantiate(weaponPrefabs[1], new Vector3(-1, -1, 0), Quaternion.identity);
        Weapons club = Instantiate(weaponPrefabs[2], new Vector3(1, -1, 0), Quaternion.identity);
        Weapons gun = Instantiate(weaponPrefabs[3], new Vector3(3, -1, 0), Quaternion.identity);

        sword.InitWeapon("Sword", 10);
        knife.InitWeapon("Knife", 5);
        club.InitWeapon("Club", 10);
        gun.InitWeapon("Gun", 30);

        //-----------------------------------------------//
        Monster goblinObj = Instantiate(monsterPrefabs[0]);
        Goblin goblin1 = goblinObj.GetComponent<Goblin>();
        if (goblinObj != null)
        {
            goblin1.InitializeGoblin("Gojek");
        }
        monsters.Add(goblinObj);
        //-----------------------------------------------//

        //--------------------------------------------//
        Monster orcObj = Instantiate(monsterPrefabs[1]);
        Orc orc1 = orcObj.GetComponent<Orc>();
        if (orcObj != null)
        {
            orc1.InitializeOrc("Pitong");
        }
        monsters.Add(orcObj);
        //--------------------------------------------//

        //-----------------------------------------------//
        Monster dragonObj = Instantiate(monsterPrefabs[2]);
        Dragon dragon1 = dragonObj.GetComponent<Dragon>();
        if (dragonObj != null)
        {
            dragon1.InitializeDragon("Dragoon");
        }
        monsters.Add(dragonObj);
        //-----------------------------------------------//

        foreach (var monster in monsters)
        {
            monster.ShowStatus();
            monster.Roar();
        }

        Debug.Log("");
        Debug.Log("//----------Battle----------//");

        currentMonster = monsters[0];

        hero.Attack(currentMonster, 10);
        currentMonster.ShowStatus();

        currentMonster.Attack(hero);
        hero.ShowStatus();

        Debug.Log("");
        Debug.Log("//----------Battle with Weapons----------//");
        hero.EquipWeapon(sword);
        goblin1.EquipWeapon(knife);
        orc1.EquipWeapon(club);
        dragon1.EquipWeapon(gun);

        hero.Attack(dragon1, hero.EquippedWeapon);

        foreach (var monster in monsters)
        {
            monster.Attack(hero, monster.EquippedWeapon);
        }

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
}
