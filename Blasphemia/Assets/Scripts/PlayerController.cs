using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //PERSONAJE
    Transform playerTr;

    //CAMARA
    public Transform cameraAxis;
    public Transform cameraTrack;
    private Transform theCamera;

    private float rotY = 0f;
    private float rotX = 0f;

    public float camRotSpeed = 200f;
    public float minAngle = -45f;
    public float maxAngle = 45f;
    public float cameraSpeed = 200f;



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
