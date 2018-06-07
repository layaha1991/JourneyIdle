using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnManager : MonoBehaviour 
{
  
    public static EnemySpawnManager instance;

    public GameObject[] enemyPrefab;

    public bool _isEnemy;


    void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);



    }

     void Start()
    {
        enemyPrefab = new GameObject[10];


    }

    private void Update()
    {
        if(_isEnemy == false)
        {
            EnemyTypeManager.instance.Goblin();
            _isEnemy = true;
        }
       

    }




}
