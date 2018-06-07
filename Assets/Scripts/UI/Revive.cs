using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Revive : MonoBehaviour {

    public void onReviveClick()
    {
        if (DataManager.instance.money > 200 * DataManager.instance.charLevel)
        {
            DataManager.instance.money -= 200 * DataManager.instance.charLevel;
            CombatManager.instance._isPlayerDie = false;
            PlayerManager.instance.P_HP = PlayerManager.instance.P_BaseHP;
            UIManager.instance.playerReivive.Play("playerRevive");

        }
        else 
        {
            Debug.Log("You dont have enough money");
        }
    }
}
