using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballistic : MonoBehaviour
{
    public Transform SpawnTransform;
    public Transform TargetTransform;

    public float AngleInDegress;
    void Start()
    {
        
    }
    void Update()
    {
        Vector3 fromTo = TargetTransform.position - transform.position;
        Vector3 fromToXZ = new Vector3(fromTo.x, 0f,  fromTo.z);
        transform.rotation = Quaternion.LookRotation(fromToXZ, Vector3.up);

        Vector3 rotate = SpawnTransform.eulerAngles;
        rotate.x = -AngleInDegress;
        SpawnTransform.rotation = Quaternion.Euler(rotate);
    }
}
