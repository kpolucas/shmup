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
            int i = 0;
            while (i < cantidad)
            {
	        GameObject enemy = Instantiate(enemyType, transform.position, transform.rotation); // puede fallar
	        enemy.name = "Enemy";
	        //sleep intervEnSec;
	        i++;
	    }
        }
    }


}
