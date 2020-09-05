using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    //最初の選択肢
    public GameObject FirstMenu;
    public GameObject fightMenu;
    public GameObject itemMenu;
    public GameObject escapeMenu;

    //第二選択肢のオブジェクト
    public GameObject slashObj;

    Button button = null;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        button = other.gameObject.GetComponent<Button>();
        Debug.Log(button.name);
        button.onClick.Invoke();
    }

    public void OnClick()
    {
        if (button != null)
        {
            switch (button.name)
            {
                case "Fight":
                    fightMenu.gameObject.SetActive(true);
                    FirstMenu.gameObject.SetActive(false);
                    break;

                case "Item":
                    itemMenu.gameObject.SetActive(true);
                    FirstMenu.gameObject.SetActive(false);
                    break;

                case "Escape":
                    escapeMenu.gameObject.SetActive(true);
                    FirstMenu.gameObject.SetActive(false);
                    break;

                case "Slash":
                    slashObj.gameObject.SetActive(true);
                    fightMenu.gameObject.SetActive(false);
                    break;
            }
        }

    }
}
