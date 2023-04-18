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

    [SerializeField]
    GameObject minimap;
    public GameObject cam;
    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        CursorVisible(false);
    }

    private void Update()
    {
        CursorPlayer();
        SensitivitasCam();

        if (Input.GetKeyDown(KeyCode.M))
        {
            Minimap();
        }
    }

    bool cursorPlayerAuto;
    void CursorPlayer()
    {
        if (!cursorPlayerAuto) return;

        if (Input.GetKeyDown(KeyCode.LeftAlt) || Input.GetKeyDown(KeyCode.RightAlt))
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;

            useFreeLook = false;
        }
        if (Input.GetKeyUp(KeyCode.LeftAlt) || Input.GetKeyUp(KeyCode.RightAlt))
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;

            useFreeLook = true;
        }
    }

    public void CursorVisible(bool condition)
    {
        if (condition)
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;

            useFreeLook = false;

            cursorPlayerAuto = false;
        }
        else
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;

            useFreeLook = true;

            cursorPlayerAuto = true;
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

    bool minimapBool, minimapCd;
    public void Minimap()
    {
        if (!minimapBool && !minimapCd)
        {
            StartCoroutine(Coroutine());
            IEnumerator Coroutine()
            {
                minimapBool = true;
                minimapCd = true;
                GameManager.instance.Transisi("StartExit");
                CursorVisible(true);
                yield return new WaitForSeconds(1);


                minimap.SetActive(true);
                cam.SetActive(false);

                PlayerController.instance.operation = false;

                yield return new WaitForSeconds(1);
                minimapCd = false;
            }
        }
        else if (minimapBool && !minimapCd)
        {
            StartCoroutine(Coroutine());
            IEnumerator Coroutine()
            {
                minimapBool = false;
                minimapCd = true;
                GameManager.instance.Transisi("StartExit");
                CursorVisible(false);
                yield return new WaitForSeconds(1);


                minimap.SetActive(false);
                cam.SetActive(true);

                PlayerController.instance.operation = true;

                yield return new WaitForSeconds(1);
                minimapCd = false;
            }
        }
    }
}
