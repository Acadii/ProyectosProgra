using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorJugador : MonoBehaviour
{
    //MOVIMIENTO
    public float movHorizontal;
    public float movVertical;
    public CharacterController player;
    public Animator playerAnimator;
    private Vector3 playerInput;
    public float velocidad;

    //PERSONAJE
    Transform tr;

    //CAMARA
    public Transform camaraHombro;
    public Transform camaraHolder;
    private Transform cam;

    private float rotacionY = 0f;

    public float velocidadCamRotacion = 200;
    public float anguloMinimo = -45;
    public float anguloMaximo = 45;
    public float camaraVelocidad = 200;

    void Start()
    {
        //PERSONAJE
        player = GetComponent<CharacterController>();
        playerAnimator = GetComponent<Animator>();

        tr = this.transform;
        cam = Camera.main.transform;


    }


    void Update()
    {
        movHorizontal = Input.GetAxis("Horizontal");
        movVertical = Input.GetAxis("Vertical");


        player.Move(new Vector3(movHorizontal, 0, movVertical) * velocidad * Time.deltaTime);
        
        playerInput = new Vector3(movHorizontal, 0, movVertical);
        playerInput = Vector3.ClampMagnitude(playerInput, 1);

        playerAnimator.SetFloat("VelocidadCaminando", playerInput.magnitude * velocidad);

        //CAMERA
        CameraControl();

    }

    private void OnAnimatorMove()
    {

    }

    //Movimiento Camara 
    public void CameraControl()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");
        float deltaT = Time.deltaTime;

        rotacionY += mouseY * velocidadCamRotacion * deltaT;
        float rotacionX = mouseX * velocidadCamRotacion * deltaT;

        tr.Rotate(0, rotacionX, 0);

        rotacionY = Mathf.Clamp(rotacionY, anguloMinimo, anguloMaximo);

        Quaternion localRotation = Quaternion.Euler(-rotacionY,0, 0);
        camaraHombro.localRotation = localRotation;

        cam.position = Vector3.Lerp(cam.position, camaraHolder.position, camaraVelocidad * deltaT);
        cam.rotation = Quaternion.Lerp(cam.rotation, camaraHolder.rotation, camaraVelocidad * deltaT);
    }

}
