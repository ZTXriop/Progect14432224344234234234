using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballistic : MonoBehaviour
{
    public GameObject Bullet;
    
    public Transform SpawnTransform;
    public Transform TargetTransform;

    public float AngleInDegress;
    float g = Physics.gravity.y;

    void Start()
    {
        
    }
    void Update()
    {
        Vector3 fromTo = TargetTransform.position - transform.position;
        Vector3 fromToXZ = new Vector3(fromTo.x, 0f, fromTo.z);
        transform.rotation = Quaternion.LookRotation(fromToXZ, Vector3.up);

        Vector3 rotate = SpawnTransform.eulerAngles;
        rotate.x = -AngleInDegress;
        SpawnTransform.rotation = Quaternion.Euler(rotate);

        //Пока пусть по нажатию кнопки будет, потом надо сделать по дистанции!!!!!
        if (Input.GetMouseButtonDown(0))
        {
            Shot();
        }
        
    }
    public void Shot()
    {
        Vector3 fromTo = TargetTransform.position - transform.position;
        Vector3 fromToXZ = new Vector3(fromTo.x, 0f, fromTo.z);

        float x = fromToXZ.magnitude;
        float y = fromTo.y;

        float AngleInRadians = AngleInDegress * Mathf.PI / 180;
        float v2 = (g * x * x) / (2 * (y - Mathf.Tan(AngleInRadians) * x) * Mathf.Pow(Mathf.Cos(AngleInRadians), 2));
        float v = Mathf.Sqrt(Mathf.Abs(v2));
        GameObject newBullet = Instantiate(Bullet, SpawnTransform.position, Quaternion.identity);
        newBullet.GetComponent<Rigidbody>().velocity = SpawnTransform.forward * v;
    }
}
