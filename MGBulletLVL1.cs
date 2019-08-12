using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MGBulletLVL1 : MonoBehaviour
{
    public float bulletSpeed = 17f;
    public int damage = 12;
    void Start()
    {
        Destroy(gameObject, 1f);
    }
    void Update()
    {
        transform.position += Time.deltaTime * new Vector3(0, bulletSpeed, 0);
    }
}
