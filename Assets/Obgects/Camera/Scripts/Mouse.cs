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
        if (Input.GetMouseButtonDown(0))
        {
            // ���� ��������� ���� � ����������� ����, ���� ��� �����
            RaycastHit hit;
            // ��� ���, ���������� �� ������� ������ ������ � ��������� � ������� �������
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            // ������� ���
            Physics.Raycast(ray, out hit);
            if (Physics.Raycast(ray, out hit))
            {
                
            }
        }
    }
}
