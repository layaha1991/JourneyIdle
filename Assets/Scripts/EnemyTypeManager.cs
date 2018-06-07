
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemyTypeManager: MonoBehaviour
{
    public static EnemyTypeManager instance;
    public enum enemyType { goblin, tank, slime, bounty_hunter }
    public string E_Name;
    public float E_HP;
    public float E_Damage;
    public float E_Defend;
    public float E_Rate;
    public float E_CritChance;
    public float E_CritDmg;

    public float E_BaseHP;

    private void Awake()
    {
        
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);

    }
    private void Start()
    {
        
    }



    public void Goblin()
    {
 
        E_Name = "Goblin";
        E_HP = 100f;
        E_BaseHP = E_HP;
        E_Damage = 50f;
        E_Defend = 5f;
        E_Rate = 2f;
        E_CritChance = 0f;
        E_CritDmg = 150f;
    }

    public void Tank()
    {

        E_Name = "Tank";
        E_HP = 300f;
        E_BaseHP = E_HP;
        E_Damage = 2f;
        E_Defend = 10f;
        E_Rate = 2f;
        E_CritChance = 0f;
        E_CritDmg = 150f;
     
    }


}
