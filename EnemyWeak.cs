using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWeak : MonoBehaviour
{
    public float speed = 1f;


    void Update()
    {
        transform.position += Time.deltaTime * transform.up * speed ;
    }
}
