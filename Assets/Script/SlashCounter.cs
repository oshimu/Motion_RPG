using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlashCounter : MonoBehaviour
{
    Slash slash;
    bool flag;
    // Start is called before the first frame update
    void Start()
    {
        var root = transform.root.gameObject;
        slash = root.GetComponent<Slash>();
        flag = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);

        if (other.CompareTag("Player") && flag)
        {
            slash.UpperCounter();
            flag = false;
            Debug.Log("hit");
        }
    }

    public void FlagActivator()
    {
        flag = true;
    }

}
