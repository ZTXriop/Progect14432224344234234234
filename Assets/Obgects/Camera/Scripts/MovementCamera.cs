using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float Speed = 0.0005f;
    private KeyCode moveForward;
    private KeyCode moveBack;
    public float zoom = 0.1f;
    public float MaxZoom = -1;
    public float MinZoom = 25;

    void Update()
    {
        float y = transform.position.y;
        if (Input.GetKey(KeyCode.W))
        {
            transform.position = transform.position + new Vector3(Speed, 0, 0f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position = transform.position + new Vector3(-Speed, 0, 0f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position = transform.position + new Vector3(0f, 0, Speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position = transform.position + new Vector3(0f, 0, -Speed);
        }
        /*Здесь ниже команды для мыши*/
        if ((Input.GetAxisRaw("Mouse ScrollWheel") > 0) && (y > MaxZoom))
        {
            transform.position = transform.position + new Vector3(0f, -zoom, 0f);/*Приближение*/
        }
        else if ((Input.GetAxisRaw("Mouse ScrollWheel") < 0) && (y < MinZoom))
        {
            transform.position = transform.position + new Vector3(0f, +zoom, 0f);/*Отдаление*/
        }
    }
}
