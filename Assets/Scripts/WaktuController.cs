using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity;

public enum Waktu
{
    Pagi,
    Siang,
    Malam,
}
public class WaktuController : MonoBehaviour
{
    public static WaktuController instance;

    public Waktu waktu;

    public float kecepatanWaktu = 1;

    public float setJam;
    public float menitLocal;
    public float menitGlobal;
    public float jam;

    public float fogTime;

    public Transform directionalLight;
    public GameObject volumeFog;

    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        SetJam(setJam);

        if (7 >= 6)
        {
            print("Yessssssssssssssss");
        }
    }
    private void Update()
    {
        menitGlobal += Time.deltaTime * kecepatanWaktu;
        menitLocal += Time.deltaTime * kecepatanWaktu;

        //Hitungan jam
        if (menitLocal >= 15)
        {
            jam++;
            menitLocal = 0;
        }
        //Hitungan hari
        if (jam >= 24)
        {
            jam = 0;
            menitGlobal = 0;
        }

        //Rotasi Directiona lLight
        directionalLight.rotation = Quaternion.Euler(menitGlobal + 90 + 180, 0.0f, 0.0f);

        //Mencari tau kondisi waktu
        if (jam >= 19)
        {
            waktu = Waktu.Malam;
        }
        else if (jam >= 11)
        {
            waktu = Waktu.Siang;
        }
        else if (jam >= 0)
        {
            waktu = Waktu.Pagi;
        }

        //Ubah warna fog lighting
        if (jam >= 19)
        {
            SetFog(true);
        }
        else if (jam >= 18)
        {
            fogTime -= Time.deltaTime * 0.1f;
        }
        else if (jam >= 6)
        {
            fogTime += Time.deltaTime * 0.1f;

            SetFog(false);
        }
        fogTime = Mathf.Clamp(fogTime, 0, 0.9f);
        RenderSettings.fogColor = new Color(fogTime, fogTime, fogTime, 1);

    }

    //Siang = 165
    //Malam = 290
    //Pagi = 0

    public void SetJam(float setJam)
    {
        menitGlobal = setJam * 15;
        jam = setJam;
        if (jam >= 18)
        {
            fogTime = 0;
            SetFog(true);
            print("Gelapfog");
        }
        else if (jam >= 6)
        {
            fogTime = 1;
            SetFog(false);
        }
        else if (jam >= 0)
        {
            fogTime = 0;
            SetFog(true);
        }
    }

    //FogParticle
    string fogCondition;
    void SetFog(bool set)
    {
        if (set && fogCondition != "true")
        {
            fogCondition = "true";
            volumeFog.SetActive(true);

            print("Hidupin fog");
        }
        else if (!set && fogCondition != "false")
        {
            fogCondition = "false";
            GameObject[] fogs = new GameObject[volumeFog.transform.childCount];
            for (int i = 0; i < fogs.Length; i++)
            {
                if (i != volumeFog.transform.childCount - 1)
                {
                    fogs[i] = volumeFog.transform.GetChild(i).gameObject;
                    fogs[i].GetComponent<ParticleSystem>().Stop();
                }

            }

            StartCoroutine(Coroutine());
            IEnumerator Coroutine()
            {
                yield return new WaitForSeconds(5);
                volumeFog.SetActive(false);
            }

            print("Matiin fog");
        }
    }
}
