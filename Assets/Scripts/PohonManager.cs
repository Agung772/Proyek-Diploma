using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PohonManager : MonoBehaviour
{
    public static PohonManager instance;

    public int rangePohonRotate = 20;

    PlayerController playerController;
    public new Transform camera;
    public PohonController[] pohons;


    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        playerController = PlayerController.instance;

        pohons = FindObjectsOfType<PohonController>();
    }
    void Update()
    {
        RangeToRotate(0);
        RangeToRotate(1);
        RangeToRotate(2);
        RangeToRotate(3);
        RangeToRotate(4);
        RangeToRotate(5);
        RangeToRotate(6);
        RangeToRotate(7);
        RangeToRotate(8);
        RangeToRotate(9);
        RangeToRotate(10);
        RangeToRotate(11);
        RangeToRotate(12);
        RangeToRotate(13);
        RangeToRotate(14);
        RangeToRotate(15);
        RangeToRotate(16);
        RangeToRotate(17);
        RangeToRotate(18);
        RangeToRotate(19);
        RangeToRotate(20);
        RangeToRotate(21);
        RangeToRotate(22);
        RangeToRotate(23);
        RangeToRotate(24);
        RangeToRotate(25);
        RangeToRotate(26);
        RangeToRotate(27);
        RangeToRotate(28);
        RangeToRotate(29);
        RangeToRotate(30);
        RangeToRotate(31);
        RangeToRotate(32);
        RangeToRotate(33);
        RangeToRotate(34);
        RangeToRotate(35);
        RangeToRotate(36);
        RangeToRotate(37);
        RangeToRotate(38);
        RangeToRotate(39);
        RangeToRotate(40);
        RangeToRotate(41);
        RangeToRotate(42);
        RangeToRotate(43);
        RangeToRotate(44);
        RangeToRotate(45);
        RangeToRotate(46);
        RangeToRotate(47);
        RangeToRotate(48);
        RangeToRotate(49);
        RangeToRotate(50);
        RangeToRotate(51);
        RangeToRotate(52);
        RangeToRotate(53);
        RangeToRotate(54);
        RangeToRotate(55);
        RangeToRotate(56);
        RangeToRotate(57);
        RangeToRotate(58);
        RangeToRotate(59);
        RangeToRotate(60);
        RangeToRotate(61);
        RangeToRotate(62);
        RangeToRotate(63);
        RangeToRotate(64);
        RangeToRotate(65);
        RangeToRotate(66);
        RangeToRotate(67);
        RangeToRotate(68);
    }



    void RangeToRotate(int number)
    {
        if (number < pohons.Length)
        {
            if (Vector3.Distance(playerController.transform.position, pohons[number].transform.position) < rangePohonRotate)
            {
                var pohon = pohons[number].transform;

                pohon.GetChild(0).eulerAngles = new Vector3(0, camera.eulerAngles.y, 0);

                //Rotate shadow
                if (pohon.GetChild(0).eulerAngles.y > 270 || pohon.GetChild(0).eulerAngles.y < 90)
                {
                    pohon.GetChild(1).transform.rotation = Quaternion.Euler(0, 0, 0);
                }
                else
                {
                    pohon.GetChild(1).transform.rotation = Quaternion.Euler(0, 180, 0);
                }
            }
        }
        else if (number >= pohons.Length)
        {
            Debug.LogWarning("pohonnya kurang, total pohon : " + pohons.Length);
        }
        else
        {
            Debug.LogWarning("rotate di update kurang, total pohon : " + pohons.Length);
        }

        
    }
}
