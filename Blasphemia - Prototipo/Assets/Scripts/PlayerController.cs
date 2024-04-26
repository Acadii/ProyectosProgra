using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //PERSONAJE
    Transform tr;
    Rigidbody rb;

    public float walkSpeed = 200;

    public bool hasPistol = false;


    //CAMARA
    public Transform cameraShoulder;
    public Transform cameraHolder;
    private Transform cam;

    private float rotY = 0f;

    public float rotationSpeed = 200;
    public float minAngle = -45;
    public float maxAngle = 45;
    public float cameraSpeed = 200;

    //ANIMACION
    Animator anim;

    private Vector2 animSpeed;


    void Start()
    {
        tr = this.transform;
        cam = Camera.main.transform;

        rb = GetComponent<Rigidbody>();
        anim = GetComponentInChildren<Animator>();

        hasPistol = true;

        Cursor.lockState = CursorLockMode.Locked;

    }

    void Update()
    {
        CameraControl();
        MoveControl();
        AnimControl();
    }

    public void AnimControl()
    {
        anim.SetFloat("X", animSpeed.x);
        anim.SetFloat("Y", animSpeed.y);

        anim.SetBool("HoldPistol", hasPistol);

        if (hasPistol)
        {
            anim.SetLayerWeight(1, 1);
        }
    }

    public void MoveControl()
    {
        float deltaX = Input.GetAxis("Horizontal");
        float deltaZ = Input.GetAxis("Vertical");
        float deltaT = Time.deltaTime;

        animSpeed = new Vector2(deltaX, deltaZ);

        Vector3 side = walkSpeed * deltaX * deltaT * tr.right;
        Vector3 forward = walkSpeed * deltaZ * deltaT * tr.forward;

        Vector3 direction = side + forward;
        rb.velocity = direction;
    }

    public void CameraControl()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");
        float deltaT = Time.deltaTime;

        rotY += mouseY * rotationSpeed * deltaT;

        float rotX = mouseX * rotationSpeed * deltaT;

        tr.Rotate(0, rotX, 0);

        rotY = Mathf.Clamp(rotY, minAngle, maxAngle);

        Quaternion localRoation = Quaternion.Euler(-rotY, 0, 0);
        cameraShoulder.localRotation = localRoation;

        cam.position = Vector3.Lerp(cam.position, cameraHolder.position, cameraSpeed * deltaT);
        cam.rotation = Quaternion.Lerp(cam.rotation, cameraHolder.rotation, cameraSpeed * deltaT);
    }
}
