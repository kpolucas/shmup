using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    public int cantidad;
    public float intervEnSec;
    public GameObject enemyType;
    //public anim queanimacion;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "EnemyTrigger")
        {
            Debug.Log(other.name);
            /*
            GameObject bullet = Instantiate(bulletMGunLVL1, firePoint.position, firePoint.rotation);
            bullet.name = "Bullet";
            */
        }
    }


}
