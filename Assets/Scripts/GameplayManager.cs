using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class GameplayManager : MonoBehaviour
{
    public static GameplayManager instance;

    bool useFreeLook;
    float sensitivitasCam = 2;

    public CinemachineFreeLook cinemachineFreeLook;
    private void Awake()
    {
        instance = this;
    }

    private void Update()
    {
        CursorPlayer();
        SensitivitasCam();
    }


    void CursorPlayer()
    {
        if (Input.GetKey(KeyCode.LeftAlt) || Input.GetKey(KeyCode.RightAlt))
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;

            useFreeLook = false;
        }
        else
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;

            useFreeLook = true;
        }
    }

    public void SetSensitivitasCam(float value)
    {
        sensitivitasCam = value;
    }
    void SensitivitasCam()
    {
        if (useFreeLook)
        {
            cinemachineFreeLook.m_YAxis.m_MaxSpeed = sensitivitasCam;
            cinemachineFreeLook.m_XAxis.m_MaxSpeed = sensitivitasCam * 60;
        }
        else
        {
            cinemachineFreeLook.m_YAxis.m_MaxSpeed = 0;
            cinemachineFreeLook.m_XAxis.m_MaxSpeed = 0;
        }
    }
}
