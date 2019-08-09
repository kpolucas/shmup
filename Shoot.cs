using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public int weaponType = 0;
    //public int weaponLVL = 0;
    MachineGun machineGun;

    void Start()
    {
        machineGun = new MachineGun(); // revisar porque esta como el orto 
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
