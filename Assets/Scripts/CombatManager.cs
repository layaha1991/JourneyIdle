using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatManager : MonoBehaviour {

    public static CombatManager instance;



    private float t_p;
    private float t_e;

    public bool _isPlayerDie;
    public bool _isEnemydie;

    void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);
    }
  
	void Start () 
    {
         
 

	}
	
	void Update () 
    {
        playerAttack();
        enemyAttack();
        playerDie();
        enemyDie();

	}

    private void playerAttack()
    {
        if (EnemySpawnManager.instance._isEnemy == true)
        {
            
            t_p += Time.deltaTime;
            if (t_p > (PlayerManager.instance.P_Rate))
            {
                EnemyTypeManager.instance.E_HP -= PlayerManager.instance.P_Damage;
                t_p = 0f;
            }
        }
    }

    private void enemyAttack()
    {
        if (EnemySpawnManager.instance._isEnemy == true)
        {
            t_e += Time.deltaTime;
            if (t_e > (EnemyTypeManager.instance.E_Rate))
            {
                PlayerManager.instance.P_HP -= EnemyTypeManager.instance.E_Damage;
                t_e = 0f;
            }
        }
    }

    private void playerDie()
    {
        if (PlayerManager.instance.P_HP <= 0f)
        {
            PlayerManager.instance.P_HP = 0f;
            _isPlayerDie = true;

        }
    }

    private void enemyDie()
    {
        if (EnemyTypeManager.instance.E_HP <0f)
        {
            EnemyTypeManager.instance.E_HP = 0f;
            EnemySpawnManager.instance._isEnemy = false;
        }
    }


}
