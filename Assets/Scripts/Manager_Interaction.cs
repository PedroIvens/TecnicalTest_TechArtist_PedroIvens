using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    private RaycastHit hit;
    private Ray ray;

    void Update()
    {
        if (!Input.GetMouseButtonDown(0))
            return;
        Debug.Log("Click!");
        this.ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if(!Physics.Raycast(this.ray, out this.hit))
            return;
        Debug.Log("RayCast");
        Debug.Log(this.hit.transform.name);

        Activate_TL director = this.hit.transform.GetComponent<Activate_TL>();
        if(director)
        {
            Debug.Log("VFXActivate!");
            director.ActivateTL();
        }
    }
}
