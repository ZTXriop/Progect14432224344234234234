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

    void Start()
    {
        
    }
    void Update()
    {
        transform.rotation = Quaternion.RotateTowards(transform.rotation, TargetTransform.rotation, speed * Time.deltaTime);

        //Пока пусть по нажатию кнопки будет, потом надо сделать по дистанции!!!!!
        if (Input.GetMouseButtonDown(0))
        {
            Shot();
        }
        
    }
    public void Shot()
    {
        

        GameObject newBullet = Instantiate(Bullet, SpawnTransform.position, Quaternion.identity);
    }
}
