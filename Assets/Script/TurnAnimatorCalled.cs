using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnAnimatorCalled : MonoBehaviour
{
    public GameObject Enemy;
    public GameObject PlayerMenu;

    public void PlayerTurn()
    {
        this.gameObject.SetActive(false);
        PlayerMenu.gameObject.SetActive(true);
    }

    public void EnemyTurn()
    {
        this.gameObject.SetActive(false);
       
        //ボール発射部分のスクリプトの取得
        var EnemyScript = Enemy.GetComponent<EnemyAttack>();

        Debug.Log("Enemy");
        EnemyScript.FireAttack();
    }

}
