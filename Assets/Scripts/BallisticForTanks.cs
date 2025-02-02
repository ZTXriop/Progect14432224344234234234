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
    public float radius = 5.0f;

    public bool noticed = false;

    void Start()
    {
        
    }
    void Update()
    {
        ///////////////////////////////////////Поворот башни///////////////////////////////////////
        var rotation = Quaternion.LookRotation(TargetTransform.position - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * speed);
        //////////////////////////////////Обнаружение противника///////////////////////////////////
        Vector3 explosionPosition = transform.position;//Центр объекта
        Collider[] colliders = Physics.OverlapSphere(explosionPosition, radius);//Массив всех объектов в радиусе
        foreach (Collider hit in colliders) //Проверяем все объекты последовательно
        {
            if (hit.transform.GetComponent<UnitInfo>())
            {
                Debug.Log("Вижу");
                RaycastHit hit2;
                Ray ray = new Ray(transform.position, hit.transform.position - transform.position);
                Physics.Raycast(ray, out hit2);
                if (hit2.collider != null)
                {
                    if (hit2.collider.gameObject != hit.gameObject)
                    {
                        Debug.Log("Путь к врагу преграждает объект: " + hit2.collider.name);
                    }
                    else
                    {
                        Debug.Log("Попадаю во врага!!!");
                    }
                }
            }
        }
        if (noticed == true) 
        {

        }
        //Стрельба. Пока пусть по нажатию кнопки будет, потом надо сделать по дистанции!!!!!
        if (Input.GetMouseButtonDown(0))
        {
            Shot();
        }
        
    }
    public void Shot()
    {
        GameObject newBullet = Instantiate(Bullet, SpawnTransform.position, SpawnTransform.rotation);
    }
    public void Proverka()
    {

    }
}
