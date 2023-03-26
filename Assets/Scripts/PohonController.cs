using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PohonController : MonoBehaviour
{
    public Transform pohonNonAktif;
    public Transform pohonAktif;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            transform.SetParent(pohonAktif);
            PohonManager.instance.UpdatePohons();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            transform.SetParent(pohonNonAktif);
            PohonManager.instance.UpdatePohons();
        }
    }
}
