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
        ///////////////////////////////////////������� �����///////////////////////////////////////
        var rotation = Quaternion.LookRotation(TargetTransform.position - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * speed);
        //////////////////////////////////����������� ����������///////////////////////////////////
        Vector3 explosionPosition = transform.position;//����� �������
        Collider[] colliders = Physics.OverlapSphere(explosionPosition, radius);//������ ���� �������� � �������
        foreach (Collider hit in colliders) //��������� ��� ������� ���������������
        {
            if (hit.transform.GetComponent<UnitInfo>())
            {
                Debug.Log("����");
                RaycastHit hit2;
                Ray ray = new Ray(transform.position, hit.transform.position - transform.position);
                Physics.Raycast(ray, out hit2);
                if (hit2.collider != null)
                {
                    if (hit2.collider.gameObject != hit.gameObject)
                    {
                        Debug.Log("���� � ����� ����������� ������: " + hit2.collider.name);
                    }
                    else
                    {
                        Debug.Log("������� �� �����!!!");
                    }
                }
            }
        }
        if (noticed == true) 
        {

        }
        //��������. ���� ����� �� ������� ������ �����, ����� ���� ������� �� ���������!!!!!
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
