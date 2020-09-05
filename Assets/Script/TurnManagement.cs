using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnManagement : MonoBehaviour
{
    //public GameObject enemyMenu;
    public GameObject PlayerMenu;
    public GameObject TurnObj;
    public GameObject Enemy;
    Animator menuAnimator;
    TextMesh menuText;

    void Start()
    {
        //ChangeToPlayerTurn();
        menuAnimator = TurnObj.GetComponent<Animator>();
        menuText = TurnObj.GetComponent<TextMesh>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("space");
            ChangeToEnemyTurn();
        }else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            ChangeToPlayerTurn();
        }

    }


    public void ChangeToPlayerTurn()
    {
        //メニューはいらないので最初に消す
        PlayerMenu.gameObject.SetActive(false);
        TurnObj.gameObject.SetActive(true);
        //テキスト書き換え
        menuText.text = ("PlayerTurn!");
        menuAnimator.SetTrigger("PlayerTurn");
    }

    public void ChangeToEnemyTurn()
    {
        //メニューはいらないので最初に消す
        PlayerMenu.gameObject.SetActive(false);
        TurnObj.gameObject.SetActive(true);
        menuText.text = ("EnemyTurn!");
        menuAnimator.SetTrigger("EnemyTurn");
    }
}

//public string turn = "enemy";
//private bool flag = true;
//start is called before the first frame update


//update is called once per frame
//void update()
//{
//    if (flag)
//    {
//        switch (turn)
//        {
//            case "player":
//                enemymenu.gameobject.setactive(false);
//                playermenu.gameobject.setactive(true);
//                flag = false;
//                break;

//            case "enemy":
//                enemymenu.gameobject.setactive(true);
//                playermenu.gameobject.setactive(false);

//                スクリプトの取得
//                var enemyscript = enemy.getcomponent<enemyattack>();

//                debug.log("enemy");
//                enemyscript.fireattack();
//                flag = false;
//                break;
//        }
//    }
//}

//public void flagactivator()
//{
//    flag = true;
//}