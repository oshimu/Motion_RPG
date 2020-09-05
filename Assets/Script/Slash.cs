using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slash : MonoBehaviour
{
    public GameObject[] obj = new GameObject[3];
    public GameObject slashEffect;
    //斬撃を飛ばすための向きを決定するために必要
    public GameObject positionSetter;
    public float power=3.0f;
    private int judge;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("start");
        judge = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (judge >= obj.Length)
        {
            Debug.Log("Slash!");
            GameObject newSlashEffect =Instantiate(slashEffect, transform.position, transform.rotation);

            //コントローラの加速度を取得
            var RightCon = OVRInput.Controller.RTouch;
            Vector3 forcebace = OVRInput.GetLocalControllerAcceleration(RightCon);

            //ベクトルの大きさ
            float magnitude = forcebace.magnitude;
            Debug.Log(magnitude);

            //力を与える向きを計算
            Vector3 slashPosition = positionSetter.transform.position - newSlashEffect.transform.position;
            Debug.Log(slashPosition);

            var slashRb= newSlashEffect.GetComponent<Rigidbody>();
            slashRb.AddForce(slashPosition * magnitude * power,ForceMode.Impulse);

            var hit=newSlashEffect.GetComponent<Hit>();
            hit.TimeReset();

            //このオブジェクトを非表示
            this.gameObject.SetActive(false);
            //判定の初期化
            CounterReset();



        }

    }

    public void CounterReset()
    {
        judge = 0;

        ////子オブジェクトの初期化
        foreach (Transform n in this.transform)
        {
            Debug.Log("aa");
            var activator = n.GetComponent<SlashCounter>();
            activator.FlagActivator();
        }
    }

    public void UpperCounter()
    {
        judge++;
    }
}
