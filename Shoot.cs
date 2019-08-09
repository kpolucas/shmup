using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    float timeStamp = 0;
    int weapon = 1;

    void Update()
    {
        /* La onda seria algo asi
         * timeStamp = bala.Shoot(timeStamp,lvlDeLaBala)
         * 
         * y en Shoot del script Bala
         * if(timeStamp < time.time)
         *  logica de arma en particular
         *  timeStamp = time.time + cooldown
         *  return timeStamp
         */
    }
}
