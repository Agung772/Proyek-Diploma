using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Makanan : MonoBehaviour
{
    public Sprite fotoMakanan;

    public string namaMakanan;
    public string deskripsiMakanan;

    public void TransferData()
    {
        BookUI.instance.itemUISC.DetailMakananUI(fotoMakanan, namaMakanan, deskripsiMakanan);
    }
}
