using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public int weaponType = 0;
    //public int weaponLVL = 0;
    public GameObject Weapons; //agrego el componente desde el inspector
    MGun machineGun; // genero la variable para storear el script Machinegun

    void Start()
    {
        machineGun = Weapons.GetComponent<MGun>(); // importo from weapons
    }

    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            switch (weaponType)
            {
                case 0:
                    machineGun.ShootLogic();
                    break;
                case 1:
                    //bla
                    break;
                default:
                    //bla
                    break;
            }
        }

    }
}
