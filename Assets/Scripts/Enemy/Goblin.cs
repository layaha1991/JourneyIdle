/**using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goblin : MonoBehaviour 
{
    private void Start()
    {
        EnemyManager.instance.name = "Goblin";
        EnemyManager.instance.E_HP = 100f;
        EnemyManager.instance.E_Damage = 10f;
        EnemyManager.instance.E_Defend = 5f;
        EnemyManager.instance.E_Rate =2f ;
        EnemyManager.instance.E_CritChance = 0f;
        EnemyManager.instance.E_CritDmg = 150f;
    }
}**/
