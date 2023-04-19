using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemUI : MonoBehaviour
{
    public GameObject makananUI;
    [SerializeField]
    GameObject detailMakananUI;

    [SerializeField]
    GameObject minumanUI;
    [SerializeField]
    GameObject detailMinumanUI;

    [SerializeField]
    GameObject bajuUI;
    [SerializeField]
    GameObject detailBajuUI;

    [SerializeField]
    GameObject obatUI;
    [SerializeField]
    GameObject detailObatUI;

    public void MakananUI()
    {
        FalseUI();

        makananUI.SetActive(true);
    }
    public void DetailMakananUI(Sprite foto, string nama, string deskripsi)
    {
        FalseUI();

        detailMakananUI.SetActive(true);

        var dmUI = detailMakananUI.GetComponent<DetailUI>();

        dmUI.foto.sprite = foto;
        dmUI.nama.text = nama;
        dmUI.deskripsi.text = deskripsi;
    }
    public void MinumanUI()
    {
        FalseUI();

        minumanUI.SetActive(true);
    }
    public void DetailMinumanUI(Sprite foto, string nama, string deskripsi)
    {
        FalseUI();

        detailMinumanUI.SetActive(true);

        var dmUI = detailMinumanUI.GetComponent<DetailUI>();

        dmUI.foto.sprite = foto;
        dmUI.nama.text = nama;
        dmUI.deskripsi.text = deskripsi;
    }
    public void BajuUI()
    {
        FalseUI();

        bajuUI.SetActive(true);
    }
    public void DetailBajuUI(Sprite foto, string nama, string deskripsi)
    {
        FalseUI();

        detailBajuUI.SetActive(true);

        var dmUI = detailBajuUI.GetComponent<DetailUI>();

        dmUI.foto.sprite = foto;
        dmUI.nama.text = nama;
        dmUI.deskripsi.text = deskripsi;
    }
    public void ObatUI()
    {
        FalseUI();

        obatUI.SetActive(true);
    }
    public void DetailObatUI(Sprite foto, string nama, string deskripsi)
    {
        FalseUI();

        detailObatUI.SetActive(true);

        var dmUI = detailObatUI.GetComponent<DetailUI>();

        dmUI.foto.sprite = foto;
        dmUI.nama.text = nama;
        dmUI.deskripsi.text = deskripsi;
    }
    void FalseUI()
    {
        makananUI.SetActive(false);
        detailMakananUI.SetActive(false);

        minumanUI.SetActive(false);
        detailMinumanUI.SetActive(false);

        bajuUI.SetActive(false);
        detailBajuUI.SetActive(false);

        obatUI.SetActive(false);
        detailObatUI.SetActive(false);
    }
}
