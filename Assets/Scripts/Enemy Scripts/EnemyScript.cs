using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour, Interactable 
{
    public GameObject self;

    public int unitLvl;
    public string enemyName;

    public int damage;

    public int maxHP;
    public int currentHP;

    public BattleState battleState;


    public void Interact()
    {
        battleState.state = BattleStates.START;
        battleState.enemyPrefab = self;
        battleState.SetupBattle();
       
    }
}
