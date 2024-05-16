using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MeshToggler : MonoBehaviour
{
    public GameObject TurbineObject;
    private bool isActive = true;

    public void ToggleMesh()
    {
        if (isActive)
        {
            TurbineObject.SetActive(false);
            isActive = false;
        }
        else
        {
            TurbineObject.SetActive(true);
            isActive = true;
        }
       
    }
}
