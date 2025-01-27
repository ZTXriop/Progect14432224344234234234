using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallisticForTanks : MonoBehaviour
{
    public GameObject Bullet;
    
    public Transform SpawnTransform;
    public Transform TargetTransform;

    public float AngleInDegress;
    public float speed;

    public bool noticed = false;

    void Start()
    {
        
    }
    void Update()
    {
        var rotation = Quaternion.LookRotation(TargetTransform.position - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * speed);
        
        if (noticed == true) 
        {

        }
        //Пока пусть по нажатию кнопки будет, потом надо сделать по дистанции!!!!!
        if (Input.GetMouseButtonDown(0))
        {
            Shot();
        }
        
    }
    public void Shot()
    {
        GameObject newBullet = Instantiate(Bullet, SpawnTransform.position, SpawnTransform.rotation);
    }
    
}
