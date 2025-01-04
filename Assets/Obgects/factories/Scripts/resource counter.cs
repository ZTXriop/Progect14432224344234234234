using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class resourcecounter : MonoBehaviour
{
    public int resource = 0;
    //private int a = resource + number;
    public float Second = 1f;
    public int number = 1;
    private Coroutine MyCoroutin;


    private void Start()
    {
        MyCoroutin = StartCoroutine(Addresource());
    }
   
    IEnumerator Addresource()
    {
        while (true)
        {
            resource++;
            Debug.Log(resource);
            yield return new WaitForSeconds(Second);
        }
    }
}

