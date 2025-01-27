using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float Speed;
    void Start()
    {
        
    }
    void FixedUpdate()
    {
        transform.localPosition += new Vector3(0f, 0f, Speed);
    }
}
