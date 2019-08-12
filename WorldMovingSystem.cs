using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldMovingSystem : MonoBehaviour
{
    public float speed = 0.1f;

    void Update()
    {
        transform.position += new Vector3(0, speed, 0);
    }
}
