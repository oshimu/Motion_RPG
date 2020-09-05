using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject message;
    public int hp;
    public int atk;
    public int def;

    // Start is called before the first frame update
    void Start()
    {
        hp = 500;
        atk = 10;
        def = 0;
    }

    // Update is called once per frame
    void Update()
    {
        var messageText = message.GetComponent<TextMesh>();
        messageText.text = ("HP:" + hp);
    }

    public void Damage(int power)
    {
        //ダメージ計算
        hp -= (power - def);

        //hpが0になった時の処理
        if (hp <= 0)
        {
        }

        Debug.Log("HP残り" + hp);
    }
}
