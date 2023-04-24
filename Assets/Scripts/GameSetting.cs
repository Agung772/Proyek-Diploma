using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameSetting : MonoBehaviour
{
    [SerializeField]
    Dropdown grafikGameDD;

    [Space]
    [SerializeField]
    float sensitifMouse;
    [SerializeField]
    Slider sensitifMouseSlider;
    [SerializeField]
    Text senMouseText;

    [Space]
    [SerializeField]
    float kecerahanMatahari;
    [SerializeField]
    Slider kecerahanMatahariSlider;
    [SerializeField]
    Text kecerahanMatahariText;

    [Space]
    [SerializeField]
    float fieldOfView;
    [SerializeField]
    Slider fieldOfViewSlider;
    [SerializeField]
    Text fieldOfViewText;
    private void Start()
    {
        grafikGameDD.value = QualitySettings.GetQualityLevel();

        sensitifMouse = GameplayManager.instance.sensitivitasCam;
        sensitifMouseSlider.value = sensitifMouse / 10;

        kecerahanMatahari = GameplayManager.instance.kecerahanMatahari;
        kecerahanMatahariSlider.value = kecerahanMatahari / 10;

        fieldOfView = GameplayManager.instance.kamera.fieldOfView;
        fieldOfViewSlider.value = fieldOfView / 100;
    }
    public void SetGrafik(int value)
    {
        QualitySettings.SetQualityLevel(value);
    }

    public void SetSensitifMouse(float value)
    {
        GameplayManager.instance.SetSensitivitasCam(value * 10);
        senMouseText.text = (value * 100).ToString("F1") + "%";
    }

    public void SetKecerahanMatahari(float value)
    {
        GameplayManager.instance.SetKecerahanMatahari(value * 10);
        kecerahanMatahariText.text = (value * 100).ToString("F1") + "%";
    }
    public void SetFieldOfView(float value)
    {
        GameplayManager.instance.SetFieldOfView(value * 100);
        fieldOfViewText.text = (value * 100).ToString("F0");
    }
}
