using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{
    public float lifeSpan = 10f;
    public float speedWeight=0.5f;
    public string target ="Enemy";
    public string exclusion = "MainCamera";
    float time = 0;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
       time += Time.deltaTime;

        //n秒後に消失
        if (time >= lifeSpan)
        {
            Destroy(this.gameObject);
        }
        
    }

    //オブジェクトを取得した時に動作
    private void OnTriggerEnter(Collider other)
    {   
        Debug.Log(other.gameObject.name);
        
        if (other.CompareTag(target))
        {
            Debug.Log(target+"にhit");

            //ヒットした対象の取得
            var rgb = GetComponent<Rigidbody>();
            var power = rgb.velocity.magnitude * speedWeight;
            var hitObj = other.gameObject;
            Debug.Log("power"+power);

            //取得するスクリプトの選択
            switch (target)
            {
                case "Enemy":
                    Enemy script = hitObj.GetComponent<Enemy>();
                    script.Damage((int)power);
                    break;
                case "MainCamera":
                    Player scriptPlayer = hitObj.GetComponent<Player>();
                    scriptPlayer.Damage((int)power);
                    break;

            }
            Destroy(this.gameObject);
        }
        //除外対象以外に当たった時はただ消える
        else if (!other.CompareTag(exclusion))
        {
            Destroy(this.gameObject);
        }
    }

    public void TimeReset()
    {
        time = 0;
    }
}
