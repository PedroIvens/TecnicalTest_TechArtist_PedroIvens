using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Movimentation : MonoBehaviour
{
    public float velocity = 10.0f;
    public float rotation = 90.0f;
    void Start()
    {
        UnityEngine.Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");
        
        Vector3 dir = new Vector3(x, 0, y) * velocity;

        transform.Translate(dir * Time.deltaTime);
        transform.Rotate(new Vector3( (mouseY * -1) * rotation * Time.deltaTime, mouseX * rotation * Time.deltaTime, 0));
    }
}
