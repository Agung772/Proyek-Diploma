using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckGround : MonoBehaviour
{
    public bool ground;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ground")) ground = true;

        ground = true;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Ground")) ground = false;

        ground = false;
    }
}
