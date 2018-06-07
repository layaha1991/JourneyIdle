using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour 
{

    public static PlayerManager instance;

    void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);
    }

    public float P_BaseHP;
    public float P_BaseDamage ;
    public float P_BaseDefend ;
    public float P_BaseRate ;
    public float P_BaseCritChance ;
    public float P_BaseCritDmg ;

    public float P_HP;
    public float P_Damage;
    public float P_Defend;
    public float P_Rate;
    public float P_CritChance;
    public float P_CritDmg;

    private void Start()
    {
        P_HP = 100f;
        P_Damage = 10f;
        P_Defend = 5f;
        P_Rate = 1f;
        P_CritChance = 0f;
        P_CritDmg = 150f;


        P_BaseHP = P_HP;
        P_BaseDamage = P_Damage;
        P_BaseDefend = P_Defend;
        P_BaseRate = P_Rate;
        P_BaseCritChance = P_CritChance;
        P_BaseCritDmg = P_CritDmg;

    }

    private void Update()
    {
        
    }



}
