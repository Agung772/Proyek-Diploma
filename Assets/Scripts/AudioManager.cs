using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    [SerializeField]
    float volumeBGM;
    [SerializeField]
    float volumeSFX;

    [SerializeField]
    AudioSource audioSourceBGM;
    [SerializeField]
    AudioSource audioSourceSFX;

    [SerializeField]
    Slider sliderBGM;
    [SerializeField]
    Slider sliderSFX;

    string _VolumeBGM = "VolumeBGM";
    string _VolumeSFX = "VolumeSFX";
    string _DefaultVolume = "DefaultVolume";

    private void Start()
    {
        if (PlayerPrefs.GetFloat(_DefaultVolume) == 0)
        {
            PlayerPrefs.SetFloat(_DefaultVolume, 1);
            PlayerPrefs.SetFloat(_VolumeBGM, 0.6f);
            PlayerPrefs.SetFloat(_VolumeSFX, 0.6f);
        }

        LoadVolume();
    }

    void LoadVolume()
    {
        volumeBGM = PlayerPrefs.GetFloat(_VolumeBGM);
        volumeSFX = PlayerPrefs.GetFloat(_VolumeSFX);

        audioSourceBGM.volume = volumeBGM;
        audioSourceSFX.volume = volumeSFX;

        sliderBGM.value = volumeBGM;
        sliderSFX.value = volumeSFX;
    }
    public void ValueBGM(float value)
    {
        volumeBGM = value;
        audioSourceBGM.volume = volumeBGM;
        PlayerPrefs.SetFloat(_VolumeBGM, volumeBGM);
        volumeBGM = Mathf.Clamp(volumeBGM, 0, 1);
    }
    public void ValueSFX(float value)
    {
        volumeSFX = value;
        audioSourceSFX.volume = volumeSFX;
        PlayerPrefs.SetFloat(_VolumeSFX, volumeSFX);
        volumeSFX = Mathf.Clamp(volumeSFX, 0, 1);
    }
}
