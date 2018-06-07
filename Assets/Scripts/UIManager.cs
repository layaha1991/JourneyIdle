using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {
    
    public static UIManager instance;

    public Animator playerDie;
    public Animator playerReivive;

    public Image player;
    public Image playerHPBar;
    public Image enemyHPBar;

    public GameObject revive;
    void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);
    }

    private void Start()
    {
        playerDie = playerDie.GetComponent<Animator>();


    }

    private void Update()
    {
        playerHPBarFucntion();
        enemyHPBarFunction();
        playerDieAni();
        buttonControl();
    }
    private void playerHPBarFucntion()
    {
        playerHPBar.fillAmount = PlayerManager.instance.P_HP / PlayerManager.instance.P_BaseHP;
    }

    private void enemyHPBarFunction()

    {
        enemyHPBar.fillAmount = EnemyTypeManager.instance.E_HP / EnemyTypeManager.instance.E_BaseHP;

    }

    private void playerDieAni()
    {
        if (CombatManager.instance._isPlayerDie == true)
        {
      
            playerDie.Play("playerDie");
        }
    }

    private void buttonControl()
    {
        if (CombatManager.instance._isPlayerDie == true)
        {
            revive.SetActive(true);
        }
        else if (CombatManager.instance._isPlayerDie == false)
        {
            revive.SetActive(false);
        }
    }




}
