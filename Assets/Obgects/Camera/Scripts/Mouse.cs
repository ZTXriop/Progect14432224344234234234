using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{
    public GameObject ykasatel;
    private Camera cam;
    void Start()
    {
        
        cam = Camera.main;
    }
    
    void Update()
    {
        
        if (Input.GetMouseButtonDown(1))
        {
            // сюда запишется инфо о пересечении луча, если оно будет
            RaycastHit hit;
            // сам луч, начинается от позиции камеры походу и направлен в сторону курсора
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            // пускаем луч
            Physics.Raycast(ray, out hit);
            // если луч с чем-то пересёкся, то...
            if (Physics.Raycast(ray, out hit))
            {
                // Если пересечение есть, можно получить информацию о нём
                Debug.Log("Попал в объект: ");
                GameObject newObject = Instantiate(ykasatel, hit.point, Quaternion.identity);
            }
        }
    }
}
