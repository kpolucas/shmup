using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineGun : MonoBehaviour
{
    public float timeStamp = 0;
    float cooldownInSeconds = 3f;
    //float speed = 1;

    public void ShootLogic()
    {
        if (timeStamp <= Time.time)
        {
            Debug.Log("pium pium pium");
            timeStamp = Time.time + cooldownInSeconds;
        }
        
    }
}
