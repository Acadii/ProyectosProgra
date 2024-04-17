using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraView : MonoBehaviour
{
    public float mouseSensitivity = 80f;
    public Transform playerBody;
    float xRotation = 0;
    void Start()
    {
        
    }

    void Update()
    {
        float mouseX = Input.GetAxis("mouse X")* mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("mouse Y")* mouseSensitivity * Time.deltaTime;

        xRotation += mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        transform.localRotation = Quaternion.Euler(xRotation, 0, 0);

        playerBody.Rotate(Vector3.up * mouseX);

    }
}
