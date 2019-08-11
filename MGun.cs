using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MGun : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletMGunLVL1;
    public float timeStamp = 0;
    public float cooldownInSeconds = 1f;
    //float speed = 1;

    public void ShootLogic()
    {
        if (timeStamp <= Time.time)
        {
            Debug.Log("pium pium pium");
            GameObject bullet = Instantiate(bulletMGunLVL1, firePoint.position, firePoint.rotation);
            bullet.name = "Bullet";
            timeStamp = Time.time + cooldownInSeconds;
        }

    }
}
