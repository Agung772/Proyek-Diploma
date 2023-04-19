using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minuman : MonoBehaviour
{
    public Sprite fotoMinuman;

    public string namaMinuman;
    public string deskripsiMinuman;

    public void TransferData()
    {
        BookUI.instance.itemUISC.DetailMinumanUI(fotoMinuman, namaMinuman, deskripsiMinuman);
    }
}
