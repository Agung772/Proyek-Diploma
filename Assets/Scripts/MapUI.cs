using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapUI : MonoBehaviour
{
    [SerializeField]
    GameObject cameraRenderMap;


    bool minimapBool;
    public void MiniMap()
    {
        if (!minimapBool)
        {
            minimapBool = true;
            cameraRenderMap.SetActive(true);
        }
        else if (minimapBool)
        {
            minimapBool = false;
            cameraRenderMap.SetActive(false);
        }
    }
}
