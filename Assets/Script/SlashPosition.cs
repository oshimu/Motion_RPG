using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlashPosition : MonoBehaviour
{
    public Vector3 position = new Vector3(0, 0, 1);
    public Vector3 angle = new Vector3(0, 0, 0);

    // Start is called before the first frame update
    void Start()
    {
        var target = Camera.main.transform;
        Debug.Log(target.position);
    }

    // Update is called once per frame
    void Update()
    {
        // 自分の目の前に持ってくる(角度はすこしずらす)
        Vector3 slashLocalPos = Quaternion.Euler(0f, 0f, 0f) * position * 1.5f;
        Vector3 slashWorldPos = Camera.main.transform.TransformPoint(slashLocalPos);
        transform.position = slashWorldPos;

        // こっちを向かせる(角度調整あり)
        Vector3 slashAngle = new Vector3(Camera.main.transform.eulerAngles.x + angle.x, Camera.main.transform.eulerAngles.y + angle.y, Camera.main.transform.eulerAngles.z + angle.z);
        transform.eulerAngles = new Vector3(slashAngle.x, slashAngle.y, slashAngle.z);
    }
}
