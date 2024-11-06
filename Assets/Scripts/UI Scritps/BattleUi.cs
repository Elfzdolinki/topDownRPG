using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BattleUi : MonoBehaviour
{
    public bool inBattle;

    public GameObject battleUI;

    public PlayerController playerController;


    private void Start()
    {
        battleUI.SetActive(false);
    }

}
