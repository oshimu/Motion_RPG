using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public GameObject fireBall;
    public GameObject dragon;

    float time;
    bool addTime = false;

    public void FireAttack()
    {
        Debug.Log("fire");
        var animator = dragon.GetComponent<Animator>();
        animator.SetTrigger("Attack");

            //火球を召喚
            GameObject newFireBall = Instantiate(fireBall, transform.position, transform.rotation);

            //与えるベクトルの大きさ
            float magnitude = Random.Range(15, 30);
            Debug.Log(magnitude);

            //力を与える向きを計算
            Vector3 objPosition = Camera.main.transform.position - newFireBall.transform.position;

            var fbRb = newFireBall.GetComponent<Rigidbody>();
            fbRb.AddForce(objPosition * magnitude, ForceMode.Impulse);


            var hit = newFireBall.GetComponent<Hit>();
            hit.TimeReset();
    }
}
