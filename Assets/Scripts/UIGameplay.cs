using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIGameplay : MonoBehaviour
{
    public static UIGameplay instance;

    [SerializeField]
    GameObject bookUI;
    private void Awake()
    {
        instance = this;
    }

    bool bookBool;
    public void BookUI()
    {
        if (!bookBool)
        {
            bookBool = true;
            bookUI.SetActive(true);

            bookUI.GetComponent<BookUI>().StartBookUI();

            GameplayManager.instance.CursorVisible(true);
        }
        else
        {
            bookBool = false;
            bookUI.SetActive(false);

            GameplayManager.instance.CursorVisible(false);
        }
    }
}
