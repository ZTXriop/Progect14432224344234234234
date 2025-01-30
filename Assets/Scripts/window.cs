using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class window : MonoBehaviour
{
    public GameObject Prefab_HUD;
    void OnMouseDowne()
    {
        Prefab_HUD.SetActive(!Prefab_HUD.activeSelf);
    }
}
