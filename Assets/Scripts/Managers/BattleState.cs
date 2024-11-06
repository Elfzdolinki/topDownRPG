using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public enum BattleStates{ START, PLAYERTURN, ENEMYTURN, WON, LOST}

public class BattleState : MonoBehaviour
{
    public PlayerController PlayerController;

    public GameObject playerPrefab;
    public GameObject enemyPrefab;
    public GameObject BattleUI;

    public Transform playerBattleStation;
    public Transform enemyBattleStation;

    public BattleStates state;

    //Unit playerUnit;
    //Unit enemyUnit;

    // Start is called before the first frame update
    void Start()
    {
        enemyPrefab = null; 
    }

    public void SetupBattle()
    {
        PlayerController.inBattle = true; // stopuje gracza w  walce
        BattleUI.SetActive(true);

        //GameObject playerGO = playerPrefab;
        //playerGO.GetComponent<Unit>();
        playerPrefab.transform.position = playerBattleStation.position;

        //GameObject enemyGO = enemyPrefab;
        //enemyGO.GetComponent<Unit>();
        enemyPrefab.transform.position = enemyBattleStation.position;


         

    }

    public void PlayerTurn()
    {

    }
}
