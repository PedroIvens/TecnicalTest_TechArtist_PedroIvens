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
        if(!Input.GetMouseButtonDown(0))
            return;
        
        this.ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if(!Physics.Raycast(this.ray, out this.hit))
            return;
        
        Debug.Log(this.hit.transform.name);

        Activate_VFX activate_VFX = this.hit.transform.GetComponent<Activate_VFX>();
        if(activate_VFX)
        {
            activate_VFX.ActivateVFX();
        }
    }
}
