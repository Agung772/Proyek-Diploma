using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PohonManager : MonoBehaviour
{
    public static PohonManager instance;

    public new Transform camera;
    public Transform pohonAktif;

    public Transform[] pohonRenderers;

    private void Awake()
    {
        instance = this;
    }
    void Update()
    {
        RotatePohon(0);
        RotatePohon(1);
        RotatePohon(2);
        RotatePohon(3);
        RotatePohon(4);
        RotatePohon(5);
        RotatePohon(6);
    }

    public void UpdatePohons()
    {
        pohonRenderers = new Transform[pohonAktif.childCount];
        for (int i = 0; i < pohonAktif.childCount; i++)
        {
            pohonRenderers[i] = pohonAktif.GetChild(i).transform.GetChild(0).transform;
        }
    }
    void RotatePohon(int number)
    {
        if (number < pohonRenderers.Length)
        {
            pohonRenderers[number].transform.eulerAngles = new Vector3(0, camera.eulerAngles.y, 0);

            //Rotate shadow
            if (pohonRenderers[number].transform.eulerAngles.y > 270 || pohonRenderers[number].transform.eulerAngles.y < 90)
            {
                pohonAktif.GetChild(number).transform.GetChild(1).transform.rotation = Quaternion.Euler(0, 0, 0);
            }
            else 
            {
                pohonAktif.GetChild(number).transform.GetChild(1).transform.rotation = Quaternion.Euler(0, 180, 0);
            }
        }
    }
}
